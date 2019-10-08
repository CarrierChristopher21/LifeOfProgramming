using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Connection
{
    public class Student
    {
        /*  Information about Student Class
            This class receives the data and then assigns the data to a the specific variable
            within the class. Also, this class will test if the data is blank or not available.
            It also sets up the .ToString() format for this file for when its called.
        */

        //  Initializing variables
        private string idNumber = "n/a";
        private string firstName = "n/a";
        private string lastName = "n/a";
        private string middleName = "n/a";
        private static int numberOfStudents = 0;
        
        //  Gets / Sets Section
        public string IdNumber
        {
            get
            {
                return this.idNumber;
            }
            // IdNumber is now Read Only
            //            set
            //            {
            //                this.idNumber = value;
            //            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value.Length > 0)
                {
                    this.firstName = value;
                }
                else
                {
                    this.firstName = "n/a";
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
                this.lastName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                this.middleName = value;
            }

        }

        public Student()
        {
            // This is our blank constructor
            // This is where we would put any
            // Special initialization code
            // we don't have any
            Student.numberOfStudents++;
        }

        public Student(string anId, string aFirstName, string aLastName, string aMiddleName)
            : this()
        {
            this.idNumber = anId;
            this.FirstName = aFirstName;
            this.LastName = aLastName;
            this.MiddleName = aMiddleName;

        }

        public Student(string anId, string aFirstName, string aLastName)
            : this(anId, aFirstName, aLastName, "n/a")
        {

        }

        public Student(string anId, string aLastName)
            : this(anId, "n/a", aLastName, "n/a")
        {

        }

        public Student(string anId)
            : this(anId, "n/a", "n/a", "n/a")
        {

        }

        public static int GetNumberOfStudents()
        {
            return Student.numberOfStudents;
        }

        public override string ToString()
        {
            string aString = "";
            aString = aString + "ID Number = " + IdNumber + "\n";
            aString = aString + "First Name = " + FirstName + "\n";
            aString = aString + "Last Name = " + LastName + "\n";
            aString = aString + "Middle Name = " + MiddleName + "\n";
            aString = aString + "Number of Students = " + Student.numberOfStudents + "\n";

            return aString;
        }
    }
}