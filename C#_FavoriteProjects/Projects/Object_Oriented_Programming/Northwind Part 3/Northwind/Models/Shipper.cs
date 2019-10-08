/*	Author: Chris Carrier
 *	Date:	1/15/15
 *	Information: This class receives the Shipper data and then assigns the Shipper data to a the specific variable within 
 *	the class. It also inherits data from the Company class. Also, this class will test if the data is blank or not available 
 *	by using constructors. It also sets up the ToString() format for this file for when its called.
 */

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