using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class ShipperRunner
    {
        StudentController aStudentController = new StudentController();
        NotValid aNotValid = new NotValid();
        PrintOut aPrint = new PrintOut();

        //  Shipper                         -       Shipper           -   8
        public string Shipper(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            aPrint.PrintList("Press a number 1 - 3 to choose a shipper \nOR Press 0 to recieve All of the Shipper on File: ");
            answer = Console.ReadLine();
            bool canConvert_ShipperID = int.TryParse(answer, out anId);   // Shipper - Changing value of anId to value of answer
            if(canConvert_ShipperID == true)  // Test for if value is a int / number
            {
                answer = ShipperConverter(answer, anId, orderBy, order);
            }
            else
                aNotValid.NotValidNumber(answer);
            return answer;
        }

        //  Shipper Converter               -       Shipper           -   8
        public string ShipperConverter(string answer, int anId, string orderBy, int order)
        {
            if(anId > 0 && anId <= 3) //  Test For Range for Shipper File
            {
                aPrint.Print(this.aStudentController.GetShipperOrder(answer));
            }
            else if(anId == 0)
            {
                answer = ShipperOrder(orderBy, order);
            }
            else
                aNotValid.NotValidFile(answer);
            return answer;
        }

        //  Supplier Order                  -       Shipper           -   8 - 0
        public string ShipperOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            aPrint.PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if(canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = ShipperOrderConverter(orderBy, order);
            }
            else
                aNotValid.NotValidOrderNumber(orderBy);
            return orderBy;
        }

        //  Shipper Order Converter         -       Shipper           -   8 - 0 - 1 || 2
        public string ShipperOrderConverter(string orderBy, int order)
        {
            if(order == 1)  //  Ascend
            {
                aPrint.Print(this.aStudentController.GetShipperOrderByAscending(orderBy));
            }
            else if(order == 2) //  Descend
            {
                aPrint.Print(this.aStudentController.GetShipperOrderByDescending(orderBy));
            }
            else
                aNotValid.NotValidOrderFile(orderBy);
            return orderBy;
        }
    }
}