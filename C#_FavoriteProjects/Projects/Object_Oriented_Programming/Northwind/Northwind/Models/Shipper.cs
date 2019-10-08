using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
    public class Shipper : Company
    {
        private int shipperId = 0;

        public string GetName()
        {
            return "";
        }

        public string GetPhone()
        {
            return "";
        }
        public int ShipperId
        {

            get
            {
                return shipperId;

            } 
            // should be read only
            set
            {
                shipperId = value;
            }
        }

        public Shipper()
			: this(0, "n/a", "n/a")
        {

        }

        public Shipper(int aShipperId, string aCompanyName, string aPhone)
            : base(aCompanyName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", aPhone, "n/a", "n/a")
        {
            ShipperId = aShipperId;
        }

        public override string ToString()
        {

            string message = "Shipper Id = " + this.ShipperId +  "<br />";
            message = message + "Company Name = " + base.CompanyName + " <br />";
			message = message + "Phone = " + base.Phone + " <br /><br />";

            return message;

        }

    }
}