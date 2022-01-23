using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectApplication_N01522297.Controllers
{
    public class AddTenController : ApiController
    {
        // Here we can define the requests and responses!
        /*
         * GET function that takes in an integer value {id}
         * and returns the value plus 10
         */
        /*
         * Tests (Cover negative, positive and 0)
         * GET localhost/api/AddTen/21 -> 31
         * GET localhost/api/AddTen/0 -> 10
         * GET localhost/api/AddTen/-9 -> 1
         *
         */
        public int Get(int id)
        {
            // inputPlusTen takes the passed in integer value and adds ten
            int inputPlusTen = id + 10;
            // Return calculated value
            return inputPlusTen;
        }
    }
}
