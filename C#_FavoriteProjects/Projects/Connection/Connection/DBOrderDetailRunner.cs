using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class DBOrderDetailRunner
    {
        /*  Information about DBOrderDetailRunner Class
            Now it asks for you to pick a number between two numbers which would give you a single file of that specific number 
            over a list of file data. You could also press 0 and follow that route which would give you an entire list of the data 
            instead of a single file's worth of data. If you go down the list of files then you also get the option to ascend or 
            descend the list from 10248-11077 or 11077-10248. 
        */
        DBController aDBController = new DBController();
        DBNotValid aDBNotValid = new DBNotValid();
        DBPrintOut DBPrinter = new DBPrintOut();

        //  Order Details                   -       Order Details     -    5                    -       BREAK IT DOWN EVEN MORE NOW!
        public string OrderDetails(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            DBPrinter.PrintList("Press a number 10248 - 11077 to choose a Order Detail \nOR Press 0 to recieve All of the "
            + "Order Details on File: ");
            answer = Console.ReadLine();
            bool canConvert_Order_DetailID = int.TryParse(answer, out anId);   // OrderDetail - Changing value of anId to value of answer
            if(canConvert_Order_DetailID == true)  // Test for if value is a int / number
            {
                answer = OrderDetailsConverter(answer, anId, orderBy, order);
            }
            else
                aDBNotValid.NotValidNumber(answer);
            return answer;
        }

        //  Order Details Converter         -       Order Details     -    5
        public string OrderDetailsConverter(string answer, int anId, string orderBy, int order)
        {
            if(anId >= 10248 && anId <= 11077) //  Test For Range for Order Detail File
            {
                DBPrinter.PrintOrderDetail(this.aDBController.GetOrderDetailOrder(answer));
            }
            else if(anId == 0)
            {
                answer = OrderDetailsOrder(orderBy, order);
            }
            else
                aDBNotValid.NotValidFile(answer);
            return answer;
        }

        //  Order Details Order             -       Order Details     -    5 - 0
        public string OrderDetailsOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            DBPrinter.PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if(canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = OrderDetailsOrderConverter(orderBy, order);
            }
            else
                aDBNotValid.NotValidOrderNumber(orderBy);
            return orderBy;
        }

        //  Order Details Order Converter   -       Order Details     -    5 - 0 - 1 || 2
        public string OrderDetailsOrderConverter(string orderBy, int order)
        {
            if(order == 1)  //  Ascend
            {
                DBPrinter.PrintOrderDetail(this.aDBController.GetOrderDetailsOrderByAscending(orderBy));
            }
            else if(order == 2) //  Descend
            {
                DBPrinter.PrintOrderDetail(this.aDBController.GetOrderDetailsOrderByDescending(orderBy));
            }
            else
                aDBNotValid.NotValidOrderFile(orderBy);
            return orderBy;
        }   
    }
}