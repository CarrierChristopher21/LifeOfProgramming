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
    public class Employee
    {
        //Declaration
        private int employeeId = -1;
        private int reportsTo = -1;
        private string lastName = "n/a";
        private string firstName = "n/a";
        private string title = "n/a";
        private string titleOfCourtesy = "n/a";
        private string birthDate = "n/a";
        private string hireDate = "n/a";
        private string addressCity = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string homePhone = "n/a";
        private string extension = "n/a";
        private string notes = "n/a";

        //Get and Sets
        public int EmployeeId
        {
            get
            {
                return this.employeeId;
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

        }

        public Employee(int anId, int areportsTo, string alastName, string afirstName, string atitle, string atitleOfCourtesy,
            string abirthDate, string ahireDate, string aaddressCity, string aregion, string
            apostalCode, string acountry, string ahomePhone, string aextension, string anotes)
            : this()
        {
            this.employeeId = anId;             // Do Not Capatilize the variable for anID
            this.ReportsTo = areportsTo;        // Capatilize the rest of the this.variable's
            this.LastName = alastName;
            this.FirstName = afirstName;
            this.Title = atitle;
            this.BirthDate = abirthDate;
            this.HireDate = ahireDate;
            this.AddressCity = aaddressCity;
            this.Region = aregion;
            this.PostalCode = apostalCode;
            this.Country = acountry;
            this.HomePhone = ahomePhone;
            this.Extension = aextension;
            this.Notes = anotes;

        }

        public Employee(int anId, int areportsTo, string alastName, string afirstName, string atitle, string atitleOfCourtesy,
            string abirthDate, string ahireDate, string aaddressCity, string aregion, string
            apostalCode, string acountry, string ahomePhone, string aextension)
            : this(anId, areportsTo, alastName, afirstName, atitle, atitleOfCourtesy, abirthDate,
                ahireDate, aaddressCity, aregion, apostalCode, acountry, ahomePhone, aextension,
                "n/a")
        {

        }

        public Employee(int anId, int areportsTo, string alastName, string afirstName, string atitle, string atitleOfCourtesy,
            string abirthDate, string ahireDate, string aaddressCity, string aregion, string
            apostalCode, string acountry, string ahomePhone)
            : this(anId, areportsTo, alastName, afirstName, atitle, atitleOfCourtesy, abirthDate,
                ahireDate, aaddressCity, aregion, apostalCode, acountry, ahomePhone, "n/a",
                "n/a")
        {

        }

        public Employee(int anId, int areportsTo, string alastName, string afirstName, string atitle, string atitleOfCourtesy,
            string abirthDate, string ahireDate, string aaddressCity, string aregion, string
            apostalCode, string acountry)
            : this(anId, areportsTo, alastName, afirstName, atitle, atitleOfCourtesy, abirthDate,
                ahireDate, aaddressCity, aregion, apostalCode, acountry, "n/a", "n/a", "n/a")
        {

        }

        public Employee(int anId, int areportsTo, string alastName, string afirstName, string atitle, string atitleOfCourtesy,
            string abirthDate, string ahireDate, string aaddressCity, string aregion, string
            apostalCode)
            : this(anId, areportsTo, alastName, afirstName, atitle, atitleOfCourtesy, abirthDate,
                ahireDate, aaddressCity, aregion, apostalCode, "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Employee(int anId, int areportsTo, string alastName, string afirstName, string atitle, string atitleOfCourtesy,
            string abirthDate, string ahireDate, string aaddressCity, string aregion)
            : this(anId, areportsTo, alastName, afirstName, atitle, atitleOfCourtesy, abirthDate,
                ahireDate, aaddressCity, aregion, "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Employee(int anId, int areportsTo, string alastName, string afirstName, string atitle, string atitleOfCourtesy,
            string abirthDate, string ahireDate, string aaddressCity)
            : this(anId, areportsTo, alastName, afirstName, atitle, atitleOfCourtesy, abirthDate,
                ahireDate, aaddressCity, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Employee(int anId, int areportsTo, string alastName, string afirstName, string atitle, string atitleOfCourtesy,
            string abirthDate, string ahireDate)
            : this(anId, areportsTo, alastName, afirstName, atitle, atitleOfCourtesy, abirthDate,
                ahireDate, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Employee(int anId, int areportsTo, string alastName, string afirstName, string atitle, string atitleOfCourtesy,
            string abirthDate)
            : this(anId, areportsTo, alastName, afirstName, atitle, atitleOfCourtesy, abirthDate,
                "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Employee(int anId, int areportsTo, string alastName, string afirstName, string atitle,
            string atitleOfCourtesy)
            : this(anId, areportsTo, alastName, afirstName, atitle, atitleOfCourtesy, "n/a",
                "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Employee(int anId, int areportsTo, string alastName, string afirstName, string
            atitle)
            : this(anId, areportsTo, alastName, afirstName, atitle, "n/a", "n/a",
                "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Employee(int anId, int areportsTo, string alastName, string afirstName)
            : this(anId, areportsTo, alastName, afirstName, "n/a", "n/a", "n/a",
                "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Employee(int anId, int areportsTo, string alastName)
            : this(anId, areportsTo, alastName, "n/a", "n/a", "n/a", "n/a",
                "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Employee(int anId, int areportsTo)
            : this(anId, areportsTo, "n/a", "n/a", "n/a", "n/a", "n/a",
                "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Employee(int anId)
            : this(anId, -1, "n/a", "n/a", "n/a", "n/a", "n/a",
                "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

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
            aString = aString + "Address City = " + AddressCity + "\n";
            aString = aString + "Region = " + Region + "\n";
            aString = aString + "Postal Code = " + PostalCode + "\n";
            aString = aString + "Country = " + Country + "\n";
            aString = aString + "Home Phone = " + HomePhone + "\n";
            aString = aString + "Extension = " + Extension + "\n";
            aString = aString + "Notes = " + Notes + "\n";
            aString = aString + "ReportsTo = " + ReportsTo + "\n";

            return aString;
        }
    }
}
