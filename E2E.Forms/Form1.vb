Imports System.Net.Http
Imports Newtonsoft.Json


Public Class Form1

    Private ReadOnly client As HttpClient = New HttpClient()
    Public FF As Form1 = New Form1()

    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click
        Try
            HandleIt()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub InputField_KeyDown(sender As Object, e As KeyEventArgs) Handles InputField.KeyDown
        If e.KeyCode = Keys.Enter Then
            HandleIt()
        End If
    End Sub

    Private Sub HandleIt()
        Dim input As String = InputField.Text
        Dim pigLatin As String = Core.PigLatin.toPigLatin(input)
        ResultLabel.Text = $"{input} -> {pigLatin}"
    End Sub

    Private Async Sub WebServiceButton_Click(sender As Object, e As EventArgs) Handles WebServiceButton.Click
        Dim url As String = $"http://localhost:53303/api/values?word={InputField.Text}"
        Dim json = Await client.GetStringAsync(url)
        Dim result = JsonConvert.DeserializeObject(Of String)(json)
        ResultLabel.Text = $"{InputField.Text} -> {result}"
    End Sub
End Class
