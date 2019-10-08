using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class DBStartupInput
    {
        /*  Information about DBStartupInput
            This class prints and displays 9 choices each one leads to a different file but
            this class only displays the choices and reads what you reply to it.
        */
        //  Print Outputs
        DBPrintOut DBPrinter = new DBPrintOut();

        public string GetStartUpInput(string answer)
        {
            answer = "";
            DBPrinter.Print("Students = 1, Category = 2, Customers = 3, Employee = 4, Order Details = 5: \n" +
                "Order = 6, Product = 7, Shipper = 8, Supplier = 9: ");
            DBPrinter.PrintList("Press a number 1 - 9: ");
            answer = Console.ReadLine();     //  Collecting input from Console
            return answer;
        }
    }
}