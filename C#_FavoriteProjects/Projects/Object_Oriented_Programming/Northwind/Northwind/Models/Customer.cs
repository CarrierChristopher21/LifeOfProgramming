using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
    public class Customer : Company
    {
        // Incorectly inherits a Homepage property
        private string customerId = "n/a";

        public string CustomerId
        {

            get
            {
                return customerId;

            }
            // Should we be doing this????
            // Should it be read only
            set
            {
                customerId = value;
            }
        }
        // By default, Constructors don't inherit
        public Customer()
            : this("n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {
            // ** ALWAYS ALWAYS ALWAYS Call the 
            // BASE() Constructor **
        }

        public Customer(string aCustomerId, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax, string aHomePage)
            : base(aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, aFax, aHomePage)
        {
            CustomerId = aCustomerId;
        }

        public override string ToString()
        {

            string message = "Customer Id = " + this.CustomerId + "<br />";
            message = message + base.ToString();

            return message;

        }



    }
}