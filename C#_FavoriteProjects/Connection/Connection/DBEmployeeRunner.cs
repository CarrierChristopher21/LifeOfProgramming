using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class DBEmployeeRunner
    {
        /*  Information about DBEmployeeRunner Class
            Now it asks for you to pick a number between two numbers which would give you a single file over a list of file data. 
            You could also press 0 and follow that route which would give you an entire list of the data instead of a single file's 
            worth of data. If you go down the list of files then you also get the option to ascend or descend the list from 1-9 or 9-1. 
        */
        DBController aDBController = new DBController();
        DBNotValid aDBNotValid = new DBNotValid();
        DBPrintOut DBPrinter = new DBPrintOut();

        //  Employee                        -       Employee          -    4
        public string Employee(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            DBPrinter.PrintList("Press a number 1 - 9 to choose a employee \nOR Press 0 to recieve All of the employee's on File: ");
            answer = Console.ReadLine();
            bool canConvert_EmployeeID = int.TryParse(answer, out anId);   // Employee - Changing value of anId to value of answer
            if(canConvert_EmployeeID == true)  // Test for if value is a int / number
            {
                answer = EmployeeConverter(answer, anId, orderBy, order);
            }
            else
                aDBNotValid.NotValidNumber(answer);
            return answer;
        }

        //  Employee Converter              -       Employee          -    4
        public string EmployeeConverter(string answer, int anId, string orderBy, int order)
        {
            if(anId > 0 && anId <= 9) //  Test For Range for Employee File
            {
                DBPrinter.PrintEmployee(this.aDBController.GetEmployeeOrder(answer));
            }
            else if(anId == 0)
            {
                answer = EmployeeOrder(orderBy, order);
            }
            else
                aDBNotValid.NotValidFile(answer);
            return answer;
        }

        //  Employee Order                  -       Employee          -    4 - 0
        public string EmployeeOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            DBPrinter.PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if(canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = EmployeeOrderConverter(orderBy, order);
            }
            else
                aDBNotValid.NotValidOrderNumber(orderBy);
            return orderBy;
        }

        //  Employee Order Converter        -       Employee          -    4 - 0 - 1 || 2
        public string EmployeeOrderConverter(string orderBy, int order)
        {
            if(order == 1)  //  Ascend
            {
                DBPrinter.PrintEmployee(this.aDBController.GetEmployeeOrderByAscending(orderBy));
            }
            else if(order == 2) //  Descend
            {
                DBPrinter.PrintEmployee(this.aDBController.GetEmployeeOrderByDescending(orderBy));
            }
            else
                aDBNotValid.NotValidOrderFile(orderBy);
            return orderBy;
        }   
    }
}