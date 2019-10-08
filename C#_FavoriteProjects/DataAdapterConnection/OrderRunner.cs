using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class OrderRunner
    {
        StudentController aStudentController = new StudentController();
        NotValid aNotValid = new NotValid();
        PrintOut aPrint = new PrintOut();

        //  Order                           -       Order             -    6
        public string Order(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            aPrint.PrintList("Press a number 10248 - 11077 to choose a Order \nOR Press 0 to recieve All of the Order's " +
                "on File: ");
            answer = Console.ReadLine();
            bool canConvert_OrderID = int.TryParse(answer, out anId);   // OrderID - Changing value of anId to value of answer
            if(canConvert_OrderID == true)  // Test for if value is a int / number
            {
                answer = OrderConverter(answer, anId, orderBy, order);
            }
            else
                aNotValid.NotValidNumber(answer);
            return answer;
        }

        //  Order Converter                 -       Order             -    6
        public string OrderConverter(string answer, int anId, string orderBy, int order)
        {
            if(anId >= 10248 && anId <= 11077) //  Test For Range for Order Detail File
            {
                aPrint.Print(this.aStudentController.GetOrderOrder(answer));
            }
            else if(anId == 0)
            {
                answer = OrderOrder(orderBy, order);
            }
            else
                aNotValid.NotValidFile(answer);
            return answer;
        }

        //  Order Order                     -       Order             -    6 - 0
        public string OrderOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            aPrint.PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if(canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = OrderOrderConverter(orderBy, order);
            }
            else
                aNotValid.NotValidOrderNumber(orderBy);
            return orderBy;
        }

        //  Order Order Converter           -       Order             -    6 - 0 - 1 || 2
        public string OrderOrderConverter(string orderBy, int order)
        {
            if(order == 1)  //  Ascend
            {
                aPrint.Print(this.aStudentController.GetOrderOrderByAscending(orderBy));
            }
            else if(order == 2) //  Descend
            {
                aPrint.Print(this.aStudentController.GetOrderOrderByDescending(orderBy));
            }
            else
                aNotValid.NotValidOrderFile(orderBy);
            return orderBy;
        }
    }
}