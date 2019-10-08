/* Christopher Carrier
 * HW 1
 * 1/30/14
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public class Customer
    {
        //Declaration
        private int customerId = -1;
        private string companyName = "n/a";
        private string contactName = "n/a";
        private string contactTitle = "n/a";
        private string addressCity = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string phone = "n/a";
        private string fax = "n/a";
        
        //Gets And Sets
        public int CustomerId
        {
            get
            {
                return this.customerId;
            }
        }

        public string CompanyName
        {
            get
            {
                return this.companyName;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.companyName = value;
                }
                else
                {
                    this.companyName = "n/a";
                }
            }
        }

        public string ContactName
        {
            get
            {
                return this.contactName;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.contactName = value;
                }
                else
                {
                    this.contactName = "n/a";
                }
            }
        }

        public string ContactTitle
        {
            get
            {
                return this.contactTitle;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.contactTitle = value;
                }
                else
                {
                    this.contactTitle = "n/a";
                }
            }
        }

        public string AddressCity
        {
            get
            {
                return this.addressCity;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.addressCity = value;
                }
                else
                {
                    this.addressCity = "n/a";
                }
            }
        }

        public string Region
        {
            get
            {
                return this.region;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.region = value;
                }
                else
                {
                    this.region = "n/a";
                }
            }
        }

        public string PostalCode
        {
            get
            {
                return this.postalCode;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.postalCode = value;
                }
                else
                {
                    this.postalCode = "n/a";
                }
            }
        }

        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.country = value;
                }
                else
                {
                    this.country = "n/a";
                }
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.phone = value;
                }
                else
                {
                    this.phone = "n/a";
                }
            }
        }

        public string Fax
        {
            get
            {
                return this.fax;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.fax = value;
                }
                else
                {
                    this.fax = "n/a";
                }
            }
        }

        //Constructors
        public Customer()
        {

        }

        public Customer(int anId, string acompanyName, string acontactName, string acontactTitle, 
            string aaddressCity, string aregion, string apostalCode, string acountry, string 
            aphone, string afax)
            : this()
        {
            this.customerId = anId;             // Do Not Capatilize the variable for anID
            this.CompanyName = acompanyName;    // Capatilize the rest of the this.variable's
            this.ContactName = acontactName;
            this.ContactTitle = acontactTitle;
            this.AddressCity = aaddressCity;
            this.Region = aregion;
            this.PostalCode = apostalCode;
            this.Country = acountry;
            this.Phone = aphone;
            this.Fax = afax;
        
        }

        public Customer(int anId, string acompanyName, string acontactName, string acontactTitle, 
            string aaddressCity, string aregion, string apostalCode, string acountry, string 
            aphone)
            : this(anId, acompanyName, acontactName, acontactTitle, aaddressCity, aregion, 
            apostalCode, acountry, aphone, "n/a")
        {
            
        }

        public Customer(int anId, string acompanyName, string acontactName, string acontactTitle, 
            string aaddressCity, string aregion, string apostalCode, string acountry)
            : this(anId, acompanyName, acontactName, acontactTitle, aaddressCity, aregion, 
            apostalCode, acountry, "n/a", "n/a")
        {

        }

        public Customer(int anId, string acompanyName, string acontactName, string acontactTitle, 
            string aaddressCity, string aregion, string apostalCode)
            : this(anId, acompanyName, acontactName, acontactTitle, aaddressCity, aregion, 
            apostalCode, "n/a", "n/a", "n/a")
        {

        }

        public Customer(int anId, string acompanyName, string acontactName, string acontactTitle, 
            string aaddressCity, string aregion)
            : this(anId, acompanyName, acontactName, acontactTitle, aaddressCity, aregion, "n/a", 
            "n/a", "n/a", "n/a")
        {

        }

        public Customer(int anId, string acompanyName, string acontactName, string acontactTitle, 
            string aaddressCity)
            : this(anId, acompanyName, acontactName, acontactTitle, aaddressCity, "n/a", "n/a", 
            "n/a", "n/a", "n/a")
        {

        }

        public Customer(int anId, string acompanyName, string acontactName, string acontactTitle)
            : this(anId, acompanyName, acontactName, acontactTitle, "n/a", "n/a", "n/a", "n/a", 
            "n/a", "n/a")
        {

        }

        public Customer(int anId, string acompanyName, string acontactName)
            : this(anId, acompanyName, acontactName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", 
            "n/a")
        {

        }

        public Customer(int anId, string acompanyName)
            : this(anId, acompanyName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Customer(int anId)
            : this(anId, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }
        
        //Output
        public override string ToString()
        {
            string aString = "";
            aString = aString + "Customer ID = " + CustomerId + "\n";
            aString = aString + "Company Name = " + CompanyName + "\n";
            aString = aString + "Contact Name = " + ContactName  + "\n";
            aString = aString + "Contact Title = " + ContactTitle + "\n";
            aString = aString + "Address City = " + AddressCity + "\n";
            aString = aString + "Region = " + Region + "\n";
            aString = aString + "Postal Code = " + PostalCode + "\n";
            aString = aString + "Country = " + Country + "\n";
            aString = aString + "Phone = " + Phone + "\n";
            aString = aString + "Fax = " + Fax + "\n";
            
            return aString;
        }
    }
}
