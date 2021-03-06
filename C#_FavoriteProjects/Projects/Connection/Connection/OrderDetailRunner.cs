﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class OrderDetailRunner
    {
        StudentController aStudentController = new StudentController();
        NotValid aNotValid = new NotValid();
        PrintOut aPrint = new PrintOut();

        //  Order Details                   -       Order Details     -    5                    -       BREAK IT DOWN EVEN MORE NOW!
        public string OrderDetails(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            aPrint.PrintList("Press a number 10248 - 11077 to choose a Order Detail \nOR Press 0 to recieve All of the "
            + "Order Details on File: ");
            answer = Console.ReadLine();
            bool canConvert_Order_DetailID = int.TryParse(answer, out anId);   // OrderDetail - Changing value of anId to value of answer
            if(canConvert_Order_DetailID == true)  // Test for if value is a int / number
            {
                answer = OrderDetailsConverter(answer, anId, orderBy, order);
            }
            else
                aNotValid.NotValidNumber(answer);
            return answer;
        }

        //  Order Details Converter         -       Order Details     -    5
        public string OrderDetailsConverter(string answer, int anId, string orderBy, int order)
        {
            if(anId >= 10248 && anId <= 11077) //  Test For Range for Order Detail File
            {
                aPrint.Print(this.aStudentController.GetOrderDetailOrder(answer));
            }
            else if(anId == 0)
            {
                answer = OrderDetailsOrder(orderBy, order);
            }
            else
                aNotValid.NotValidFile(answer);
            return answer;
        }

        //  Order Details Order             -       Order Details     -    5 - 0
        public string OrderDetailsOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            aPrint.PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if(canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = OrderDetailsOrderConverter(orderBy, order);
            }
            else
                aNotValid.NotValidOrderNumber(orderBy);
            return orderBy;
        }

        //  Order Details Order Converter   -       Order Details     -    5 - 0 - 1 || 2
        public string OrderDetailsOrderConverter(string orderBy, int order)
        {
            if(order == 1)  //  Ascend
            {
                aPrint.Print(this.aStudentController.GetOrderDetailsOrderByAscending(orderBy));
            }
            else if(order == 2) //  Descend
            {
                aPrint.Print(this.aStudentController.GetOrderDetailsOrderByDescending(orderBy));
            }
            else
                aNotValid.NotValidOrderFile(orderBy);
            return orderBy;
        }   
    }
}