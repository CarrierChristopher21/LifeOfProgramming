using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind2.Models
{
    
    //This would prevent sub classing
    //public sealed class Person
    public class Person
    {

        private string firstName = "n/a";
        private string lastName = "n/a";

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

    }
}