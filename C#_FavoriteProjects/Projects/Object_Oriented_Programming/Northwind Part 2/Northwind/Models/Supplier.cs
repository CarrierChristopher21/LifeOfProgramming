using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
    public class Supplier: Company
    {
        private int supplierId = 0;
		private bool isDirty = false;
		private BrokenRules theBrokenRules = new BrokenRules();
        public int SupplierId
        {
            get
            {
                return supplierId;
            }
            set
            {
				isDirty = true;
                supplierId = value;
            }
        }

		public bool IsDirty
		{
			get
			{
				return isDirty;
			}
			set
			{
				isDirty = value;
			}
		}

        public Supplier()
			:this(0, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Supplier(int aSupplierId, string aCompanyName, string aContactName, string aContactTitle, string anAddress, 
				string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax, string aHomePage)
			:base(aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, aFax, aHomePage)
        {
            SupplierId = aSupplierId;
        }

        public override string ToString() {

            string message = "Supplier Id = " + this.SupplierId + "<br />";
            message = message + base.ToString();

            return message;        
        }
    }
}