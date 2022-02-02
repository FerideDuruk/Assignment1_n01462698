using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01462698.Controllers
{
    public class AddTenController : ApiController
    {
        //GET localhost/api/addten/21 -> 31
        //GET localhost/api/addten/0 -> 10
        //GET localhost/api/addten/-9 -> 1
        public int Get(int id)
        {
            int plusTen = id + 10;
            return plusTen;
        }

    }
}
