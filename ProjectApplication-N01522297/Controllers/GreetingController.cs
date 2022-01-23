using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectApplication_N01522297.Controllers
{
    public class GreetingController : ApiController
    {
        /*
         * GET function that takes in an integer value {id}
         * and returns a greeting to {id} number of people
         */
        /*
         * Tests 
         * GET localhost/api/Greeting/3 -> "Greetings to 3 people!"
         * GET localhost/api/Greeting/6 -> "Greetings to 6 people!"
         * GET localhost/api/Greeting/0 -> "Greetings to 0 people!"
         *
         */
        public string Get(int id)
        {
            // Store greeting of id number of people
            string greeting = $"Greetings to {id} people!";
            // Return greeting
            return greeting;
        }
        /*
         * POST function that does not require body data
         * and returns a basic greeting 
         */
        /*
         * Tests 
         * POST localhost/api/Greeting -> "Hello World!"
         */
        public string Post()
        {
            // Store the greeting to be later used
            string greeting = "Hello World!";
            // Return greeting
            return greeting;
        }
    }
}
