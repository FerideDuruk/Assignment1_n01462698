using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01462698.Controllers
{
    public class GreetingController : ApiController
    {
        //POST localhost/api/greeting
        public string Post()
        {
            return "Hello World!";
        }
        //GET localhost/api/greeting/3
        //GET localhost/api/greeting/6
        //GET localhost/api/greeting/0
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
