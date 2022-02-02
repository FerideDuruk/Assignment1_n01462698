using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01462698.Controllers
{
    public class ExampleController : ApiController
    {
        // Code needs to be written in here
        // GET api/example
        // We want to print the message of hello when a GET request is sent to the server
        public string Get()
        {
            return "Hello!";
        }

        //GET api/exapmle/50 -> 200
        //GET api/exapmle/100 -> 400
        public int Get(int id)
        {

            return id * 4;
        }

    }
}
