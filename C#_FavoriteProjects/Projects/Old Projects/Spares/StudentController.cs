using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student
{
    public class StudentController
    {
        public static void Main(string[] args)
        {



            ConsoleView aView = new ConsoleView();

            UtilityXMLFileLoader aFileLoader = new UtilityXMLFileLoader();

            List<Student> aList = new List<Student>();

            aList = aFileLoader.GetStudents();

            aView.Print(aList);


        }
    }
}
