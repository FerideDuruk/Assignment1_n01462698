using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01462698.Controllers
{
    public class SquareController : ApiController
    {
        //GET localhost/api/square/2 -> 4
        //GET localhost/api/square/-2 -> 4
        //GET localhost/api/square/10 -> 100
        public int Get(int id)
        {
            int sq = id * id;
            return sq;
        }

    }
}
