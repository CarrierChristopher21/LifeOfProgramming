/*	Author: Chris Carrier
 *	Date:	1/15/15
 *	Information: This class receives the Supplier data and then assigns the Supplier data to a the specific variable within 
 *	the class. It also inherits data from the Company class. Also, this class will test if the data is blank or not available 
 *	by using constructors. It also sets up the ToString() format for this file for when its called.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
    public class Supplier: Company
    {
        private int supplierId = 0;
		//private bool isDirty = false;
		private BrokenRules theBrokenRules = new BrokenRules();
        public int SupplierId
        {
            get
            {
                return supplierId;
            }
        }

		/*public bool isDirty
		{
			get
			{
				return IsDirty;
			}
			set
			{
				IsDirty = value;
			}
		}*/


        public Supplier()
			:this(0, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Supplier(int aSupplierId, string aCompanyName, string aContactName, string aContactTitle, string anAddress, 
				string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax, string aHomePage)
			:base(aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, aFax, aHomePage)
        {
            this.supplierId = aSupplierId;
        }

        public override string ToString() {

            string message = "Supplier Id = " + this.SupplierId + "<br />";
            message = message + base.ToString();

            return message;        
        }
    }
}