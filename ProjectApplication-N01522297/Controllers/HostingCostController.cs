using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectApplication_N01522297.Controllers
{
    public class HostingCostController : ApiController
    {
        /*
         * GET function that takes in id which represents the number
         * of days a client is being charged for web hosting and maintenance
         * 
         * Return:
         *  int baseCost -> price of hosting before taxes
         *  int taxes -> calculated taxes based on baseCost
         *  int amountOwed -> total cost of hosting after adding in taxes
         */
        /*
         * Tests
         * GET localhost/api/HostingCost/0    ->   1 fortnight(s) at $5.50/FN = $5.50 CAD
                                                   HST 13% = $0.72 CAD
                                                   Total = $6.22
         * GET localhost/api/HostingCost/14   ->   2 fortnight(s) at $5.50/FN = $11.00 CAD
                                                   HST 13% = $1.43 CAD
                                                   Total = $12.43
         * GET localhost/api/HostingCost/15   ->   2 fortnight(s) at $5.50/FN = $11.00 CAD
                                                   HST 13% = $1.43 CAD
                                                   Total = $12.43
         * GET localhost/api/HostingCost/21   ->   2 fortnight(s) at $5.50/FN = $11.00 CAD
                                                   HST 13% = $1.43 CAD
                                                   Total = $12.43
         * GET localhost/api/HostingCost/28   ->   3 fortnight(s) at $5.50/FN = $16.50 CAD
                                                   HST 13% = $2.15 CAD
                                                   Total = $18.65
         */
        public IEnumerable<string> Get(int id)
        {
            // Store fornight "constant"
            int FORTNIGHT = 14;
            float PRICE_PER_FORNIGHT = 5.50f;
            float HST = 0.13f;
            // Calculate how many fornights the client is being charged for
            // (add 1 to compensate for division rounding down. ie 5 / 14 = 0 -> counts as full fortnight price)
            int numChargedFortnights = (id / FORTNIGHT) + 1;
            // Calculate base cost (number of fornights * cost per fornight)
            float baseCost = numChargedFortnights * PRICE_PER_FORNIGHT;
            // Calculate the amount taxed
            float taxes = baseCost * HST;
            // Calculate total owed for web hosting
            float amountOwed = baseCost + taxes;

            // Format return strings 
            /*
             * Retrieved string formatting reference from:
             * https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=net-6.0
             */
            string baseCostStr = String.Format("{0} fortnight(s) at {1:C2}/FN = {2:C2} CAD",numChargedFortnights, PRICE_PER_FORNIGHT, baseCost);
            string taxesStr = String.Format("HST 13% = {0:C2} CAD",taxes);
            string amountOwedStr = String.Format("Total = {0:C2} CAD",amountOwed);

            return new string[] { baseCostStr, taxesStr, amountOwedStr };
        }
    }
}
