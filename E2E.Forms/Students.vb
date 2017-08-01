Public Class Student
    Private name As String

    Public Property Name1 As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property Name2 As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Sub New(name As String, name1 As String)
        Me.name = name
        Me.Name1 = name1
    End Sub
End Class