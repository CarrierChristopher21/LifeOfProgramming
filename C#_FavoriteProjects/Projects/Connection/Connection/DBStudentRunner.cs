using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data;
using System.Data.OleDb;

namespace Connection
{
    public class DBStudentRunner
    {
        /*  Information about DBStudentRunner Class
            Now it asks for you to pick a digit between the two numbers which would give you a single file
            over a list of file data. You could also press 0 and follow that route which would give you an 
            entire list of the data instead of a single file's worth of data. If you go down the list of files
            then you also get the option to ascend or descend the list from 1-104 or 104-1. 
        */
        DBController aDBController = new DBController();
        DBNotValid aNotValid = new DBNotValid();
        DBPrintOut aDBPrinter = new DBPrintOut();

        //  Student                         -       Student           -    1
        public string Student(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            aDBPrinter.PrintList("Press a number 1 - 104 to choose a student \nOR Press 0 to recieve All of the Students on File: ");
            answer = Console.ReadLine();
            bool canConvert_Student = int.TryParse(answer, out anId);   // Student - Changing value of anId to value of answer
            if(canConvert_Student == true)  // Test for if value is a int / number
            {
                answer = StudentConverter(answer, anId, orderBy, order);
            }
            else
                aNotValid.NotValidNumber(answer);
            return answer;
        }

        //  Student Converter               -       Student           -    1
        public string StudentConverter(string answer, int anId, string orderBy, int order)
        {
            if(anId > 0 && anId <= 104) //  Test For Range for Student File
            {
                aDBPrinter.PrintStudent(this.aDBController.GetStudentsOrder(answer));
            }
            else if(anId == 0)
            {
                answer = StudentOrder(orderBy, order);
            }
            else
                aNotValid.NotValidFile(answer);
            return answer;
        }

        //  Student Order                   -       Student           -    1 - 0
        public string StudentOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            aDBPrinter.PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if(canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = StudentOrderConverter(orderBy, order);
            }
            else
                aNotValid.NotValidOrderNumber(orderBy);
            return orderBy;
        }

        //  Student Order Converter         -       Student           -    1 - 0 - 1 || 2
        public string StudentOrderConverter(string orderBy, int order)
        {
            if(order == 1)  //  Ascend
            {
                aDBPrinter.PrintStudent(this.aDBController.GetStudentsOrderByAscending(orderBy));
            }
            else if(order == 2) //  Descend
            {
                aDBPrinter.PrintStudent(this.aDBController.GetStudentsOrderByDescending(orderBy));
            }
            else
                aNotValid.NotValidOrderFile(orderBy);
            return orderBy;
        }
    }
}