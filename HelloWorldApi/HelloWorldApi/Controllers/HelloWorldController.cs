using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace HelloWorldApi.Controllers
{
    public class HelloWorldController : ApiController
    {
        [HttpGet]
        public List<string> ReadAll()
        {
            return new List<string> { "Hello World", "Web Api Demo" };
        }

        public string Get(int x)
        { 
            return "Hello World" +x;
        }
    }
}