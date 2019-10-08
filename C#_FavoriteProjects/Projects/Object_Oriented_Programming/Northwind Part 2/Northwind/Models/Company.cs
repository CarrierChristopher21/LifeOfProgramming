using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
    public abstract class Company
    {
        // there is no primary key in Company()
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
        private bool isDirty = false;
		private BrokenRules theBrokenRules = new BrokenRules();

        public string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
				isDirty = true;
				if(value.Length > 0)
				{
					this.companyName = value;
				}
				else
				{
					this.companyName = "n/a";
				}

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "NameRequired";
				aRule.RuleDescription = "You must supply a non emptry Company Name";
				// **********************************************************************
				// **********************************************************************

				theBrokenRules.CheckRule(aRule.RuleName, aRule, (value.Length > 0));
				
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
				isDirty = true;
				if(value.Length > 0)
				{
					this.contactName = value;
				}
				else
				{
					this.contactName = "n/a";
				}

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "NameRequired";
				aRule.RuleDescription = "You must supply a non emptry Contact Name";
				// **********************************************************************
				// **********************************************************************

				theBrokenRules.CheckRule(aRule.RuleName, aRule, (value.Length > 0));
				
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
				isDirty = true;
				if(value.Length > 0)
				{
					this.contactTitle = value;
				}
				else
				{
					this.contactTitle = "n/a";
				}

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "NameRequired";
				aRule.RuleDescription = "You must supply a non emptry Contact Title";
				// **********************************************************************
				// **********************************************************************

				theBrokenRules.CheckRule(aRule.RuleName, aRule, (value.Length > 0));
				
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
				isDirty = true;
				if(value.Length > 0)
				{
					this.address = value;
				}
				else
				{
					this.address = "n/a";
				}

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "NameRequired";
				aRule.RuleDescription = "You must supply a non emptry Address";
				// **********************************************************************
				// **********************************************************************

				theBrokenRules.CheckRule(aRule.RuleName, aRule, (value.Length > 0));
				
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
				isDirty = true;
				if(value.Length > 0)
				{
					this.city = value;
				}
				else
				{
					this.city = "n/a";
				}

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "NameRequired";
				aRule.RuleDescription = "You must supply a non emptry City";
				// **********************************************************************
				// **********************************************************************

				theBrokenRules.CheckRule(aRule.RuleName, aRule, (value.Length > 0));

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
				isDirty = true;
				if(value.Length > 0)
				{
					this.region = value;
				}
				else
				{
					this.region = "n/a";
				}

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "NameRequired";
				aRule.RuleDescription = "You must supply a non emptry Region";
				// **********************************************************************
				// **********************************************************************

				theBrokenRules.CheckRule(aRule.RuleName, aRule, (value.Length > 0));
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
				isDirty = true;
				if(value.Length > 0)
				{
					this.postalCode = value;
				}
				else
				{
					this.postalCode = "n/a";
				}

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "NameRequired";
				aRule.RuleDescription = "You must supply a non emptry Postal Code";
				// **********************************************************************
				// **********************************************************************

				theBrokenRules.CheckRule(aRule.RuleName, aRule, (value.Length > 0));

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
				isDirty = true;
				if(value.Length > 0)
				{
					this.country = value;
				}
				else
				{
					this.country = "n/a";
				}

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "NameRequired";
				aRule.RuleDescription = "You must supply a non emptry Country";
				// **********************************************************************
				// **********************************************************************

				theBrokenRules.CheckRule(aRule.RuleName, aRule, (value.Length > 0));

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
				isDirty = true;
                if(value.Length > 0)
				{
					this.phone = value;
				}
				else
				{
					this.phone = "n/a";
				}

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "NameRequired";
				aRule.RuleDescription = "You must supply a non emptry Phone";
				// **********************************************************************
				// **********************************************************************

				theBrokenRules.CheckRule(aRule.RuleName, aRule, (value.Length > 0));

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
				isDirty = true;
				if(value.Length > 0)
				{
					this.fax = value;
				}
				else
				{
					this.fax = "n/a";
				}

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "NameRequired";
				aRule.RuleDescription = "You must supply a non emptry Fax";
				// **********************************************************************
				// **********************************************************************

				theBrokenRules.CheckRule(aRule.RuleName, aRule, (value.Length > 0));
				
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
				isDirty = true;
                if(value.Length > 0)
				{
					this.homePage = value;
				}
				else
				{
					this.homePage = "n/a";
				}

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "NameRequired";
				aRule.RuleDescription = "You must supply a non emptry Home Page";
				// **********************************************************************
				// **********************************************************************

				theBrokenRules.CheckRule(aRule.RuleName, aRule, (value.Length > 0));

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

		public bool IsValid
		{
			get
			{
				if(theBrokenRules.GetDictionary().Count > 0)
				{
					return false;
				}
				else
				{
					return true;
				}
			}
		}

        public Company()
			: this("n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {
        // We should be calling this from our children
        // and I am not
        }


        public Company(string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion, 
			string aPostalCode, string aCountry, string aPhone, string aFax, string aHomePage)
        {

             this.CompanyName = aCompanyName;
             this.ContactName = aContactName;
             this.ContactTitle = aContactTitle;
			 this.Address = anAddress;
			 this.City = aCity;
			 this.Region = aRegion;
			 this.PostalCode = aPostalCode;
			 this.Country = aCountry;
			 this.Phone = aPhone;
			 this.Fax = aFax;
			 this.HomePage = aHomePage;

        }

		public Company(string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion, 
		string aPostalCode, string aCountry, string aPhone, string aFax)
			: this(aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, aFax, "n/a")
		{
			
		}

		public Company(string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion, 
		string aPostalCode, string aCountry, string aPhone)
			: this(aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, "n/a", "n/a")
		{

		}

		public Company(string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion,
		string aPostalCode, string aCountry)
			: this(aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, "n/a", "n/a", "n/a")
		{

		}

		public Company(string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion,
		string aPostalCode)
			: this(aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, "n/a", "n/a", "n/a", "n/a")
		{

		}

		public Company(string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion)
			: this(aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, "n/a", "n/a", "n/a", "n/a", "n/a")
		{

		}

		public Company(string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity)
			: this(aCompanyName, aContactName, aContactTitle, anAddress, aCity, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
		{

		}

		public Company(string aCompanyName, string aContactName, string aContactTitle, string anAddress)
			: this(aCompanyName, aContactName, aContactTitle, anAddress, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
		{

		}

		public Company(string aCompanyName, string aContactName, string aContactTitle)
			: this(aCompanyName, aContactName, aContactTitle, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
		{

		}

		public Company(string aCompanyName, string aContactName)
			: this(aCompanyName, aContactName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
		{

		}

		public Company(string aCompanyName)
			: this(aCompanyName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
		{

		}

		//       public string ToString()   don't do this
        public override string ToString()
        {

            string message = "";
            message = message + "Company Name = " + this.CompanyName + "<br />";
            message = message + "Contact Name = " + this.ContactName + "<br />";
            message = message + "Contact Title = " + this.ContactTitle + "<br />";
            message = message + "Address = " + this.Address + "<br />";
            message = message + "City = " + this.City + "<br />";
            message = message + "Region = " + this.Region + "<br />";
            message = message + "Postal Code = " + this.PostalCode + "<br />";
            message = message + "Country = " + this.Country + "<br />";
            message = message + "Phone = " + this.Phone + "<br />";
            message = message + "Fax = " + this.Fax + "<br />";
            message = message + "Home Page = " + this.HomePage + "<br /><br />";

            return message;

        }

    }
}