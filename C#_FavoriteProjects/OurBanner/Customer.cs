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

namespace OurBanner
{
    public class Customer
    {
        //Declaration
        private String customerId = "n/a";
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
        private static int numberOfCustomers = 0;

        //Gets And Sets
        public string CustomerId
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

        public string Address
        {
            get
            {
                return this.address;
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
                return this.city;
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
            Customer.numberOfCustomers++;
        }

        public Customer(string anId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity, 
            string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax)
            : this()
        {
            this.customerId = anId;             // Do Not Capatilize the variable for anID
            this.CompanyName = aCompanyName;    // Capatilize the rest of the this.variable's
            this.ContactName = aContactName;
            this.ContactTitle = aContactTitle;
            this.Address = aAddress;
            this.City = aCity;
            this.Region = aRegion;
            this.PostalCode = aPostalCode;
            this.Country = aCountry;
            this.Phone = aPhone;
            this.Fax = aFax;
        
        }

        public Customer(string anId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity,
            string aRegion, string aPostalCode, string aCountry, string aPhone)
            : this(anId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, "n/a")
        {
            
        }

        public Customer(string anId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity,
            string aRegion, string aPostalCode, string aCountry)
            : this(anId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, aPostalCode, aCountry, "n/a", "n/a")
        {

        }

        public Customer(string anId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity,
            string aRegion, string aPostalCode)
            : this(anId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, aPostalCode, "n/a", "n/a", "n/a")
        {

        }

        public Customer(string anId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity,
            string aRegion)
            : this(anId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Customer(string anId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity)
            : this(anId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Customer(string anId, string aCompanyName, string aContactName, string aContactTitle, string aAddress)
            : this(anId, aCompanyName, aContactName, aContactTitle, aAddress, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Customer(string anId, string aCompanyName, string aContactName, string aContactTitle)
            : this(anId, aCompanyName, aContactName, aContactTitle, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Customer(string anId, string aCompanyName, string aContactName)
            : this(anId, aCompanyName, aContactName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Customer(string anId, string aCompanyName)
            : this(anId, aCompanyName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Customer(string anId)
            : this(anId, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public static int GetNumberOfCustomer()
        {
            return Customer.numberOfCustomers;
        }

        //Output
        public override string ToString()
        {
            string aString = "";
            aString = aString + "Customer ID = " + CustomerId + "\n";
            aString = aString + "Company Name = " + CompanyName + "\n";
            aString = aString + "Contact Name = " + ContactName  + "\n";
            aString = aString + "Contact Title = " + ContactTitle + "\n";
            aString = aString + "Address = " + Address + "\n";
            aString = aString + "City = " + City + "\n";
            aString = aString + "Region = " + Region + "\n";
            aString = aString + "Postal Code = " + PostalCode + "\n";
            aString = aString + "Country = " + Country + "\n";
            aString = aString + "Phone = " + Phone + "\n";
            aString = aString + "Fax = " + Fax + "\n";
            aString = aString + "Number Of Customers = " + numberOfCustomers + "\n";

            return aString;
        }
    }
}
