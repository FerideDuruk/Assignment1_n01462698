using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01462698.Controllers
{
    public class NumberMachineController : ApiController
    {
        //GET localhost/api/numbermachine/10 -> 1
        //GET localhost/api/numbermachine/-5 -> -29
        //GET localhost/api/numbermachine/30 -> 41
        public int Get(int id)
        {
            return ((id - 10) * 2 + 5 / 5);
        }
    }
}
