using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectApplication_N01522297.Controllers
{
    public class SquareController : ApiController
    {
        /*
         * GET function that takes in an integer value {id} 
         * and returns the square of that value
         */
        /*
         * Tests (Cover negative, positive and 0)
         * GET localhost/api/Square/2 -> 4
         * GET localhost/api/Square/-2 -> 4
         * GET localhost/api/Square/10 -> 100
         * GET localhost/api/Square/0 -> 0
         */
        public int Get(int id)
        {
            // Store value of id squared
            int idSquared = id * id;
            // Return calculated value
            return idSquared;
        }
    }
}
