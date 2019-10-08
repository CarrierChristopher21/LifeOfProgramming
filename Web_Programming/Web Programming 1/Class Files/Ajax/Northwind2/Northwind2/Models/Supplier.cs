using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace Northwind2.Models
{

    public class Supplier
    {

        private int supplierId = -1;
        private string companyName = "na";
        private string contactName = "na";
        private string contactTitle = "na";
        private string address = "na";
        private string city = "na";
        private string region = "na";
        private string postalCode = "na";
        private string country = "na";
        private string phone = "na";
        private string fax = "na";
        private string homePage = "na";
        private static int numberOfSuppliers = 0;

        public int SupplierId
        {
            get
            {
                return this.supplierId;
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
                this.companyName = value;

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
                this.contactName = value;
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
                this.contactTitle = value;
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
                this.address = value;
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
                this.city = value;
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
                this.region = value;
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
                this.postalCode = value;
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
                this.country = value;
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
                this.phone = value;
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
                this.fax = value;
            }
        }

        public string HomePage
        {
            get
            {
                return this.homePage;
            }

            set
            {
                this.homePage = value;
            }
        }

        // Constructors 

        public Supplier()
        {
            Supplier.numberOfSuppliers = Supplier.numberOfSuppliers + 1;
        }

        public Supplier(int aSupplierId, string aCompanyName, string aContactName, string aContactTile, 	string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string 	aPhone, string aFax, string aHomePage)
            : this()
        {

            this.supplierId = aSupplierId;
            this.CompanyName = aCompanyName;
            this.ContactName = aContactName;
            this.Address = aAddress;
            this.City = aCity;
            this.Region = aRegion;
            this.PostalCode = aPostalCode;
            this.Country = aCountry;
            this.Phone = aPhone;
            this.Fax = aFax;
            this.HomePage = aHomePage;
        }

        public Supplier(int aSupplierId, string aCompanyName, string aContactName, string 	aContactTitle, string aAddress, string aCity, string aRegion, string aPostalCode, string 	aCountry, string aPhone, string aFax)
            : this(aSupplierId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, 			aPostalCode, aCountry, aPhone, aFax, "na")
        {

        }

        public Supplier(int aSupplierId, string aCompanyName, string aContactName, string 	aContactTitle, string aAddress, string aCity, string aRegion, string aPostalCode, string 	aCountry, string aPhone)
            : this(aSupplierId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, "na", "na")
        {

        }

        public Supplier(int aSupplierId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity, string aRegion, string aPostalCode, string 	aCountry)
            : this(aSupplierId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, aPostalCode, aCountry, "na", "na", "na")
        {

        }

        public Supplier(int aSupplierId, string aCompanyName, string aContactName, string 	aContactTitle, string aAddress, string aCity, string aRegion, string aPostalCode)
            : this(aSupplierId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, aPostalCode, "na", "na", "na", "na")
        {

        }

        public Supplier(int aSupplierId, string aCompanyName, string aContactName, string 	aContactTitle, string aAddress, string aCity, string aRegion)
            : this(aSupplierId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, "na", "na", "na", "na", "na")
        {

        }

        public Supplier(int aSupplierId, string aCompanyName, string aContactName, string 	aContactTitle, string aAddress, string aCity)
            : this(aSupplierId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, "na", "na", "na", "na", "na", "na")
        {

        }

        public Supplier(int aSupplierId, string aCompanyName, string aContactName, string 	aContactTitle, string aAddress)
            : this(aSupplierId, aCompanyName, aContactName, aContactTitle, aAddress, "na", "na", "na", "na", "na", "na", "na")
        {

        }

        public Supplier(int aSupplierId, string aCompanyName, string aContactName, string 	aContactTitle)
            : this(aSupplierId, aCompanyName, aContactName, aContactTitle, "na", "na", "na", "na", "na", "na", "na", "na")
        {

        }

        public Supplier(int aSupplierId, string aCompanyName, string aContactName)
            : this(aSupplierId, aCompanyName, aContactName, "na", "na", "na", "na", "na", "na", "na", "na", "na")
        {

        }

        public Supplier(int aSupplierId, string aCompanyName)
            : this(aSupplierId, aCompanyName, "na", "na", "na", "na", "na", "na", "na", "na", "na", "na")
        {

        }

        public Supplier(int aSupplierId)
            : this(aSupplierId, "na", "na", "na", "na", "na", "na", "na", "na", "na", "na", "na")
        {

        }

        // ToString

        public override string ToString()
        {

            string aString = "";
            aString = aString + "Supplier Id = " + SupplierId + "\n";
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
            aString = aString + "HomePage = " + HomePage + "\n";
            aString = aString + "Number Of Shippers = " + Supplier.numberOfSuppliers + "\n";

            return aString;
        }

        public string Display()
        {

            string aString = "";
            aString = aString + "Supplier Id = " + SupplierId + "<br />";
            aString = aString + "Company Name = " + CompanyName + "<br />";
            aString = aString + "Contact Name = " + ContactName + "<br />";
            aString = aString + "Contact Title = " + ContactTitle + "<br />";
            aString = aString + "Address = " + Address + "<br />";
            aString = aString + "City = " + City  +"<br />";
            aString = aString + "Region = " + Region + "<br />";
            aString = aString + "Postal Code = " + PostalCode + "<br />";
            aString = aString + "Country = " + Country + "<br />";
            aString = aString + "Phone = " + Phone + "<br />";
            aString = aString + "Fax = " + Fax + "<br />";
            aString = aString + "HomePage = " + HomePage + "<br />"; 
            aString = aString + "Number Of Shippers = " + Supplier.numberOfSuppliers + "<br />";

            return aString;
        }
    }
}
 
