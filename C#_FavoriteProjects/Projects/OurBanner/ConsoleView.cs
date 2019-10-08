/*  BREAK DOWN Order Details EVEN MORE NOW!   */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OurBanner
{
    //  ConsoleView Class
    public class ConsoleView
    {
        int anId = -1;
        int order = -1;
        int anSwitchId = -1;
        double aMin = 0;
        double aMax = 0;
        string answer = "";
        string orderBy = "";
        string answerMin = "";
        string answerMax = "";
        private StudentController aStudentController = null;
        
        //  Basic Print Output Call
        public void Print(string aString)
        {
            Console.Write(aString);
        }

        //  Print List Output
        public void PrintList(string aString)
        {
            Console.WriteLine();
            Console.Write(aString);
        }

        //  Print Data Not Available / Wrong Information Entered
        public void PrintExist(string aString)
        {
            Console.WriteLine();
            Console.Write(aString);
            Console.WriteLine("\n");
        }

        //  Student List
        public void Print(List<Student> aList)
        {
            Console.WriteLine();
            foreach(Student aStudent in aList)
            {
                Console.WriteLine(aStudent.ToString());
            }
        }

        //  Category List
        public void Print(List<Category> aList)
        {
            Console.WriteLine();
            foreach(Category aCategory in aList)
            {
                Console.WriteLine(aCategory.ToString());
            }
        }

        //  Customer List
        public void Print(List<Customer> aList)
        {
            Console.WriteLine();
            foreach(Customer aCustomer in aList)
            {
               Console.WriteLine(aCustomer.ToString());
            }
        }

        //  Employee List
        public void Print(List<Employee> aList)
        {
            Console.WriteLine();
            foreach(Employee aEmployee in aList)
            {
                Console.WriteLine(aEmployee.ToString());
            }
        }

        //  Order_Detail List                                -       BREAK IT DOWN EVEN MORE NOW!
        public void Print(List<Order_Detail> aList)
        {
            Console.WriteLine();
            foreach(Order_Detail aOrder_Details in aList)
            {
                Console.WriteLine(aOrder_Details.ToString());
            }
        }

        //  Order List
        public void Print(List<Order> aList)
        {
            Console.WriteLine();
            foreach(Order aOrder in aList)
            {
                Console.WriteLine(aOrder.ToString());
            }
        }

        //  Product List
        public void Print(List<Product> aList)
        {
            Console.WriteLine();
            foreach(Product aProduct in aList)
            {
                Console.WriteLine(aProduct.ToString());
            }
        }

        //  Shipper
        public void Print(List<Shipper> aList)
        {
            Console.WriteLine();
            foreach(Shipper aShipper in aList)
            {
                Console.WriteLine(aShipper.ToString());
            }
        }

        //  Supplier List
        public void Print(List<Supplier> aList)
        {
            Console.WriteLine();
            foreach(Supplier aSupplier in aList)
            {
                Console.WriteLine(aSupplier.ToString());
            }
        }

        //  ConsoleView
        private ConsoleView()
        {

        }

        //  ConsoleView aStudentController
        public ConsoleView(StudentController aStudentController)
            : this()
        {
            this.aStudentController = aStudentController;
            this.PrintMenu();
        }

        /*  Program Method's In subsequent Order! I believe lol!    */
        //  Program                         -       Main Program Itself     -   Runner
        public void PrintMenu()
        {
            //  Unicode Output Encoding
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //  Program Input
            answer = GetStartUpInput(answer);     //  Collecting input from Console

            //  Program Loop    
            answer = ProgramLoop(answer, anId, orderBy, order, answerMin, answerMax, aMin, aMax);
        }   

        //  Get StartUp-Input               -       1st Part
        public string GetStartUpInput(string answer)
        {
            answer = "";
            this.Print("Students = 1, Category = 2, Customers = 3, Employee = 4, Order Details = 5: \n" +
                "Order = 6, Product = 7, Shipper = 8, Supplier = 9: ");
            this.PrintList("Press a number 1 - 9: ");
            answer = Console.ReadLine();     //  Collecting input from Console
            return answer;
        }

        //  Program Loop                    -       2nd Part
        public string ProgramLoop(string answer, int anId, string orderBy, int order, string answerMin, string answerMax, double aMin, double aMax)
        {
            while (answer != "") // Beginning of loop
            {
                //  Program
                answer = ProgramDisplay(answer, anId, orderBy, order, answerMin, answerMax, aMin, aMax);

                //  Program Runner for whether to Continue or Not!  
                if(answer != "")
                {
                    answer = ContinueQuestion(answer);
                }

                if(answer != "")
                {
                    answer = WhileFalse(answer);
                }

                //  Continuation Question Response
                if(answer == "Y" || answer == "y")
                {
                    Console.Clear();
                    answer = GetStartUpInput(answer);     //  Collecting input from Console
                }
                else if(answer == "n" || answer == "N" || answer == "")
                {
                    break;
                }
            }   //  End of While statement
            return answer;
        }

        //  Program Display                 -       3rd Part
        public string ProgramDisplay(string answer, int anId, string orderBy, int order, string answerMin, string answerMax, double aMin, double aMax)
        {
            bool canConvert_SwitchId = int.TryParse(answer, out anSwitchId);   // Switch - Changing value of anId to value of answer
            if(canConvert_SwitchId == true)
            {
                answer = ProgramConverter(answer, anId, orderBy, order, answerMin, answerMax, aMin, aMax);
            }
            else
                NotValidNumber(answer);
            return answer;
        }

        //  Program Converter               -       4th Part    
        public string ProgramConverter(string answer, int anId, string orderBy, int order, string answerMin, string answerMax, double aMin, double aMax)
        {
            if(anSwitchId > 0 && anSwitchId <= 9 && answer != "") //  Test For Range for Student File
            {
                switch(anSwitchId)  //  Switch Begginning
                {
                    case 1:
                        answer = Student(answer, anId, orderBy, order);
                        break;
                    case 2: // Categories
                        answer = Category(answer, anId, orderBy, order);
                        break;
                    case 3: // Customer
                        answer = Customer(answer, anId, orderBy, order);
                        break;  //  End of 3
                    case 4: // Employees   
                        answer = Employee(answer, anId, orderBy, order);
                        break;  //  End of 4
                    case 5://2156   Order_Detail
                        answer = OrderDetails(answer, anId, orderBy, order);
                        break;  //  End of 5
                    case 6://830    //  Order - 6
                        answer = Order(answer, anId, orderBy, order);
                        break;  //  End of 6
                    case 7: // Products
                        answer = Product(answer, anId, orderBy, order, answerMin, answerMax, aMin, aMax);
                        break;
                    case 8: // Shipper
                        answer = Shipper(answer, anId, orderBy, order);
                        break;
                    case 9: // Supplier
                        answer = Supplier(answer, anId, orderBy, order);
                        break;
                }   //  End of switch
            }   //  Switch Statment Range
            else 
                NotValidFile(answer);
            return answer;
        }

        //  Continue Question               -       5th Part
        public string ContinueQuestion(string answer)
        {
            answer = "";
            Print("Do you want to continue? Y = Yes, N = No: ");
            answer = Console.ReadLine();
            return answer;
        }

        //  While False                     -       6th Part
        public string WhileFalse(string answer)
        {
            while(answer != "y" || answer != "Y" || answer != "n" || answer != "N" || answer != "")
            {
                if(answer == "Y" || answer == "y" || answer == "n" || answer == "N" || answer == "")
                {
                    break;
                }
                else
                {
                    answer = WhileFalseEnd(answer);
                }
            }
            return answer;
        }

        //  While False End                 -       7th Part
        public string WhileFalseEnd(string answer)
        {
            //answer = "";
            PrintExist("Your response is not valid answer!!");
            Print("Do you want to continue? Y = Yes, N = No: ");
            answer = Console.ReadLine();
            return answer;
        }
        
        //  Student                         -       Student           -    1
        public string Student(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            PrintList("Press a number 1 - 104 to choose a student \nOR Press 0 to recieve All of the Students on File: ");
            answer = Console.ReadLine();
            bool canConvert_Student = int.TryParse(answer, out anId);   // Student - Changing value of anId to value of answer
            if(canConvert_Student == true)  // Test for if value is a int / number
            {
                answer = StudentConverter(answer, anId, orderBy, order);
            }
            else 
                NotValidNumber(answer);
            return answer;
        }

        //  Student Converter               -       Student           -    1
        public string StudentConverter(string answer, int anId, string orderBy, int order)
        {
            if (anId > 0 && anId <= 104) //  Test For Range for Student File
            {
                this.Print(this.aStudentController.GetStudentsOrder(answer));
            }
            else if (anId == 0)
            {
                answer = StudentOrder(orderBy, order);
            }
            else
                NotValidFile(answer);
            return answer;
        }
        
        //  Student Order                   -       Student           -    1 - 0
        public string StudentOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if (canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = StudentOrderConverter(orderBy, order);
                
                //  Converter Call - In Progress, Not In Use!
                /*Converter aConverter = Print;
                 * orderBy = ConverterList(orderBy, order, aConverter);
                 */               
            }
            else
                NotValidOrderNumber(orderBy);
            return orderBy;
        }

        //  Student Order Converter         -       Student           -    1 - 0 - 1 || 2
        public string StudentOrderConverter(string orderBy, int order)
        {
            if (order == 1)  //  Ascend
            {
                this.Print(this.aStudentController.GetStudentsOrderByAscending(orderBy));
            }
            else if (order == 2) //  Descend
            {
                this.Print(this.aStudentController.GetStudentsOrderByDescending(orderBy));
            }
            else
                NotValidOrderFile(orderBy);
            return orderBy;
        }

        //  Category                        -       Category          -    2
        public string Category(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            PrintList("Press a number 1 - 8 to choose a Category \nOR Press 0 to recieve All of the Categories on File: ");
            answer = Console.ReadLine();
            bool canConvert_CategoryId = int.TryParse(answer, out anId);   // Changing value of anId to value of answer
            if (canConvert_CategoryId == true)  // Test for if value is a int / number
            {
                answer = CategoryConverter(answer, anId, orderBy, order);
            }
            else 
                NotValidNumber(answer);
            return answer;
        }

        //  Category Converter              -       Category          -    2
        public string CategoryConverter(string answer, int anId, string orderBy, int order)
        {
            if (anId > 0 && anId <= 8) //  Test For Range for Category File
            {
                this.Print(this.aStudentController.GetCategoryOrder(answer));
            }
            else if (anId == 0)
            {
                answer = CategoryOrder(orderBy, order);
            }
            else
                NotValidFile(answer);
            return answer;
        }

        //  Category Order                  -       Category          -    2 - 0
        public string CategoryOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if (canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = CategoryOrderConverter(orderBy, order);
            }
            else
                NotValidOrderNumber(orderBy);
            return orderBy;
        }

        //  Category Order Converter        -       Category          -    2 - 0 - 1 || 2
        public string CategoryOrderConverter(string orderBy, int order)
        {
            if (order == 1)  //  Ascend
            {
                this.Print(this.aStudentController.GetCategoryOrderByAscending(orderBy));
            }
            else if (order == 2) //  Descend
            {
                this.Print(this.aStudentController.GetCategoryOrderByDescending(orderBy));
            }
            else
                NotValidOrderFile(orderBy);
            return orderBy;
        }

        //  Customer                        -       Customer          -    3
        public string Customer(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            PrintList("Please type the customer name that you want to display from the file \nOR Press 0 to " +
                "recieve All of the Customer's on File: ");
            answer = Console.ReadLine();
            bool canConvert_CustomerID = int.TryParse(answer, out anId);    //  Customer - Changing value of anId to value of the answer
            if (canConvert_CustomerID == true)  // Test for if value is a int / number
            {
                answer = CustomerConverter(answer, anId, orderBy, order);
            }
            else if (aStudentController.GetCustomerIDs().Contains(answer)) //  Test For Range for Category File
            {
                Print(this.aStudentController.GetCustomerOrder(answer));
            }
            else
                NotValidNumber(answer);
            return answer;
        }
        
        //  Customer Converter              -       Customer          -    3
        public string CustomerConverter(string answer, int anId, string orderBy, int order)
        {
            if (anId == 0)
            {
                answer = CustomerOrder(orderBy, order);
            }
            else
                NotValidFile(answer);
            return answer;
        }

        //  Customer Order                  -       Customer          -    3 - 0
        public string CustomerOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if (canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = CustomerOrderConverter(orderBy, order);
            }
            else 
                NotValidOrderNumber(orderBy);
            return orderBy;
        }

        //  Customer Order Converter        -       Customer          -    3 - 0 - 1 || 2
        public string CustomerOrderConverter(string orderBy, int order)
        {
            if (order == 1)  //  Ascend
            {
                this.Print(this.aStudentController.GetCustomerOrderByAscending(orderBy));
            }
            else if (order == 2) //  Descend
            {
                this.Print(this.aStudentController.GetCustomerOrderByDescending(orderBy));
            }
            else 
                NotValidOrderFile(orderBy);
            return orderBy;
        }

        //  Employee                        -       Employee          -    4
        public string Employee(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            PrintList("Press a number 1 - 9 to choose a employee \nOR Press 0 to recieve All of the employee's on File: ");
            answer = Console.ReadLine();
            bool canConvert_EmployeeID = int.TryParse(answer, out anId);   // Employee - Changing value of anId to value of answer
            if (canConvert_EmployeeID == true)  // Test for if value is a int / number
            {
                answer = EmployeeConverter(answer, anId, orderBy, order);
            }
            else 
                NotValidNumber(answer);
            return answer;
        }

        //  Employee Converter              -       Employee          -    4
        public string EmployeeConverter(string answer, int anId, string orderBy, int order)
        {
            if (anId > 0 && anId <= 9) //  Test For Range for Employee File
            {
                this.Print(this.aStudentController.GetEmployeeOrder(answer));
            }
            else if (anId == 0)
            {
                answer = EmployeeOrder(orderBy, order);
            }
            else 
                NotValidFile(answer);
            return answer;
        }

        //  Employee Order                  -       Employee          -    4 - 0
        public string EmployeeOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if (canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = EmployeeOrderConverter(orderBy, order);
            }
            else 
                NotValidOrderNumber(orderBy);
            return orderBy;
        }

        //  Employee Order Converter        -       Employee          -    4 - 0 - 1 || 2
        public string EmployeeOrderConverter(string orderBy, int order)
        {
            if (order == 1)  //  Ascend
            {
                this.Print(this.aStudentController.GetEmployeeOrderByAscending(orderBy));
            }
            else if (order == 2) //  Descend
            {
                this.Print(this.aStudentController.GetEmployeeOrderByDescending(orderBy));
            }
            else 
                NotValidOrderFile(orderBy);
            return orderBy;
        }   

        //  Order Details                   -       Order Details     -    5                    -       BREAK IT DOWN EVEN MORE NOW!
        public string OrderDetails(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            PrintList("Press a number 10248 - 11077 to choose a Order Detail \nOR Press 0 to recieve All of the "
            + "Order Details on File: ");
            answer = Console.ReadLine();
            bool canConvert_Order_DetailID = int.TryParse(answer, out anId);   // OrderDetail - Changing value of anId to value of answer
            if (canConvert_Order_DetailID == true)  // Test for if value is a int / number
            {
                answer = OrderDetailsConverter(answer, anId, orderBy, order);
            }
            else 
                NotValidNumber(answer);
            return answer;
        }   

        //  Order Details Converter         -       Order Details     -    5
        public string OrderDetailsConverter(string answer, int anId, string orderBy, int order)
        {
            if (anId >= 10248 && anId <= 11077) //  Test For Range for Order Detail File
            {
                Print(this.aStudentController.GetOrderDetailOrder(answer));
            }
            else if (anId == 0)
            {
                answer = OrderDetailsOrder(orderBy, order);
            }
            else 
                NotValidFile(answer);
            return answer;
        }   

        //  Order Details Order             -       Order Details     -    5 - 0
        public string OrderDetailsOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if (canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = OrderDetailsOrderConverter(orderBy, order);
            }
            else 
                NotValidOrderNumber(orderBy);
            return orderBy;
        }   

        //  Order Details Order Converter   -       Order Details     -    5 - 0 - 1 || 2
        public string OrderDetailsOrderConverter(string orderBy, int order)
        {
            if (order == 1)  //  Ascend
            {
                this.Print(this.aStudentController.GetOrderDetailsOrderByAscending(orderBy));
            }
            else if (order == 2) //  Descend
            {
                this.Print(this.aStudentController.GetOrderDetailsOrderByDescending(orderBy));
            }
            else 
                NotValidOrderFile(orderBy);
            return orderBy;
        }   

        //  Order                           -       Order             -    6
        public string Order(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            PrintList("Press a number 10248 - 11077 to choose a Order \nOR Press 0 to recieve All of the Order's " +
                "on File: ");
            answer = Console.ReadLine();
            bool canConvert_OrderID = int.TryParse(answer, out anId);   // OrderID - Changing value of anId to value of answer
            if (canConvert_OrderID == true)  // Test for if value is a int / number
            {
                answer = OrderConverter(answer, anId, orderBy, order);
            }
            else 
                NotValidNumber(answer);
            return answer;
        }   

        //  Order Converter                 -       Order             -    6
        public string OrderConverter(string answer, int anId, string orderBy, int order)
        {
            if (anId >= 10248 && anId <= 11077) //  Test For Range for Order Detail File
            {
                Print(this.aStudentController.GetOrderOrder(answer));
            }
            else if (anId == 0)
            {
                answer = OrderOrder(orderBy, order);
            }
            else 
                NotValidFile(answer);
            return answer;
        }   

        //  Order Order                     -       Order             -    6 - 0
        public string OrderOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if (canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = OrderOrderConverter(orderBy, order);
            }
            else 
                NotValidOrderNumber(orderBy);
            return orderBy;
        }   

        //  Order Order Converter           -       Order             -    6 - 0 - 1 || 2
        public string OrderOrderConverter(string orderBy, int order)
        {
            if (order == 1)  //  Ascend
            {
                this.Print(this.aStudentController.GetOrderOrderByAscending(orderBy));
            }
            else if (order == 2) //  Descend
            {
                this.Print(this.aStudentController.GetOrderOrderByDescending(orderBy));
            }
            else 
                NotValidOrderFile(orderBy);
            return orderBy;
        }   

        //  Product                         -       Product           -    7
        public string Product(string answer, int anId, string orderBy, int order, string answerMin, string answerMax, double aMin, double aMax)
        {
            answer = "";
            PrintList("Press a number 1 - 3 to choose which way you want to display your product \nSinlge / " +
            "All product files = 1 \nDisplay by product's category = 2 \nDisplay by Unit price range = 3: ");
            answer = Console.ReadLine();
            bool canConvert_Products = int.TryParse(answer, out anId);   // Product - Changing value of anId to value of answer
            if (canConvert_Products == true)  // Test for if value is a int / number
            {
                answer = ProductConverter(answer, anId, orderBy, order, answerMin, answerMax, aMin, aMax);
            }   //  End of number test
            else 
                NotValidNumber(answer);
            return answer;
        }   

        //  Product Converter               -       Product           -   7
        public string ProductConverter(string answer, int anId, string orderBy, int order, string answerMin, string answerMax, double aMin, double aMax)
        {
            if (anId > 0 && anId <= 3)
            {
                switch (anId)
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
                NotValidFile(answer);
            return answer;
        }   

        //  Product                         -       Product           -   7 - 1
        public string ProductFile(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            PrintList("Press a number 1 - 77 to choose a product \nOR Press 0 to recieve All of the " +
                "Products on File: ");
            answer = Console.ReadLine();
            bool canConvert_ProductsID = int.TryParse(answer, out anId);   // Product ID Sort - Changing value of anId to value of answer
            if (canConvert_ProductsID == true)  // Test for if value is a int / number
            {
                answer = ProductFileConverter(answer, anId, orderBy, order);
            }
            else 
                NotValidNumber(answer);
            return answer;
        }   
        
        //  Product File Converter          -       Product           -   7 - 1
        public string ProductFileConverter(string answer, int anId, string orderBy, int order)
        {
            if (anId > 0 && anId <= 77) //  Test For Range for Product File
            {
                Print(this.aStudentController.GetProductOrder(answer));
            }
            else if (anId == 0)
            {
                answer = ProductOrder(orderBy, order);
            }
            else 
                NotValidFile(answer);
            return answer;
        }   

        //  Product Order                   -       Product           -   7 - 1 - 0
        public string ProductOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if (canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = ProductOrderConverter(orderBy, order);
            }
            else 
                NotValidOrderNumber(orderBy);
            return orderBy;
        }   //  End of Product Order

        //  Product Order Converter         -       Product           -   7 - 1 - 0 - 1 || 2
        public string ProductOrderConverter(string orderBy, int order)
        {
            if (order == 1)  //  Ascend
            {
                this.Print(this.aStudentController.GetProductOrderByAscending(orderBy));
            }
            else if (order == 2) //  Descend
            {
                this.Print(this.aStudentController.GetProductOrderByDescending(orderBy));
            }
            else 
                NotValidOrderFile(orderBy);
            return orderBy;
        }   

        //  Product Category                -       Product           -   7 - 2
        public string ProductCategory(int anId, string answer)
        {
            answer = "";
            PrintList("Press a number 1 - 8 to choose a product's category: ");
            answer = Console.ReadLine();
            bool canConvert_ProductsCategoryID = int.TryParse(answer, out anId);   // Product - Category - Changing value of anId to value of answer
            if (canConvert_ProductsCategoryID == true)  // Test for if value is a int / number
            {
                answer = ProductCategoryConverter(answer, anId);
            }
            else 
                NotValidNumber(answer);
            return answer;
        }   

        //  Product Category Converter      -       Product           -   7 - 2
        public string ProductCategoryConverter(string answer, int anId)
        {
            if (anId > 0 && anId <= 8) //  Test For Range for Product File
            {
                Print(this.aStudentController.GetProductCategory(answer));
            }
            else 
                NotValidFile(answer);
            return answer;
        }   

        //  Product Range                   -       Product           -   7 - 3
        public string ProductRange(string answer, string answerMin, string answerMax, double aMin, double aMax)
        {
            answer = "";
            answerMin = "";
            answerMax = "";
            PrintList("Lowest Number that can be entered is 0: \nChoose your Min range: ");
            answerMin = Console.ReadLine();
            PrintList("There is no limit to the highest number \nChoose your Max range: ");
            answerMax = Console.ReadLine();
            bool canConvert_ProductsRangeMin = double.TryParse(answerMin, out aMin);   // Product - Range - Min - Changing value of anId to value of answer
            bool canConvert_ProductsRangeMax = double.TryParse(answerMax, out aMax);   // Product - Range - Max - Changing value of anId to value of answer
            if (canConvert_ProductsRangeMin == true && canConvert_ProductsRangeMax == true)  // Test for if value is a int / number
            {
                answer = ProductRangeConverter(answerMin, answerMax, aMin, aMax);
                //answerMax = ProductRangeConverter(answerMin, answerMax, aMin, aMax);
            }
            else if(answerMin != "" || answerMax != "") //  Output if value is not a int / number
            {
                this.PrintExist("Your entry is not a valid integer / number!!");
            }
            return answerMin + answerMax;
        }

        //  Product Range Converter         -       Product           -   7 - 3 
        public string ProductRangeConverter(string answerMin, string answerMax, double aMin, double aMax)
        {
            if(aMin >= 0 && aMax > aMin) //  Test For Range for Product File
            {
                this.Print(this.aStudentController.GetProductRange(answerMin, answerMax));
            }
            else if(aMin < 0) //   Output if File doesn't exist
            {
                this.PrintExist("The file does not exist!!");
            }
            else if(aMin > aMax || aMax <= 0)
            {
                this.PrintExist("Your maximum entry was below the minimum entry!!");
            }
            return answerMin + answerMax;
        }   

        //  Shipper                         -       Shipper           -   8
        public string Shipper(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            PrintList("Press a number 1 - 3 to choose a shipper \nOR Press 0 to recieve All of the Shipper on File: ");
            answer = Console.ReadLine();
            bool canConvert_ShipperID = int.TryParse(answer, out anId);   // Shipper - Changing value of anId to value of answer
            if (canConvert_ShipperID == true)  // Test for if value is a int / number
            {
                answer = ShipperConverter(answer, anId, orderBy, order);
            }
            else 
                NotValidNumber(answer);
            return answer;
        }   

        //  Shipper Converter               -       Shipper           -   8
        public string ShipperConverter(string answer, int anId, string orderBy, int order)
        {
            if (anId > 0 && anId <= 3) //  Test For Range for Shipper File
            {
                this.Print(this.aStudentController.GetShipperOrder(answer));
            }
            else if (anId == 0)
            {
                answer = ShipperOrder(orderBy, order);
            }
            else 
                NotValidFile(answer);
            return answer;
        }   

        //  Supplier Order                  -       Shipper           -   8 - 0
        public string ShipperOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if (canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = ShipperOrderConverter(orderBy, order);
            }
            else 
                NotValidOrderNumber(orderBy);
            return orderBy;
        }   

        //  Shipper Order Converter         -       Shipper           -   8 - 0 - 1 || 2
        public string ShipperOrderConverter(string orderBy, int order)
        {
            if (order == 1)  //  Ascend
            {
                this.Print(this.aStudentController.GetShipperOrderByAscending(orderBy));
            }
            else if (order == 2) //  Descend
            {
                this.Print(this.aStudentController.GetShipperOrderByDescending(orderBy));
            }
            else 
                NotValidOrderFile(orderBy);
            return orderBy;
        }   

        //  Supplier File                   -       Supplier          -   9
        public string Supplier(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            PrintList("Press a number 1 - 29 to choose a supplier \nOR Press 0 to recieve All of the Supplier's on " +
            "File: ");
            answer = Console.ReadLine();
            bool canConvert_SupplierId = int.TryParse(answer, out anId);   // Changing value of anId to value of answer
            if (canConvert_SupplierId == true)  // Test for if value is a int / number
            {
                answer = SupplierConverter(anId, answer, orderBy, order);
            }
            else 
                NotValidNumber(answer);
            return answer;
        }   

        //  Supplier Converter              -       Supplier          -   9
        public string SupplierConverter(int anId, string answer, string orderBy, int order)
        {
            if (anId > 0 && anId <= 29) //  Test For Range for Student File
            {
                this.Print(this.aStudentController.GetSupplierOrder(answer));
            }
            else if (anId == 0)
            {
                answer = SupplierOrder(orderBy, order);
            }
            else 
                NotValidFile(answer);
            return answer;
        }   

        //  Supplier Order                  -       Supplier          -   9 - 0
        public string SupplierOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if (canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = SupplierOrderConverter(orderBy, order);
            }
            else
                NotValidOrderNumber(orderBy);
            return orderBy;
        }   

        //  Supplier Converter Order        -       Supplier          -   9 - 0 - 1 || 2
        public string SupplierOrderConverter(string orderBy, int order)
        {
            if (order == 1)  //  Ascend
            {
                this.Print(this.aStudentController.GetSupplierOrderByAscending(orderBy));
            }
            else if (order == 2) //  Descend
            {
                this.Print(this.aStudentController.GetSupplierOrderByDescending(orderBy));
            }
            else 
                NotValidOrderFile(orderBy);
            return orderBy;
        }

        /*                              Converter In Progress           */
        //  Order Converter         -       In Progress, Not In Use!
        
        /*public delegate void Converter(string aString);
        public string ConverterList(string orderBy, int order, Converter aConverter)
        {
            if(order == 1)  //  Ascend
            {
                aConverter(orderBy);
                //this.Print(aConverter(orderBy));
                // this.Print(this.aStudentController.GetStudentsOrderByAscendingTest(orderBy));
            }
            else if(order == 2) //  Descend
            {
                aConverter(orderBy);
                //this.Print(aConverter(orderBy));
            }
            else
                NotValidOrderFile(orderBy);
            return orderBy;
        }*/

        //  Order Converter         -       In Progress, Not In Use!
        /*public string OrderConverter(string orderBy, int order)
        {
            if(order == 1)  //  Ascend
            {                
                this.Print(this.aStudentController.GetStudentsOrderByAscending(orderBy));
            }
            else if(order == 2) //  Descend
            {
                this.Print(this.aStudentController.GetStudentsOrderByDescending(orderBy));
            }
            else
                NotValidOrderFile(orderBy);
            return orderBy;
        }*/

        /*                      Response's to Wrong Data Entries    */
        //  Not Valid Number    -   answer
        public void NotValidNumber(string answer)
        {
            if(answer != "")
            {
                this.PrintExist("Your entry is not a valid integer / number!!");
            }
        }

        //  Not Valid Number    -   orderBy
        public void NotValidOrderNumber(string orderBy)
        {
            if(answer != "")
            {
                this.PrintExist("Your entry is not a valid integer / number!!");
            }
        }

        //  File Doesn't Exist  -   answer
        public void NotValidFile(string answer)
        {
            if(answer != "")  //   Output if File doesn't exist
            {
                this.PrintExist("The file does not exist!!");
            }
        }

        //  File doesn't Exist  -   orderBy
        public void NotValidOrderFile(string orderBy)
        {
            if(orderBy != "")  //   Output if File doesn't exist
            {
                this.PrintExist("The file does not exist!!");
            }
        }
    }   //  End of ConsoleView Class
}   //  End of namespace