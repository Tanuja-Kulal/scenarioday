using E2E.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace E2E.API.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values/some-word-to-turn-to-pig-latin
        public string Get(string word)
        {
            new Persons().Name = word;
            TestMethod("s1", "s2");
            return PigLatin.ToPigLatin(word);
        }

        private void TestMethod(string s1, string s2)
        {
            //do nothing;
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
