using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01462698.Controllers
{
    public class HostingCostController : ApiController
    {

        public string Get(int id)
        {
            int nun = Math.Floor(id / 14) + 1;
            //int ftn;
            //if (id < 14)
            //{
            //    ftn = 1;
            //}
            //else if (id < 28)
            //{
            //    ftn = 2;
            //}
            //else if (id < 42)
            //{
            //    ftn = 3;
            //}
            //else
            //{
            //    ftn = 4;
            //}
            return ftn + " fortnights at $5.50/FN = " + (ftn * 5.50) + " CAD, HST 13% = " + (ftn * 5.50 * 0.13) + " CAD, Total = " + (ftn * 5.50 * 1.13) + " CAD";
        }
    }
}
