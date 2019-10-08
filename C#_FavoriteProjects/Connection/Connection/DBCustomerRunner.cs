using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Connection
{
    public class DBCustomerRunner
    {
        /*  Information about DBCustomerRunner Class
            Now it asks for you to pick a name which would give you a single file over a list of file data. You could 
            also press 0 and follow that route which would give you an entire list of the data instead of a single file's 
            worth of data. If you go down the list of files then you also get the option to ascend or descend the 
            list from A-Z or Z-A. 
        */
        DBController aDBController = new DBController();
        DBNotValid aDBNotValid = new DBNotValid();
        DBPrintOut DBPrinter = new DBPrintOut();

        //  Customer                        -       Customer          -    3
        public string Customer(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            DBPrinter.PrintList("Please type the customer ID name that you want to display from the file \nOR Press 0 " +
                "to recieve All of the Customer's on File: ");
            answer = Console.ReadLine();
            bool canConvert_CustomerID = int.TryParse(answer, out anId);    //  Customer - Changing value of anId to value of the answer
            if(canConvert_CustomerID == true)  // Test for if value is a int / number
            {
                answer = CustomerConverter(answer, anId, orderBy, order);
            }
            else if(aDBController.GetCustomerIDs().Contains(answer)) //  Test For Range for Category File
            {
                DBPrinter.PrintCustomer(this.aDBController.GetCustomerOrder(answer));
            }
            else
                aDBNotValid.NotValidNumber(answer);
            return answer;
        }

        //  Customer Converter              -       Customer          -    3
        public string CustomerConverter(string answer, int anId, string orderBy, int order)
        {
            if(anId == 0)
            {
                answer = CustomerOrder(orderBy, order);
            }
            else
                aDBNotValid.NotValidFile(answer);
            return answer;
        }

        //  Customer Order                  -       Customer          -    3 - 0
        public string CustomerOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            DBPrinter.PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if(canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = CustomerOrderConverter(orderBy, order);
            }
            else
                aDBNotValid.NotValidOrderNumber(orderBy);
            return orderBy;
        }

        //  Customer Order Converter        -       Customer          -    3 - 0 - 1 || 2
        public string CustomerOrderConverter(string orderBy, int order)
        {
            if(order == 1)  //  Ascend
            {
                DBPrinter.PrintCustomer(this.aDBController.GetCustomerOrderByAscending(orderBy));
            }
            else if(order == 2) //  Descend
            {
                DBPrinter.PrintCustomer(this.aDBController.GetCustomerOrderByDescending(orderBy));
            }
            else
                aDBNotValid.NotValidOrderFile(orderBy);
            return orderBy;
        }
    }
}