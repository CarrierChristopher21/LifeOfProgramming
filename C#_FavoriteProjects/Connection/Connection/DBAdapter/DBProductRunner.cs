using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class DBProductRunner
    {
        DBController aDBController = new DBController();
        DBNotValid NotValid = new DBNotValid();
        DBPrintOut DBPrinter = new DBPrintOut();

        //  Product                         -       Product           -    7
        public string Product(string answer, int anId, string orderBy, int order, string answerMin, string answerMax, double aMin, double aMax)
        {
            answer = "";
            DBPrinter.PrintList("Press a number 1 - 3 to choose which way you want to display your product \nSinlge / " +
            "All product files = 1 \nDisplay by product's category = 2 \nDisplay by Unit price range = 3: ");
            answer = Console.ReadLine();
            bool canConvert_Products = int.TryParse(answer, out anId);   // Product - Changing value of anId to value of answer
            if(canConvert_Products == true)  // Test for if value is a int / number
            {
                answer = ProductConverter(answer, anId, orderBy, order, answerMin, answerMax, aMin, aMax);
            }   //  End of number test
            else
                NotValid.NotValidNumber(answer);
            return answer;
        }

        //  Product Converter               -       Product           -   7
        public string ProductConverter(string answer, int anId, string orderBy, int order, string answerMin, string answerMax, double aMin, double aMax)
        {
            if(anId > 0 && anId <= 3)
            {
                switch(anId)
                {
                    case 1: //  Display signle Product or all products
                        answer = ProductFile(answer, anId, orderBy, order);
                        break;
                    case 2: //  Display by product's category
                        answer = ProductCategory(anId, answer);
                        break;
                    case 3:     //  DONE
                        answer = ProductRange(answer, answerMin, answerMax, aMin, aMax);
                        break;
                }   //  End of Product Switch
            }   //  End of Product Range file
            else
                NotValid.NotValidFile(answer);
            return answer;
        }

        //  Product                         -       Product           -   7 - 1
        public string ProductFile(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            DBPrinter.PrintList("Press a number 1 - 77 to choose a product \nOR Press 0 to recieve All of the " +
                "Products on File: ");
            answer = Console.ReadLine();
            bool canConvert_ProductsID = int.TryParse(answer, out anId);   // Product ID Sort - Changing value of anId to value of answer
            if(canConvert_ProductsID == true)  // Test for if value is a int / number
            {
                answer = ProductFileConverter(answer, anId, orderBy, order);
            }
            else
                NotValid.NotValidNumber(answer);
            return answer;
        }

        //  Product File Converter          -       Product           -   7 - 1
        public string ProductFileConverter(string answer, int anId, string orderBy, int order)
        {
            if(anId > 0 && anId <= 77) //  Test For Range for Product File
            {
                DBPrinter.PrintProduct(this.aDBController.GetProductOrder(answer));
            }
            else if(anId == 0)
            {
                answer = ProductOrder(orderBy, order);
            }
            else
                NotValid.NotValidFile(answer);
            return answer;
        }

        //  Product Order                   -       Product           -   7 - 1 - 0
        public string ProductOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            DBPrinter.PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if(canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = ProductOrderConverter(orderBy, order);
            }
            else
                NotValid.NotValidOrderNumber(orderBy);
            return orderBy;
        }

        //  Product Order Converter         -       Product           -   7 - 1 - 0 - 1 || 2
        public string ProductOrderConverter(string orderBy, int order)
        {
            if(order == 1)  //  Ascend
            {
                DBPrinter.PrintProduct(this.aDBController.GetProductOrderByAscending(orderBy));
            }
            else if(order == 2) //  Descend
            {
                DBPrinter.PrintProduct(this.aDBController.GetProductOrderByDescending(orderBy));
            }
            else
                NotValid.NotValidOrderFile(orderBy);
            return orderBy;
        }

        //  Product Category                -       Product           -   7 - 2
        public string ProductCategory(int anId, string answer)
        {
            answer = "";
            DBPrinter.PrintList("Press a number 1 - 8 to choose a product's category: ");
            answer = Console.ReadLine();
            bool canConvert_ProductsCategoryID = int.TryParse(answer, out anId);   // Product - Category - Changing value of anId to value of answer
            if(canConvert_ProductsCategoryID == true)  // Test for if value is a int / number
            {
                answer = ProductCategoryConverter(answer, anId);
            }
            else
                NotValid.NotValidNumber(answer);
            return answer;
        }

        //  Product Category Converter      -       Product           -   7 - 2
        public string ProductCategoryConverter(string answer, int anId)
        {
            if(anId > 0 && anId <= 8) //  Test For Range for Product File
            {
                DBPrinter.PrintCategory(this.aDBController.GetProductCategory(answer));
            }
            else
                NotValid.NotValidFile(answer);
            return answer;
        }

        //  Product Range                   -       Product           -   7 - 3
        public string ProductRange(string answer, string answerMin, string answerMax, double aMin, double aMax)
        {
            answer = "";
            answerMin = "";
            answerMax = "";
            DBPrinter.PrintList("Lowest Number that can be entered is 0: \nChoose your Min range: ");
            answerMin = Console.ReadLine();
            DBPrinter.PrintList("There is no limit to the highest number \nChoose your Max range: ");
            answerMax = Console.ReadLine();
            bool canConvert_ProductsRangeMin = double.TryParse(answerMin, out aMin);   // Product - Range - Min - Changing value of anId to value of answer
            bool canConvert_ProductsRangeMax = double.TryParse(answerMax, out aMax);   // Product - Range - Max - Changing value of anId to value of answer
            if(canConvert_ProductsRangeMin == true && canConvert_ProductsRangeMax == true)  // Test for if value is a int / number
            {
                answer = ProductRangeConverter(answerMin, answerMax, aMin, aMax);
                //answerMax = ProductRangeConverter(answerMin, answerMax, aMin, aMax);
            }
            else if(answerMin != "" || answerMax != "") //  Output if value is not a int / number
            {
                DBPrinter.PrintExist("Your entry is not a valid integer / number!!");
            }
            return answerMin + answerMax;
        }

        //  Product Range Converter         -       Product           -   7 - 3 
        public string ProductRangeConverter(string answerMin, string answerMax, double aMin, double aMax)
        {
            if(aMin >= 0 && aMax > aMin) //  Test For Range for Product File
            {
                DBPrinter.PrintProduct(this.aDBController.GetProductRange(answerMin, answerMax));
            }
            else if(aMin < 0) //   Output if File doesn't exist
            {
                DBPrinter.PrintExist("The file does not exist!!");
            }
            else if(aMin > aMax || aMax <= 0)
            {
                DBPrinter.PrintExist("Your maximum entry was below the minimum entry!!");
            }
            return answerMin + answerMax;
        }  
    }
}