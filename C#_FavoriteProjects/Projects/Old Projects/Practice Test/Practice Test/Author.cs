using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Test
{
    public class Author
    {
        private string firstName;
        private string lastName;
        private string eMail;
        private string gender;
        private static int numberOfAuthors = 0;
        private static Author anInstance = null;

        public static Author GetanInstance
        {
            get
            {
                if (Author.anInstance == null)
                {
                    Author.anInstance = new Author();
                }

                return Author.anInstance;
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
                this.firstName = value;
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

        public string EMail
        {
            get
            {
                return this.eMail;
            }
            set
            {
                this.eMail = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }

        private Author()
        {
            Author.numberOfAuthors++;
        }

        private Author(string aFirstName, string aLastName, string aEMail, string aGender)
            : this()
        {
            this.FirstName = aFirstName;
            this.LastName = aLastName;
            this.EMail = aEMail;
            this.Gender = aGender;
        }

        private Author(string aFirstName, string aLastName, string aEMail)
            : this(aFirstName, aLastName, aEMail, "")
        {

        }

        private Author(string aFirstName, string aLastName)
            : this(aFirstName, aLastName, "", "")
        {

        }

        private Author(string aFirstName)
            : this(aFirstName, "", "", "")
        {

        }

        public static int GetNumberOfAuthors()
        {
            return Author.numberOfAuthors;
        }

        public override string ToString()
        {
            string aString = "";
            aString = aString + "First Name = " + FirstName + "\n";
            aString = aString + "Last Name = " + LastName + "\n";
            aString = aString + "Email = " + EMail + "\n";
            aString = aString + "Gender = " + Gender + "\n";
            aString = aString + "Number of Author's = " + Author.numberOfAuthors + "\n";

            return aString;
        }

    }
}
