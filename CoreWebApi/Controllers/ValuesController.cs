using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //http://localhost:5000/api/values
        public string Get()
        {
            return "GetTime";
        }
        //http://localhost:5000/api/values/getdate
        [HttpGet]
        [Route("[action]")] // In Asp.net Core MVC  - action represents controller public  method 
        public string GetDate()
        {
            return "GetDate";

        }

        //http://localhost:5000/api/values/hello
        [HttpGet("{msg}")]
        public string Get(string msg)
        {
            return msg;
        }

        //http://localhost:5000/api/values/hello/hi/bye
        [HttpGet("{a}/{b}/{c}")]
        public string Get(string a, string b , string c)
        {
            return a + b + c;
        }
    }
}
