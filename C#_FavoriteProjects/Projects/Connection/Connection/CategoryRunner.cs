using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class CategoryRunner
    {
        StudentController aStudentController = new StudentController();
        PrintOut aPrinter = new PrintOut();
        NotValid aNotValid = new NotValid();

        //  Category                        -       Category          -    2
        public string Category(string answer, int anId, string orderBy, int order)
        {
            //answer = "";
            aPrinter.PrintList("Press a number 1 - 8 to choose a Category \nOR Press 0 to recieve All of the Categories on File: ");
            answer = Console.ReadLine();
            bool canConvert_CategoryId = int.TryParse(answer, out anId);   // Changing value of anId to value of answer
            if(canConvert_CategoryId == true)  // Test for if value is a int / number
            {
                answer = CategoryConverter(answer, anId, orderBy, order);
            }
            else
                aNotValid.NotValidNumber(answer);
            return answer;
        }

        //  Category Converter              -       Category          -    2
        public string CategoryConverter(string answer, int anId, string orderBy, int order)
        {
            if(anId > 0 && anId <= 8) //  Test For Range for Category File
            {
                aPrinter.Print(this.aStudentController.GetCategoryOrder(answer));
            }
            else if(anId == 0)
            {
                answer = CategoryOrder(orderBy, order);
            }
            else
                aNotValid.NotValidFile(answer);
            return answer;
        }

        //  Category Order                  -       Category          -    2 - 0
        public string CategoryOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            aPrinter.PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if(canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = CategoryOrderConverter(orderBy, order);
            }
            else
                aNotValid.NotValidOrderNumber(orderBy);
            return orderBy;
        }

        //  Category Order Converter        -       Category          -    2 - 0 - 1 || 2
        public string CategoryOrderConverter(string orderBy, int order)
        {
            if(order == 1)  //  Ascend
            {
                aPrinter.Print(this.aStudentController.GetCategoryOrderByAscending(orderBy));
            }
            else if(order == 2) //  Descend
            {
                aPrinter.Print(this.aStudentController.GetCategoryOrderByDescending(orderBy));
            }
            else
                aNotValid.NotValidOrderFile(orderBy);
            return orderBy;
        }
    }
}