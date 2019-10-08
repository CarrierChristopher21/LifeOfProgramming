/* Christopher Carrier
 * Lab 1
 * 1/30/14
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1
{
    public class Supplier
    {
        // Declaration
        private int supplierId = -1;
        private string companyName = "n/a";
        private string contactName = "n/a";
        private string contactTitle = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string phone = "n/a";
        private string fax = "n/a";
        private string homePage = "n/a";

        // Get And Sets
        public int SupplierId
        {
            get
            {
                return supplierId;
            }
        }
        public string CompanyName
        {
            get
            {
               // string companyName = "nike"; Use 'this.' if their is a local variable named the same variable that is being called
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
                return contactName;
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
                return contactTitle;
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
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.address = value;
                }
                else
                {
                    this.address = "n/a";
                }
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.city = value;
                }
                else
                {
                    this.city = "n/a";
                }
            }
        }
        public string Region
        {
            get
            {
                return region;
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
                return postalCode;
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
                return country;
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
                return phone;
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
                return fax;
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
        public string HomePage
        {
            get
            {
                return homePage;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.homePage = value;
                }
                else
                {
                    this.homePage = "n/a";
                }
            }
        }

        // Constructors
        public Supplier()
        {


        }
        public Supplier(int anId, string acompanyName, string acontactName, string acontactTitle,
            string aaddress, string acity, string aregion, string apostalCode, string acountry,
            string aphone, string afax, string ahomePage)
            : this()
        {

            this.supplierId = anId;             // Do Not Capatilize the variable for anID
            this.CompanyName = acompanyName;    // Capatilize the rest of the this.variable's
            this.ContactName = acontactName;
            this.ContactTitle = acontactTitle;
            this.Address = aaddress;
            this.City = acity;
            this.Region = aregion;
            this.PostalCode = apostalCode;
            this.Country = acountry;
            this.Phone = aphone;
            this.Fax = afax;
            this.HomePage = ahomePage;
            
        }
        public Supplier(int anId, string acompanyName, string acontactName, string acontactTitle,
            string aaddress, string acity, string aregion, string apostalCode, string acountry,
            string aphone, string afax)
            : this(anId, acompanyName, acontactName, acontactTitle, aaddress, acity, aregion,
            apostalCode, acountry, aphone, afax, "n/a")
        {

        }
        public Supplier(int anId, string acompanyName, string acontactName, string acontactTitle,
            string aaddress, string acity, string aregion, string apostalCode, string acountry,
            string aphone)
            : this(anId, acompanyName, acontactName, acontactTitle, aaddress, acity, aregion,
            apostalCode, acountry, aphone, "n/a", "n/a")
        {

        }
        public Supplier(int anId, string acompanyName, string acontactName, string acontactTitle,
            string aaddress, string acity, string aregion, string apostalCode, string acountry)
            : this(anId, acompanyName, acontactName, acontactTitle, aaddress, acity, aregion,
            apostalCode, acountry, "n/a", "n/a", "n/a")
        {

        }
        public Supplier(int anId, string acompanyName, string acontactName, string acontactTitle,
            string aaddress, string acity, string aregion, string apostalCode)
            : this(anId, acompanyName, acontactName, acontactTitle, aaddress, acity, aregion,
            apostalCode, "n/a", "n/a", "n/a", "n/a")
        {

        }
        public Supplier(int anId, string acompanyName, string acontactName, string acontactTitle,
            string aaddress, string acity, string aregion)
            : this(anId, acompanyName, acontactName, acontactTitle, aaddress, acity, aregion,
            "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }
        public Supplier(int anId, string acompanyName, string acontactName, string acontactTitle,
            string aaddress, string acity)
            : this(anId, acompanyName, acontactName, acontactTitle, aaddress, acity, "n/a",
            "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }
        public Supplier(int anId, string acompanyName, string acontactName, string acontactTitle,
            string aaddress)
            : this(anId, acompanyName, acontactName, acontactTitle, aaddress, "n/a", "n/a",
            "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }
        public Supplier(int anId, string acompanyName, string acontactName, string acontactTitle)
            : this(anId, acompanyName, acontactName, acontactTitle, "n/a", "n/a", "n/a",
            "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }
        public Supplier(int anId, string acompanyName, string acontactName)
            : this(anId, acompanyName, acontactName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a",
            "n/a", "n/a", "n/a")
        {

        }
        public Supplier(int anId, string acompanyName)
            : this(anId, acompanyName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a",
            "n/a", "n/a", "n/a")
        {

        }
        public Supplier(int anId)
            : this(anId, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a",
            "n/a", "n/a", "n/a")
        {

        }
        
        // Output
        public override string ToString()
        {
            string aString = "";
            aString = aString + "Supplier ID = " + SupplierId + "\n";
            aString = aString + "Company Name = " + CompanyName + "\n";
            aString = aString + "Contact Name = " + ContactName + "\n";
            aString = aString + "Contact Title = " + ContactTitle + "\n";
            aString = aString + "Address = " + Address + "\n";
            aString = aString + "City = " + City + "\n";
            aString = aString + "Region = " + Region + "\n";
            aString = aString + "Postal Code = " + PostalCode + "\n";
            aString = aString + "Country = " + Country + "\n";
            aString = aString + "Phone = " + Phone + "\n";
            aString = aString + "Fax = " + Fax + "\n";
            aString = aString + "Home Page = " + HomePage + "\n";

            return aString;
        }

    }
}

