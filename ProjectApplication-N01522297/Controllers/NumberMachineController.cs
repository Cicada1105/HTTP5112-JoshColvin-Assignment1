using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectApplication_N01522297.Controllers
{
    public class NumberMachineController : ApiController
    {
        /*
         * GET function that takes in an integer value {id},
         * calculates the modulus (remainder) using the integer 2,
         * adds the modulus to the number (making it even),
         * square the resulting number and then subtracting its original number
         * This value is returned
         */
        /*
         * Tests (Cover negative, positive and 0)
         * GET localhost/api/Square/10 -> 90
         * GET localhost/api/Square/-5 -> 41
         * GET localhost/api/Square/30 -> 870
         * GET localhost/api/Square/0 -> 0
         */
        public int Get(int id)
        {
            int remainder = id % 2;
            int evenNum = id + remainder;
            int numSquared = evenNum * evenNum;
            int result = numSquared - id;
            return result;
        }
    }
}
