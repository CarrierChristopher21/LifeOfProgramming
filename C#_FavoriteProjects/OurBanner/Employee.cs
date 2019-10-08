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
    public class Employee
    {
        //Declaration
        private int employeeId = -1;
        private string lastName = "n/a";
        private string firstName = "n/a";
        private string title = "n/a";
        private string titleOfCourtesy = "n/a";
        private string birthDate = "n/a";
        private string hireDate = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string homePhone = "n/a";
        private string extension = "n/a";
        private string photo = "n/a";
        private string notes = "n/a";
        private int reportsTo = -1;
        private static int numberOfEmployees = 0;

        //Get and Sets
        public int EmployeeId
        {
            get
            {
                return employeeId;
            }
        }

        public int ReportsTo
        {
            get
            {
                return this.reportsTo;
            }
            set
            {
                if(value > 0)                   //For int's use just value but for string use value.length
                {
                    this.reportsTo = value;
                }
                else
                {
                    this.reportsTo = -1;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.lastName = value;
                }
                else
                {
                    this.lastName = "n/a";
                }
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.firstName = value;
                }
                else
                {
                    this.firstName = "n/a";
                }
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.title = value;
                }
                else
                {
                    this.title = "n/a";
                }
            }
        }

        public string TitleOfCourtesy
        {
            get
            {
                return this.titleOfCourtesy;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.titleOfCourtesy = value;
                }
                else
                {
                    this.titleOfCourtesy = "n/a";
                }
            }
        }

        public string BirthDate
        {
            get
            {
                return this.birthDate;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.birthDate = value;
                }
                else
                {
                    this.birthDate = "n/a";
                }
            }
        }

        public string HireDate
        {
            get
            {
                return this.hireDate;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.hireDate = value;
                }
                else
                {
                    this.hireDate = "n/a";
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

        public string HomePhone
        {
            get
            {
                return this.homePhone;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.homePhone = value;
                }
                else
                {
                    this.homePhone = "n/a";
                }
            }
        }

        public string Extension
        {
            get
            {
                return this.extension;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.extension = value;
                }
                else
                {
                    this.extension = "n/a";
                }
            }
        }

        public string Photo
        {
            get
            {
                return this.photo;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.photo = value;
                }
                else
                {
                    this.photo = "n/a";
                }
            }
        }

        public string Notes
        {
            get
            {
                return this.notes;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.notes = value;
                }
                else
                {
                    this.notes = "n/a";
                }
            }
        }

        //Constructors
        public Employee()
        {
            Employee.numberOfEmployees++;
        }

        public Employee(int anId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy,
            string aBirthDate, string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, 
            string aHomePhone, string aExtension, string aPhoto, string aNotes, int aReportsTo)
            : this()
        {
            this.employeeId = anId;             // Do Not Capatilize the variable for anID
            this.LastName = aLastName;          // Capatilize the rest of the this.variable's
            this.FirstName = aFirstName;
            this.Title = aTitle;
            this.TitleOfCourtesy = aTitleOfCourtesy;
            this.BirthDate = aBirthDate;
            this.HireDate = aHireDate;
            this.Address = aAddress;
            this.City = aCity;
            this.Region = aRegion;
            this.PostalCode = aPostalCode;
            this.Country = aCountry;
            this.HomePhone = aHomePhone;
            this.Extension = aExtension;
            this.Photo = aPhoto;
            this.Notes = aNotes;
            this.ReportsTo = aReportsTo; 

        }

        public Employee(int anId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, 
            string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, 
            string aExtension, string aPhoto, string aNotes)
            : this(anId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode, 
            aCountry, aHomePhone, aExtension, aPhoto, aNotes, -1)
        {

        }

        public Employee(int anId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate,
            string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone,
            string aExtension, string aPhoto)
            : this(anId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode,
            aCountry, aHomePhone, aExtension, aPhoto, "n/a", -1)
        {

        }

        public Employee(int anId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate,
            string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, 
            string aExtension)
            : this(anId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode,
            aCountry, aHomePhone, aExtension, "n/a", "n/a", -1)
        {

        }

        public Employee(int anId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate,
            string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone)
            : this(anId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode,
            aCountry, aHomePhone, "n/a", "n/a", "n/a", -1)
        {

        }

        public Employee(int anId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate,
            string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry)
            : this(anId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode, 
            aCountry, "n/a", "n/a", "n/a", "n/a", -1)
        {

        }

        public Employee(int anId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate,
            string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode)
            : this(anId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode, 
            "n/a", "n/a", "n/a", "n/a", "n/a", -1)
        {

        }

        public Employee(int anId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate,
            string aHireDate, string aAddress, string aCity, string aRegion)
            : this(anId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, "n/a", "n/a",
            "n/a", "n/a", "n/a", "n/a", -1)
        {

        }

        public Employee(int anId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate,
            string aHireDate, string aAddress, string aCity)
            : this(anId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, "n/a", "n/a", "n/a", 
            "n/a", "n/a", "n/a", "n/a", -1)
        {

        }

        public Employee(int anId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate,
            string aHireDate, string aAddress)
            : this(anId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, "n/a", "n/a", "n/a", "n/a", 
            "n/a", "n/a", "n/a", "n/a", -1)
        {

        }

        public Employee(int anId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, 
            string aHireDate)
            : this(anId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, "n/a", "n/a", "n/a", "n/a", "n/a", 
            "n/a", "n/a", "n/a", "n/a", -1)
        {

        }

        public Employee(int anId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate)
            : this(anId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", 
            "n/a", "n/a", "n/a", -1)
        {

        }

        public Employee(int anId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy)
            : this(anId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", 
            "n/a", "n/a", -1)
        {

        }

        public Employee(int anId, string aLastName, string aFirstName, string aTitle)
            : this(anId, aLastName, aFirstName, aTitle, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", 
            "n/a", -1)
        {

        }

        public Employee(int anId, string aLastName, string aFirstName)
            : this(anId, aLastName, aFirstName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", 
            "n/a", -1)
        {

        }

        public Employee(int anId, string aLastName)
            : this(anId, aLastName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", -1)
        {

        }

        public Employee(int anId)
            : this(anId, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", -1)
        {

        }

        public static int GetNumberOfEmployees()
        {
            return Employee.numberOfEmployees;
        }

        public override string ToString()
        {
            string aString = "";
            aString = aString + "Employee ID = " + EmployeeId + "\n";
            aString = aString + "Last Name = " + LastName + "\n";
            aString = aString + "First Name = " + FirstName + "\n";
            aString = aString + "Title = " + Title + "\n";
            aString = aString + "Title Of Courtesy = " + TitleOfCourtesy + "\n";
            aString = aString + "Birth Date = " + BirthDate + "\n";
            aString = aString + "Hire Date = " + HireDate + "\n";
            aString = aString + "Address = " + Address + "\n";
            aString = aString + "City = " + City + "\n";
            aString = aString + "Region = " + Region + "\n";
            aString = aString + "Postal Code = " + PostalCode + "\n";
            aString = aString + "Country = " + Country + "\n";
            aString = aString + "Home Phone = " + HomePhone + "\n";
            aString = aString + "Extension = " + Extension + "\n";
            aString = aString + "Photo = " + Photo + "\n";
            aString = aString + "Notes = " + Notes + "\n";
            aString = aString + "ReportsTo = " + ReportsTo + "\n";
            aString = aString + "Number Of Employees = " + Employee.numberOfEmployees + "\n";

            return aString;
        }
    }
}
