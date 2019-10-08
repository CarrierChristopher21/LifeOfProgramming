using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind2.Models
{
    public class Student:Person
    {
        private string studentId = "n/a";

        public string StudentId
        {

            get
            {
                return this.studentId;
            }
            set
            {
                this.studentId = value;
            }

        }


    }
}