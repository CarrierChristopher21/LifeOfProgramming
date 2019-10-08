using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class DBShipperRunner
    {
        /*  Information about DBShipperRunner Class
            Now it asks for you to pick a number between two numbers which would give you a file of that specific number 
            over a list of file data. You could also press 0 and follow that route which would give you an entire list of the data 
            instead of a single file's worth of data. If you go down the list of files then you also get the option to ascend or 
            descend the list from 1-3 or 3-1. 
        */
        DBController aDBController = new DBController();
        DBNotValid aDBNotValid = new DBNotValid();
        DBPrintOut DBPrinter = new DBPrintOut();

        //  Shipper                         -       Shipper           -   8
        public string Shipper(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            DBPrinter.PrintList("Press a number 1 - 3 to choose a shipper \nOR Press 0 to recieve All of the Shipper on File: ");
            answer = Console.ReadLine();
            bool canConvert_ShipperID = int.TryParse(answer, out anId);   // Shipper - Changing value of anId to value of answer
            if(canConvert_ShipperID == true)  // Test for if value is a int / number
            {
                answer = ShipperConverter(answer, anId, orderBy, order);
            }
            else
                aDBNotValid.NotValidNumber(answer);
            return answer;
        }

        //  Shipper Converter               -       Shipper           -   8
        public string ShipperConverter(string answer, int anId, string orderBy, int order)
        {
            if(anId > 0 && anId <= 3) //  Test For Range for Shipper File
            {
                DBPrinter.PrintShipper(this.aDBController.GetShipperOrder(answer));
            }
            else if(anId == 0)
            {
                answer = ShipperOrder(orderBy, order);
            }
            else
                aDBNotValid.NotValidFile(answer);
            return answer;
        }

        //  Supplier Order                  -       Shipper           -   8 - 0
        public string ShipperOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            DBPrinter.PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if(canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = ShipperOrderConverter(orderBy, order);
            }
            else
                aDBNotValid.NotValidOrderNumber(orderBy);
            return orderBy;
        }

        //  Shipper Order Converter         -       Shipper           -   8 - 0 - 1 || 2
        public string ShipperOrderConverter(string orderBy, int order)
        {
            if(order == 1)  //  Ascend
            {
                DBPrinter.PrintShipper(this.aDBController.GetShipperOrderByAscending(orderBy));
            }
            else if(order == 2) //  Descend
            {
                DBPrinter.PrintShipper(this.aDBController.GetShipperOrderByDescending(orderBy));
            }
            else
                aDBNotValid.NotValidOrderFile(orderBy);
            return orderBy;
        }
    }
}