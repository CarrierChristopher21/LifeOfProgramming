using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student
{
    public class ConsoleView
    {

        public void Print(string aString)
        {

            Console.WriteLine(aString);
            Console.ReadLine();

        }


        public void Print(List <Student> aList)
        {

            foreach (Student aStudent in aList)
            {
                Console.WriteLine(aStudent.ToString());
            }

            Console.ReadLine();

        }





    }
}

