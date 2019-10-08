

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OurBanner
{
    public class ConsoleViewJava
    {
        private StudentController aStudentController = null;
       
        public void Print(string aString)
        {
            Console.Write(aString);
        }

        //  Print List
        public void PrintList(string aString)
        {
            Console.WriteLine();
            Console.Write(aString);
        }

        //  Print Not Available
        public void PrintExist(string aString)
        {
            Console.WriteLine();
            Console.Write(aString);
            Console.WriteLine("\n");
        }
        
        //  Customer SQL
        public void PrintCustomerSQL(string aString)
        {
            //Console.WriteLine();
            Console.Write(aString);
        }

        //  Student
        public void Print(List<Student> aList)
        {
            Console.WriteLine();
            foreach(Student aStudent in aList)
            {
                //Console.WriteLine("");
                Console.WriteLine(aStudent.ToString());
                
            }
            //Console.ReadLine();

        }

        //  Category
        public void Print(List<Category> aList)
        {
            Console.WriteLine();
            foreach(Category aCategory in aList)
            {
                //Print("\n");
                Console.WriteLine(aCategory.ToString());

            }
            //Console.ReadLine();

        }

        //  Customer
        public void Print(List<Customer> aList)
        {
            Console.WriteLine();
            foreach(Customer aCustomer in aList)
            {
               Console.WriteLine(aCustomer.ToString());
               
            }
        }
        
        //  Employee
        public void Print(List<Employee> aList)
        {
            Console.WriteLine();
            foreach(Employee aEmployee in aList)
            {
                //Print("\n");
                Console.WriteLine(aEmployee.ToString());
            }
        }

        //  Order_Detail
        public void Print(List<Order_Detail> aList)
        {
            Console.WriteLine();
            foreach(Order_Detail aOrder_Details in aList)
            {
                //Print("\n");
                Console.WriteLine(aOrder_Details.ToString());
            }
        }

        //  Order
        public void Print(List<Order> aList)
        {
            Console.WriteLine();
            foreach(Order aOrder in aList)
            {
                //Print("\n");
                Console.WriteLine(aOrder.ToString());
            }
        }

        //  Product
        public void Print(List<Product> aList)
        {
            Console.WriteLine();
            foreach(Product aProduct in aList)
            {
                //Print("\n");
                Console.WriteLine(aProduct.ToString());
            }
        }

        //  Shipper
        public void Print(List<Shipper> aList)
        {
            Console.WriteLine();
            foreach(Shipper aShipper in aList)
            {
                //Print("\n");
                Console.WriteLine(aShipper.ToString());
            }
        }

        //  Supplier
        public void Print(List<Supplier> aList)
        {
            Console.WriteLine();
            foreach(Supplier aSupplier in aList)
            {
                //Print("\n");
                Console.WriteLine(aSupplier.ToString());
            }
        }

        private ConsoleViewJava()
        {

        }

        public ConsoleViewJava(StudentController aStudentController)
            : this()
        {
            this.aStudentController = aStudentController;
            this.PrintMenu();
        }

        /*// This is the new Linq Examples Method
        public void LinqExamples()
        {
            List<Student> aListofStudents = this.aStudentController.GetStudents();

            var students = from student in aListofStudents
                                            //where student.FirstName.Equals("John") //|| student.LastName.Length < 7
                                            //where student.IdNumber.Equals(
                                            //orderby student.IdNumber descending
                                            //select student;
                                            select new{
                                                FullName = student.FirstName + " " + student.LastName,
                                                ID = student.IdNumber

                                            };
            
            // IEnumerable<Student> orders = from student in students
                                          // where student.MiddleName.Equals("M.")
                                          // select student;

            foreach(var aStudent in students)
            {
                Console.WriteLine("Full Name = " + aStudent.FullName + "\n");
                //Console.WriteLine("First Name = " + aStudent.FirstName + "\n");
                //Console.WriteLine("Last Name = " + aStudent.LastName + "\n");

            }
            Console.ReadLine();
        }*/
        
        public void Print(int anInt)
        {
            Console.WriteLine(anInt);
            Console.ReadLine();
        }

        //  Student
        public void Print(Student aStudent)
        {
            Console.WriteLine(aStudent.ToString());
            Console.ReadLine();
        }

        //  Category
        public void Print(Category aCategory)
        {
            Console.WriteLine(aCategory.ToString());
            Console.ReadLine();
        }

        //  Customer
        public void Print(Customer aCustomer)
        {
            Console.WriteLine(aCustomer.ToString());
            Console.ReadLine();
        }

        //  Employee
        public void Print(Employee aEmployee)
        {
            Console.WriteLine(aEmployee.ToString());
            Console.ReadLine();
        }

        //  Order_Details
        public void Print(Order_Detail aOrderDetails)
        {
            Console.WriteLine(aOrderDetails.ToString());
            Console.ReadLine();
        }

        //  Orders
        public void Print(Order aOrder)
        {
            Console.WriteLine(aOrder.ToString());
            Console.ReadLine();
        }

        //  Product
        public void Print(Product aProduct)
        {
            Console.WriteLine(aProduct.ToString());
            Console.ReadLine();
        }

        //  Shipper
        public void Print(Shipper aShipper)
        {
            Console.WriteLine(aShipper.ToString());
            Console.ReadLine();
        }

        //  Supplier
        public void Print(Supplier aSupplier)
        {
            Console.WriteLine(aSupplier.ToString());
            Console.ReadLine();
        }

        public void PrintMenu()
        {
            string orderBy;
            int order;
            int anSwitchId;
            int anId;
            string answerMin;
            string answerMax;
            double aMin;
            double aMax;
            string answer;
            
            answer = "";
            this.PrintList("Students = 1, Category = 2, Customers = 3, Employee = 4, Order Details = 5: \n" + 
                "Order = 6, Product = 7, Shipper = 8, Supplier = 9: ");
            this.PrintList("Press a number 1 - 9: ");
            answer = Console.ReadLine();     //  Collecting input from Console
            
            while(answer != "") // Beginning of loop
            {
                bool canConvert_SwitchId = int.TryParse(answer, out anSwitchId);   // Switch - Changing value of anId to value of answer
                if(canConvert_SwitchId == true)  // Test for if SwitchId is a int / number
                {
                    if(anSwitchId > 0 && anSwitchId <= 9)
                    {
                        switch(anSwitchId)  //  Switch Begginning
                        {
                            case 1:
                                answer = "";
                                PrintList("Press a number 1 - 104 to choose a student \nOR Press 0 to recieve All of the Students on File: ");
                                answer = Console.ReadLine();
                                bool canConvert_Student = int.TryParse(answer, out anId);   // Student - Changing value of anId to value of answer
                                if(canConvert_Student == true)  // Test for if value is a int / number
                                {
                                    if(anId > 0 && anId <= 104) //  Test For Range for Student File
                                    {
                                        this.Print(this.aStudentController.GetStudents(answer));                                            
                                    }    //  End of Range for Student File
                                    else if(anId == 0)
                                    {
                                        orderBy = "";
                                        order = 0;
                                        PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
                                        orderBy = Console.ReadLine();
                                        bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
                                        if(canConvert_OrderBy == true)  // Test for if value is a int / number
                                        {
                                            if(order == 1)  //  Ascend
                                            {
                                                this.Print(this.aStudentController.GetStudentsOrderByAscending(orderBy));
                                            }
                                            else if(order == 2) //  Descend
                                            {
                                                this.Print(this.aStudentController.GetStudentsOrderByDescending(orderBy));
                                            }
                                            else if(orderBy != "")  //   Output if File doesn't exist
                                            {
                                                PrintExist("The file does not exist!!");
                                            }
                                        }
                                        else if(orderBy != "")  //  Output if value is not a int / number
                                        {
                                            PrintExist("Your entry is not a valid integer / number!!");
                                        }
                                    }
                                    else if(answer != "")  //   Output if File doesn't exist
                                    {
                                        this.PrintExist("The file does not exist!!");
                                    }
                                }
                                else if(answer != "")  //  Output if value is not a int / number
                                {
                                    this.PrintExist("Your entry is not a valid integer / number!!");
                                }
                                break;
                            case 2: // Categories
                                answer = "";
                                PrintList("Press a number 1 - 8 to choose a Category \nOR Press 0 to recieve All of the Categories on File: ");
                                answer = Console.ReadLine();
                                bool canConvert_CategoryId = int.TryParse(answer, out anId);   // Changing value of anId to value of answer
                                if(canConvert_CategoryId == true)  // Test for if value is a int / number
                                {
                                    if(anId > 0 && anId <= 8) //  Test For Range for Category File
                                    {
                                       this.Print(this.aStudentController.GetCategory(answer));
                                    }
                                    else if(anId == 0)
                                    {
                                        orderBy = "";
                                        order = 0;
                                        PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
                                        orderBy = Console.ReadLine();
                                        bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
                                        if(canConvert_OrderBy == true)  // Test for if value is a int / number
                                        {
                                            if(order == 1)  //  Ascend
                                            {
                                                this.Print(this.aStudentController.GetCategoryOrderByAscending(orderBy));
                                            }
                                            else if(order == 2) //  Descend
                                            {
                                                this.Print(this.aStudentController.GetCategoryOrderByDescending(orderBy));
                                            }
                                            else if(orderBy != "")  //   Output if File doesn't exist
                                            {
                                                this.PrintExist("The file does not exist!!");
                                            }
                                        }
                                        else if(orderBy != "")  //  Output if value is not a int / number
                                        {
                                            this.PrintExist("Your entry is not a valid integer / number!!");
                                        }
                                    }
                                    else if(answer != "")  //   Output if File doesn't exist
                                    {
                                        this.PrintExist("The file does not exist!!");
                                    }
                                }
                                else if(answer != "")  //  Output if value is not a int / number
                                {
                                    this.PrintExist("Your entry is not a valid int / number!!");
                                }
                                break;
                            case 3: // Customer
                                answer = "";
                                PrintList("Please type the customer name that you want to display from the file \nOR Press 0 to " +
                                "recieve All of the Customer's on File: ");
                                answer = Console.ReadLine();
                                switch(answer)
                                {
                                    case "ALFKI":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "ANATR":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "ANTON":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "AROUT":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "BERGS":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "BLAUS":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "BLONP":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "BOLID":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "BONAP":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "BOTTM":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "BSBEV":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "CACTU":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "CENTC":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "CHOPS":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "COMMI":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "CONSH":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "DRACD":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "DUMON":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "EASTC":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "ERNSH":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "FAMIA":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "FISSA":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "FOLIG":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "FOLKO":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "FRANK":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "FRANR":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "FRANS":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "FURIB":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "GALED":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "GODOS":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "GOURL":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "GREAL":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "GROSR":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "HANAR":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "HILAA":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "HUNGC":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "HUNGO":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "ISLAT":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "KOENE":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "LACOR":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "LAMAI":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "LAUGB":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "LAZYK":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "LEHMS":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "LETSS":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "LILAS":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "LINOD":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "LONEP":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "MAGAA":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "MAISD":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "MEREP":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "MORGK":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "NORTS":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "OCEAN":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "OLDWO":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "OTTIK":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "PARIS":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "PERIC":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "PICCO":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "PRINI":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "QUEDE":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "QUEEN":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "QUICK":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "RANCH":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "RATTC":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "REGGC":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "RICAR":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "RICSU":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "ROMEY":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "SANTG":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "SAVEA":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "SEVES":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "SIMOB":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "SPECD":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "SPLIR":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "SUPRD":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "THEBI":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "THECR":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "TOMSP":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "TORTU":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "TRADH":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "TRAIH":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "VAFFE":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "VICTE":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "VINET":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "WANDK":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "WARTH":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "WELLI":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "WHITC":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "WILMK":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "WOLZA":
                                        this.Print(this.aStudentController.GetCustomer(answer));
                                        break;
                                    case "0":
                                        bool canConvert_CustomerID = int.TryParse(answer, out anId);    //  Customer - Changing value of anId to value of the answer
                                        if(canConvert_CustomerID == true)  // Test for if value is a int / number
                                        {
                                            if(anId == 0)
                                            {
                                                orderBy = "";
                                                order = 0;
                                                PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
                                                orderBy = Console.ReadLine();
                                                bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
                                                if(canConvert_OrderBy == true)  // Test for if value is a int / number
                                                {
                                                    if(order == 1)  //  Ascend
                                                    {
                                                        this.Print(this.aStudentController.GetCustomerOrderByAscending(orderBy));
                                                    }
                                                    else if(order == 2) //  Descend
                                                    {
                                                        this.Print(this.aStudentController.GetCustomerOrderByDescending(orderBy));
                                                    }
                                                    else if(orderBy != "")  //   Output if File doesn't exist
                                                    {
                                                        this.PrintExist("The file does not exist!!");
                                                    }
                                                }
                                                else if(orderBy != "")  //  Output if value is not a int / number
                                                {
                                                    this.PrintExist("Your entry is not a valid integer / number!!");
                                                }
                                            }
                                            else if(answer != "")  //   Output if File doesn't exist
                                            {
                                                this.PrintExist("The file does not exist!!");
                                            }
                                        }
                                        else if(answer != "")
                                        {
                                            this.PrintExist("The entry is not a valid integer / number!!");
                                        }
                                        break;
                                    default:
                                        this.PrintExist("The file does not exist!!");
                                        break;
                                }
                                break;
                            case 4: // Employees    
                                answer = "";
                                PrintList("Press a number 1 - 9 to choose a employee \nOR Press 0 to recieve All of the employee's on File: ");
                                answer = Console.ReadLine();
                                bool canConvert_EmployeeID = int.TryParse(answer, out anId);   // Employee - Changing value of anId to value of answer
                                if(canConvert_EmployeeID == true)  // Test for if value is a int / number
                                {
                                    if(anId > 0 && anId <= 9) //  Test For Range for Employee File
                                    {
                                        switch(anId)
                                        {
                                            case 1:
                                                this.Print(this.aStudentController.GetEmployee(answer));
                                                break;
                                            case 2:
                                                this.Print(this.aStudentController.GetEmployee(answer));
                                                break;
                                            case 3:
                                                this.Print(this.aStudentController.GetEmployee(answer));
                                                break;
                                            case 4:
                                                this.Print(this.aStudentController.GetEmployee(answer));
                                                break;
                                            case 5:
                                                this.Print(this.aStudentController.GetEmployee(answer));
                                                break;
                                            case 6:
                                                this.Print(this.aStudentController.GetEmployee(answer));
                                                break;
                                            case 7:
                                                this.Print(this.aStudentController.GetEmployee(answer));
                                                break;
                                            case 8:
                                                this.Print(this.aStudentController.GetEmployee(answer));
                                                break;
                                            case 9:
                                                this.Print(this.aStudentController.GetEmployee(answer));
                                                break;
                                            default:
                                                this.PrintExist("The file does not exist!!");
                                                break;
                                        }
                                    }
                                    else if(anId == 0)
                                    {
                                        orderBy = "";
                                        order = 0;
                                        PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
                                        orderBy = Console.ReadLine();
                                        bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
                                        if(canConvert_OrderBy == true)  // Test for if value is a int / number
                                        {
                                            if(order == 1)  //  Ascend
                                            {
                                                this.Print(this.aStudentController.GetEmployeeOrderByAscending(orderBy));
                                            }
                                            else if(order == 2) //  Descend
                                            {
                                                this.Print(this.aStudentController.GetEmployeeOrderByDescending(orderBy));
                                            }
                                            else if(orderBy != "")  //   Output if File doesn't exist
                                            {
                                                this.PrintExist("The file does not exist!!");
                                            }
                                        }
                                        else if(orderBy != "")  //  Output if value is not a int / number
                                        {
                                            this.PrintExist("Your entry is not a valid integer / number!!");
                                        }
                                    }
                                    else if(answer != "")  //   Output if File doesn't exist
                                    {
                                        this.PrintExist("The file does not exist!!");
                                    }
                                }
                                else if(answer != "")  //  Output if value is not a int / number
                                {
                                    this.PrintExist("Your entry is not a valid integer / number!!");
                                }
                                break;
                            case 5://2156   Order_Detail
                                answer = "";
                                PrintList("Press a number 10248 - 11077 to choose a Order Detail \nOR Press 0 to recieve All of the "
                                + "Order Details on File: ");
                                answer = Console.ReadLine();
                                bool canConvert_Order_DetailID = int.TryParse(answer, out anId);   // OrderDetail - Changing value of anId to value of answer
                                if(canConvert_Order_DetailID == true)  // Test for if value is a int / number
                                {
                                    if(anId >= 10248 && anId <= 11077) //  Test For Range for Order Detail File
                                    {
                                        switch(anId)
                                        {
                                            case 10248:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10249:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10250:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10251:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10252:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10253:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10254:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10255:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10256:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10257:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10258:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10259:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10260:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10261:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10262:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10263:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10264:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10265:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10266:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10267:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10268:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10269:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10270:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10271:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10272:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10273:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10274:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10275:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10276:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10277:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10278:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10279:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10280:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10281:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10282:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10283:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10284:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10285:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10286:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10287:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10288:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10289:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10290:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10291:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10292:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10293:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10294:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10295:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10296:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10297:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10298:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10299:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10300:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10301:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10302:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10303:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10304:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10305:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10306:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10307:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10308:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10309:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10310:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10311:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10312:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10313:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10314:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10315:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10316:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10317:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10318:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10319:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10320:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10321:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10322:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10323:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10324:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;//Continue from here
                                            case 10325:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10326:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10327:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10328:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10329:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10330:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10331:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10332:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10333:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10334:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10335:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10336:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10337:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10338:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10339:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10340:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10341:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10342:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10343:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10344:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10345:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10346:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10347:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10348:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10349:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10350:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10351:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10352:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10353:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10354:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10355:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10356:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10357:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10358:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10359:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10360:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10361:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10362:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10363:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10364:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10365:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10366:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10367:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10368:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10369:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10370:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10371:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10372:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10373:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10374:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10375:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10376:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10377:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10378:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10379:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10380:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10381:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10382:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10383:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10384:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10385:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10386:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10387:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10388:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10389:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10390:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10391:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10392:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10393:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10394:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10395:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10396:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10397:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10398:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10399:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10400:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10401:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10402:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10403:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10404:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10405:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10406:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10407:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10408:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10409:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10410:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10411:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10412:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10413:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10414:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10415:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10416:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10417:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10418:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10419:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10420:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10421:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10422:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10423:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10424:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10425:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10426:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10427:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10428:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10429:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10430:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10431:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10432:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10433:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10434:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10435:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10436:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10437:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10438:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10439:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10440:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10441:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10442:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10443:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10444:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10445:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10446:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10447:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10448:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10449:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10450:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10451:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10452:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10453:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10454:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10455:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10456:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10457:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10458:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10459:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10460:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10461:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10462:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10463:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10464:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10465:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10466:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10467:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10468:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10469:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10470:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10471:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10472:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10473:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10474:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10475:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10476:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10477:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10478:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10479:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10480:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10481:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10482:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10483:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10484:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10485:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10486:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10487:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10488:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10489:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10490:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10491:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10492:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10493:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10494:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10495:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10496:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10497:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10498:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10499:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10500:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10501:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10502:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10503:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10504:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10505:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10506:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10507:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10508:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10509:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10510:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10511:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10512:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10513:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10514:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10515:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10516:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10517:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10518:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10519:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10520:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10521:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10522:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10523:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10524:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;//Continue from here
                                            case 10525:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10526:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10527:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10528:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10529:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10530:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10531:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10532:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10533:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10534:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10535:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10536:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10537:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10538:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10539:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10540:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10541:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10542:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10543:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10544:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10545:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10546:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10547:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10548:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10549:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10550:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10551:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10552:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10553:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10554:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10555:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10556:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10557:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10558:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10559:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10560:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10561:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10562:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10563:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10564:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10565:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10566:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10567:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10568:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10569:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10570:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10571:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10572:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10573:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10574:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10575:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10576:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10577:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10578:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10579:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10580:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10581:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10582:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10583:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10584:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10585:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10586:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10587:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10588:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10589:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10590:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10591:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10592:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10593:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10594:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10595:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10596:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10597:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10598:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10599:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10600:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10601:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10602:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10603:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10604:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10605:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10606:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10607:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10608:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10609:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10610:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10611:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10612:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10613:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10614:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10615:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10616:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10617:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10618:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10619:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10620:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10621:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10622:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10623:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10624:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;//Continue from here
                                            case 10625:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10626:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10627:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10628:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10629:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10630:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10631:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10632:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10633:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10634:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10635:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10636:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10637:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10638:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10639:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10640:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10641:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10642:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10643:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10644:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10645:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10646:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10647:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10648:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10649:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10650:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10651:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10652:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10653:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10654:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10655:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10656:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10657:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10658:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10659:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10660:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10661:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10662:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10663:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10664:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10665:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10666:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10667:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10668:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10669:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10670:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10671:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10672:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10673:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10674:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10675:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10676:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10677:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10678:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10679:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10680:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10681:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10682:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10683:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10684:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10685:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10686:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10687:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10688:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10689:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10690:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10691:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10692:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10693:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10694:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10695:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10696:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10697:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10698:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10699:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10700:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10701:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10702:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10703:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10704:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10705:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10706:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10707:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10708:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10709:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10710:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10711:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10712:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10713:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10714:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10715:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10716:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10717:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10718:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10719:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10720:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10721:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10722:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10723:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10724:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;//Continue from here
                                            case 10725:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10726:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10727:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10728:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10729:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10730:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10731:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10732:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10733:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10734:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10735:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10736:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10737:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10738:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10739:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10740:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10741:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10742:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10743:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10744:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10745:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10746:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10747:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10748:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10749:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10750:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10751:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10752:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10753:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10754:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10755:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10756:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10757:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10758:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10759:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10760:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10761:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10762:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10763:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10764:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10765:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10766:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10767:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10768:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10769:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10770:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10771:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10772:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10773:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10774:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10775:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10776:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10777:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10778:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10779:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10780:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10781:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10782:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10783:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10784:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10785:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10786:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10787:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10788:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10789:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10790:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10791:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10792:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10793:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10794:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10795:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10796:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10797:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10798:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10799:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10800:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10801:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10802:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10803:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10804:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10805:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10806:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10807:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10808:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10809:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10810:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10811:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10812:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10813:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10814:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10815:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10816:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10817:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10818:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10819:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10820:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10821:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10822:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10823:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10824:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;//Continue from here
                                            case 10825:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10826:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10827:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10828:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10829:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10830:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10831:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10832:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10833:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10834:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10835:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10836:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10837:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10838:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10839:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10840:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10841:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10842:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10843:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10844:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10845:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10846:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10847:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10848:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10849:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10850:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10851:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10852:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10853:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10854:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10855:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10856:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10857:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10858:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10859:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10860:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10861:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10862:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10863:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10864:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10865:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10866:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10867:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10868:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10869:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10870:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10871:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10872:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10873:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10874:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10875:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10876:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10877:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10878:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10879:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10880:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10881:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10882:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10883:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10884:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10885:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10886:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10887:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10888:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10889:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10890:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10891:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10892:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10893:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 103894:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10895:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10896:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10897:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10898:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10899:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10900:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10901:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10902:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10903:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10904:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10905:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10906:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10907:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10908:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10909:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10910:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10911:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10912:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10913:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10914:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10915:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10916:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10917:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10918:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10919:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10920:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10921:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10922:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10923:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10924:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;//Continue from here
                                            case 10925:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10926:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10927:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10928:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10929:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10930:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10931:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10932:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10933:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10934:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10935:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10936:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10937:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10938:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10939:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10940:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10941:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10942:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10943:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10944:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10945:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10946:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10947:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10948:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10949:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10950:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10951:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10952:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10953:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10954:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10955:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10956:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10957:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10958:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10959:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10960:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10961:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10962:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10963:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10964:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10965:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10966:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10967:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10968:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10969:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10970:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10971:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10972:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10973:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10974:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10975:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10976:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10977:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10978:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10979:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10980:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10981:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10982:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10983:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10984:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10985:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10986:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10987:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10988:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10989:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10990:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10991:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10992:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10993:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10994:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10995:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10996:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10997:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10998:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 10999:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11000:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11001:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11002:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11003:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11004:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11005:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11006:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11007:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11008:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11009:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11010:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11011:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11012:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11013:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11014:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11015:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11016:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11017:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11018:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11019:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11020:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11021:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11022:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11023:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11024:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;//Continue from here
                                            case 11025:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11026:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11027:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11028:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11029:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11030:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11031:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11032:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11033:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11034:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11035:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11036:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11037:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11038:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11039:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11040:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11041:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11042:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11043:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11044:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11045:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11046:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11047:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11048:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11049:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11050:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11051:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11052:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11053:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11054:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11055:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11056:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11057:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11058:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11059:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11060:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11061:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11062:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11063:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11064:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11065:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11066:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11067:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11068:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11069:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11070:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11071:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11072:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11073:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11074:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11075:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11076:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            case 11077:
                                                this.Print(this.aStudentController.GetOrderDetails(answer));
                                                break;
                                            default:
                                                this.PrintExist("The file does not exist!!");
                                                break;
                                        }
                                    }
                                    else if(anId == 0)
                                    {
                                        orderBy = "";
                                        order = 0;
                                        PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
                                        orderBy = Console.ReadLine();
                                        bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
                                        if(canConvert_OrderBy == true)  // Test for if value is a int / number
                                        {
                                            if(order == 1)  //  Ascend
                                            {
                                                this.Print(this.aStudentController.GetOrderDetailsOrderByAscending(orderBy));
                                            }
                                            else if(order == 2) //  Descend
                                            {
                                                this.Print(this.aStudentController.GetOrderDetailsOrderByDescending(orderBy));
                                            }
                                            else if(orderBy != "")  //   Output if File doesn't exist
                                            {
                                                this.Print("The file does not exist!!");
                                            }
                                        }
                                        else if(orderBy != "")  //  Output if value is not a int / number
                                        {
                                            this.PrintExist("Your entry is not a valid integer / number!!");
                                        }
                                    }
                                    else if(answer != "")  //   Output if File doesn't exist
                                    {
                                        this.PrintExist("The file does not exist!!");
                                    }
                                }
                                else if(answer != "")  //  Output if value is not a int / number
                                {
                                    this.PrintExist("Your entry is not a valid integer / number!!");
                                }
                                //*/
                                break;
                            case 6://830    //  Order
                                answer = "";
                                PrintList("Press a number 10248 - 11077 to choose a Order \nOR Press 0 to recieve All of the Order's " +
                                    "on File: ");
                                answer = Console.ReadLine();
                                bool canConvert_OrderID = int.TryParse(answer, out anId);   // OrderID - Changing value of anId to value of answer
                                if(canConvert_OrderID == true)  // Test for if value is a int / number
                                {
                                    if(anId >= 10248 && anId <= 11077) //  Test For Range for Order Detail File
                                    {
                                        switch(anId)
                                        {
                                            case 10248:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10249:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10250:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10251:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10252:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10253:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10254:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10255:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10256:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10257:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10258:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10259:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10260:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10261:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10262:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10263:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10264:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10265:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10266:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10267:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10268:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10269:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10270:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10271:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10272:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10273:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10274:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10275:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10276:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10277:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10278:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10279:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10280:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10281:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10282:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10283:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10284:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10285:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10286:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10287:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10288:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10289:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10290:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10291:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10292:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10293:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10294:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10295:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10296:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10297:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10298:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10299:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10300:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10301:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10302:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10303:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10304:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10305:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10306:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10307:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10308:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10309:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10310:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10311:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10312:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10313:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10314:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10315:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10316:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10317:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10318:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10319:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10320:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10321:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10322:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10323:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10324:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;//Continue from here
                                            case 10325:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10326:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10327:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10328:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10329:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10330:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10331:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10332:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10333:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10334:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10335:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10336:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10337:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10338:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10339:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10340:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10341:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10342:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10343:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10344:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10345:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10346:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10347:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10348:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10349:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10350:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10351:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10352:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10353:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10354:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10355:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10356:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10357:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10358:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10359:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10360:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10361:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10362:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10363:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10364:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10365:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10366:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10367:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10368:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10369:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10370:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10371:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10372:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10373:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10374:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10375:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10376:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10377:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10378:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10379:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10380:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10381:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10382:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10383:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10384:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10385:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10386:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10387:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10388:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10389:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10390:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10391:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10392:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10393:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10394:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10395:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10396:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10397:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10398:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10399:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10400:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10401:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10402:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10403:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10404:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10405:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10406:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10407:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10408:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10409:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10410:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10411:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10412:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10413:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10414:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10415:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10416:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10417:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10418:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10419:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10420:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10421:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10422:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10423:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10424:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10425:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10426:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10427:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10428:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10429:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10430:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10431:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10432:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10433:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10434:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10435:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10436:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10437:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10438:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10439:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10440:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10441:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10442:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10443:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10444:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10445:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10446:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10447:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10448:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10449:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10450:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10451:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10452:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10453:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10454:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10455:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10456:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10457:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10458:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10459:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10460:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10461:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10462:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10463:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10464:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10465:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10466:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10467:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10468:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10469:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10470:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10471:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10472:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10473:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10474:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10475:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10476:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10477:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10478:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10479:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10480:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10481:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10482:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10483:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10484:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10485:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10486:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10487:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10488:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10489:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10490:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10491:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10492:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10493:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10494:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10495:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10496:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10497:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10498:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10499:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10500:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10501:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10502:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10503:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10504:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10505:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10506:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10507:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10508:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10509:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10510:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10511:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10512:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10513:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10514:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10515:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10516:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10517:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10518:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10519:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10520:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10521:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10522:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10523:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10524:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;//Continue from here
                                            case 10525:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10526:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10527:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10528:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10529:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10530:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10531:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10532:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10533:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10534:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10535:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10536:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10537:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10538:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10539:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10540:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10541:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10542:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10543:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10544:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10545:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10546:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10547:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10548:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10549:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10550:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10551:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10552:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10553:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10554:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10555:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10556:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10557:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10558:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10559:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10560:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10561:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10562:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10563:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10564:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10565:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10566:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10567:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10568:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10569:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10570:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10571:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10572:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10573:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10574:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10575:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10576:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10577:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10578:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10579:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10580:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10581:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10582:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10583:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10584:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10585:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10586:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10587:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10588:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10589:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10590:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10591:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10592:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10593:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10594:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10595:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10596:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10597:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10598:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10599:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10600:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10601:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10602:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10603:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10604:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10605:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10606:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10607:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10608:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10609:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10610:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10611:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10612:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10613:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10614:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10615:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10616:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10617:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10618:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10619:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10620:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10621:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10622:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10623:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10624:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;//Continue from here
                                            case 10625:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10626:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10627:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10628:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10629:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10630:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10631:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10632:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10633:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10634:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10635:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10636:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10637:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10638:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10639:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10640:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10641:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10642:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10643:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10644:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10645:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10646:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10647:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10648:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10649:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10650:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10651:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10652:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10653:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10654:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10655:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10656:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10657:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10658:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10659:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10660:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10661:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10662:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10663:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10664:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10665:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10666:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10667:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10668:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10669:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10670:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10671:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10672:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10673:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10674:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10675:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10676:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10677:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10678:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10679:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10680:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10681:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10682:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10683:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10684:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10685:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10686:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10687:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10688:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10689:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10690:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10691:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10692:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10693:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10694:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10695:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10696:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10697:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10698:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10699:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10700:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10701:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10702:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10703:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10704:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10705:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10706:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10707:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10708:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10709:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10710:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10711:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10712:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10713:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10714:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10715:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10716:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10717:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10718:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10719:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10720:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10721:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10722:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10723:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10724:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;//Continue from here
                                            case 10725:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10726:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10727:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10728:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10729:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10730:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10731:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10732:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10733:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10734:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10735:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10736:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10737:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10738:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10739:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10740:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10741:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10742:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10743:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10744:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10745:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10746:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10747:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10748:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10749:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10750:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10751:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10752:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10753:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10754:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10755:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10756:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10757:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10758:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10759:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10760:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10761:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10762:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10763:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10764:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10765:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10766:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10767:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10768:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10769:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10770:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10771:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10772:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10773:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10774:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10775:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10776:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10777:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10778:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10779:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10780:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10781:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10782:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10783:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10784:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10785:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10786:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10787:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10788:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10789:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10790:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10791:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10792:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10793:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10794:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10795:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10796:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10797:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10798:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10799:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10800:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10801:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10802:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10803:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10804:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10805:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10806:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10807:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10808:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10809:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10810:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10811:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10812:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10813:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10814:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10815:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10816:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10817:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10818:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10819:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10820:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10821:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10822:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10823:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10824:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;//Continue from here
                                            case 10825:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10826:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10827:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10828:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10829:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10830:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10831:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10832:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10833:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10834:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10835:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10836:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10837:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10838:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10839:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10840:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10841:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10842:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10843:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10844:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10845:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10846:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10847:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10848:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10849:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10850:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10851:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10852:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10853:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10854:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10855:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10856:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10857:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10858:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10859:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10860:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10861:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10862:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10863:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10864:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10865:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10866:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10867:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10868:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10869:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10870:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10871:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10872:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10873:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10874:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10875:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10876:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10877:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10878:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10879:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10880:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10881:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10882:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10883:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10884:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10885:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10886:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10887:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10888:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10889:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10890:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10891:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10892:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10893:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 103894:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10895:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10896:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10897:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10898:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10899:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10900:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10901:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10902:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10903:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10904:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10905:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10906:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10907:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10908:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10909:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10910:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10911:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10912:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10913:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10914:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10915:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10916:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10917:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10918:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10919:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10920:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10921:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10922:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10923:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10924:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;//Continue from here
                                            case 10925:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10926:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10927:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10928:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10929:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10930:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10931:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10932:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10933:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10934:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10935:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10936:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10937:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10938:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10939:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10940:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10941:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10942:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10943:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10944:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10945:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10946:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10947:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10948:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10949:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10950:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10951:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10952:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10953:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10954:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10955:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10956:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10957:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10958:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10959:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10960:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10961:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10962:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10963:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10964:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10965:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10966:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10967:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10968:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10969:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10970:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10971:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10972:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10973:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10974:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10975:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10976:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10977:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10978:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10979:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10980:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10981:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10982:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10983:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10984:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10985:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10986:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10987:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10988:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10989:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10990:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10991:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10992:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10993:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10994:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10995:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10996:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10997:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10998:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 10999:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11000:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11001:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11002:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11003:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11004:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11005:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11006:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11007:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11008:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11009:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11010:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11011:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11012:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11013:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11014:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11015:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11016:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11017:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11018:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11019:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11020:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11021:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11022:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11023:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11024:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;//Continue from here
                                            case 11025:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11026:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11027:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11028:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11029:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11030:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11031:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11032:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11033:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11034:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11035:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11036:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11037:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11038:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11039:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11040:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11041:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11042:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11043:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11044:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11045:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11046:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11047:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11048:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11049:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11050:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11051:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11052:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11053:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11054:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11055:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11056:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11057:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11058:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11059:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11060:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11061:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11062:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11063:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11064:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11065:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11066:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11067:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11068:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11069:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11070:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11071:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11072:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11073:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11074:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11075:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11076:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            case 11077:
                                                this.Print(this.aStudentController.GetOrder(answer));
                                                break;
                                            default:
                                                this.PrintExist("The file does not exist!!");
                                                break;
                                        }
                                    }
                                    else if(anId == 0)
                                    {
                                        orderBy = "";
                                        order = 0;
                                        PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
                                        orderBy = Console.ReadLine();
                                        bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
                                        if(canConvert_OrderBy == true)  // Test for if value is a int / number
                                        {
                                            if(order == 1)  //  Ascend
                                            {
                                                this.Print(this.aStudentController.GetOrderOrderByAscending(orderBy));
                                            }
                                            else if(order == 2) //  Descend
                                            {
                                                this.Print(this.aStudentController.GetOrderOrderByDescending(orderBy));
                                            }
                                            else if(orderBy != "")  //   Output if File doesn't exist
                                            {
                                                this.PrintExist("The file does not exist!!");
                                            }
                                        }
                                        else if(orderBy != "") //  Output if value is not a int / number
                                        {
                                            this.PrintExist("Your entry is not a valid integer / number!!");
                                        }
                                    }
                                    else if(answer != "")  //   Output if File doesn't exist
                                    {
                                        this.PrintExist("The file does not exist!!");
                                    }
                                }
                                else if(answer != "")  //  Output if value is not a int / number
                                {
                                    this.PrintExist("Your entry is not a valid integer / number!!");
                                }
                                break;
                            case 7: // Products
                                answer = "";
                                PrintList("Press a number 1 - 3 to choose which way you want to display your product \nSinlge / " +
                                "All product files = 1 \nDisplay by product's category = 2 \nDisplay by Unit price range = 3: ");
                                answer = Console.ReadLine();
                                bool canConvert_Products = int.TryParse(answer, out anId);   // Product - Changing value of anId to value of answer
                                if(canConvert_Products == true)  // Test for if value is a int / number
                                {
                                    if(anId > 0 && anId <= 3)
                                    {
                                        switch(anId)
                                        {
                                            case 1: //  Display signle Product or all products
                                                answer = "";
                                                PrintList("Press a number 1 - 77 to choose a product \nOR Press 0 to recieve All of the " +
                                                    "Products on File: ");
                                                answer = Console.ReadLine();
                                                bool canConvert_ProductsID = int.TryParse(answer, out anId);   // Product ID Sort - Changing value of anId to value of answer
                                                if(canConvert_ProductsID == true)  // Test for if value is a int / number
                                                {
                                                    if(anId > 0 && anId <= 77) //  Test For Range for Product File
                                                    {
                                                        switch(anId)    //  Single Print Out
                                                        {
                                                            case 1:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 2:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 3:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 4:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 5:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 6:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 7:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 8:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 9:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 10:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 11:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 12:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 13:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 14:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 15:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 16:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 17:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 18:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 19:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 20:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 21:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 22:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 23:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 24:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 25:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 26:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 27:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 28:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 29:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 30:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 31:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 32:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 33:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 34:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 35:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 36:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 37:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 38:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 39:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 40:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 41:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 42:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 43:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 44:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 45:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 46:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 47:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 48:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 49:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 50:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 51:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 52:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 53:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 54:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 55:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 56:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 57:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 58:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 59:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 60:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 61:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 62:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 63:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 64:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 65:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 66:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 67:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 68:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 69:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 70:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 71:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 72:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 73:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 74:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 75:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 76:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            case 77:
                                                                this.Print(this.aStudentController.GetProduct(answer));
                                                                break;
                                                            default:
                                                                this.PrintExist("The file does not exist!!");
                                                                break;
                                                        }
                                                    }
                                                    else if(anId == 0)
                                                    {
                                                        orderBy = "";
                                                        order = 0;
                                                        PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
                                                        orderBy = Console.ReadLine();
                                                        bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
                                                        if(canConvert_OrderBy == true)  // Test for if value is a int / number
                                                        {
                                                            if(order == 1)  //  Ascend
                                                            {
                                                                this.Print(this.aStudentController.GetProductOrderByAscending(orderBy));
                                                            }
                                                            else if(order == 2) //  Descend
                                                            {
                                                                this.Print(this.aStudentController.GetProductOrderByDescending(orderBy));
                                                            }
                                                            else if(orderBy != "")  //   Output if File doesn't exist
                                                            {
                                                                this.PrintExist("The file does not exist!!");
                                                            }
                                                        }
                                                        else if(orderBy != "")  //  Output if value is not a int / number
                                                        {
                                                            this.PrintExist("Your entry is not a valid integer / number!!");
                                                        }

                                                    }
                                                    else if(answer != "")   //   Output if File doesn't exist
                                                    {
                                                        this.PrintExist("The file does not exist!!");
                                                    }
                                                }
                                                else if(answer != "") //  Output if value is not a int / number
                                                {
                                                    this.PrintExist("Your entry is not a valid int / number!!");
                                                }
                                                break;
                                            case 2: //  Display by product's category
                                                answer = "";
                                                PrintList("Press a number 1 - 8 to choose a product's category: ");
                                                answer = Console.ReadLine();
                                                bool canConvert_ProductsCategoryID = int.TryParse(answer, out anId);   // Product - Category - Changing value of anId to value of answer
                                                if(canConvert_ProductsCategoryID == true)  // Test for if value is a int / number
                                                {
                                                    if(anId > 0 && anId <= 8) //  Test For Range for Product File
                                                    {
                                                        switch(anId)    //  Single Print Out
                                                        {
                                                            case 1:
                                                                this.Print(this.aStudentController.GetProductCategory(answer));
                                                                break;
                                                            case 2:
                                                                this.Print(this.aStudentController.GetProductCategory(answer));
                                                                break;
                                                            case 3:
                                                                this.Print(this.aStudentController.GetProductCategory(answer));
                                                                break;
                                                            case 4:
                                                                this.Print(this.aStudentController.GetProductCategory(answer));
                                                                break;
                                                            case 5:
                                                                this.Print(this.aStudentController.GetProductCategory(answer));
                                                                break;
                                                            case 6:
                                                                this.Print(this.aStudentController.GetProductCategory(answer));
                                                                break;
                                                            case 7:
                                                                this.Print(this.aStudentController.GetProductCategory(answer));
                                                                break;
                                                            case 8:
                                                                this.Print(this.aStudentController.GetProductCategory(answer));
                                                                break;
                                                            default:
                                                                this.PrintExist("The entry does not exist on file!!");
                                                                break;
                                                        }   //  End of switch statement for product category
                                                    }
                                                    else if(answer != "")  //   Output if File doesn't exist
                                                    {
                                                        this.PrintExist("The file does not exist!!");
                                                    }
                                                }
                                                else if(answer != "")  //  Output if value is not a int / number
                                                {
                                                    this.PrintExist("Your entry is not a valid integer / number!!");
                                                }
                                                break;
                                            case 3:     //  DONE
                                                answerMin = "";
                                                answerMax = "";
                                                PrintList("Lowest Number can be 0: \nChoose your Min range: ");
                                                answerMin = Console.ReadLine();
                                                PrintList("Highest number is unlimited: \nChoose you Max range: ");
                                                answerMax = Console.ReadLine();
                                                bool canConvert_ProductsRangeMin = double.TryParse(answer, out aMin);   // Product - Range - Min - Changing value of anId to value of answer
                                                bool canConvert_ProductsRangeMax = double.TryParse(answer, out aMax);   // Product - Range - Max - Changing value of anId to value of answer
                                                if(canConvert_ProductsRangeMin == true && canConvert_ProductsRangeMax == true)  // Test for if value is a int / number
                                                {
                                                    if(aMin > 0) //  Test For Range for Product File
                                                    {
                                                        this.Print(this.aStudentController.GetProductRange(answerMin, answerMax));
                                                    }
                                                    else if(answerMin != "" || answerMax != "") //   Output if File doesn't exist
                                                    {
                                                        this.PrintExist("The file does not exist!!");
                                                    }
                                                }
                                                else if(answerMin != "" || answerMax != "") //  Output if value is not a int / number
                                                {
                                                    this.PrintExist("Your entry is not a valid integer / number!!");
                                                }
                                                break;
                                        }
                                    }
                                    else if(answer != "")//   Output if File doesn't exist
                                    {
                                        this.PrintExist("The file does not exist!!");
                                    }
                                }
                                else if(answer != "")  //  Output if value is not a int / number
                                {
                                    this.PrintExist("Your entry is not a valid integer / number!!");
                                }
                                break;
                            case 8: // Shipper
                                answer = "";
                                PrintList("Press a number 1 - 3 to choose a shipper \nOR Press 0 to recieve All of the Shipper on File: ");
                                answer = Console.ReadLine();
                                bool canConvert_ShipperID = int.TryParse(answer, out anId);   // Shipper - Changing value of anId to value of answer
                                if(canConvert_ShipperID == true)  // Test for if value is a int / number
                                {
                                    if(anId > 0 && anId <= 3) //  Test For Range for Shipper File
                                    {
                                        switch(anId)
                                        {
                                            case 1:
                                                this.Print(this.aStudentController.GetShipper(answer));
                                                break;
                                            case 2:
                                                this.Print(this.aStudentController.GetShipper(answer));
                                                break;
                                            case 3:
                                                this.Print(this.aStudentController.GetShipper(answer));
                                                break;
                                            default:
                                                this.PrintExist("The file does not exist!!\n");
                                                break;
                                        }
                                    }
                                    else if(anId == 0)
                                    {
                                        orderBy = "";
                                        order = 0;
                                        PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
                                        orderBy = Console.ReadLine();
                                        bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
                                        if(canConvert_OrderBy == true)  // Test for if value is a int / number
                                        {
                                            if(order == 1)  //  Ascend
                                            {
                                                this.Print(this.aStudentController.GetShipperOrderByAscending(orderBy));
                                            }
                                            else if(order == 2) //  Descend
                                            {
                                                this.Print(this.aStudentController.GetShipperOrderByDescending(orderBy));
                                            }
                                            else if(orderBy != "") //   Output if File doesn't exist
                                            {
                                                this.PrintExist("The file does not exist!!");
                                            }

                                        }
                                        else if(orderBy != "")  //  Output if value is not a int / number
                                        {
                                            this.PrintExist("Your entry is not a valid integer / number!!");
                                        }
                                    }
                                    else if(answer != "")  //   Output if File doesn't exist
                                    {
                                        this.PrintExist("The file does not exist!!");
                                    }
                                }
                                else if(answer != "")  //  Output if value is not a int / number
                                {
                                    this.PrintExist("Your entry is not a valid integer / number!!");
                                }
                                break;
                            case 9: // Supplier
                                answer = "";
                                PrintList("Press a number 1 - 29 to choose a supplier \nOR Press 0 to recieve All of the Supplier's on " +
                                "File: ");
                                answer = Console.ReadLine();
                                bool canConvert_SupplierId = int.TryParse(answer, out anId);   // Changing value of anId to value of answer
                                if(canConvert_SupplierId == true)  // Test for if value is a int / number
                                {
                                    if(anId > 0 && anId <= 29) //  Test For Range for Student File
                                    {
                                        switch(anId)
                                        {
                                            case 1:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 2:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 3:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 4:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 5:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 6:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 7:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 8:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 9:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 10:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 11:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 12:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 13:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 14:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 15:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 16:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 17:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 18:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 19:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 20:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 21:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 22:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 23:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 24:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 25:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 26:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 27:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 28:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            case 29:
                                                this.Print(this.aStudentController.GetSupplier(answer));
                                                break;
                                            default:
                                                this.PrintExist("The file does not exist!!");
                                                break;
                                        }
                                    }
                                    else if(anId == 0)
                                    {
                                        orderBy = "";
                                        order = 0;
                                        PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
                                        orderBy = Console.ReadLine();
                                        bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
                                        if(canConvert_OrderBy == true)  // Test for if value is a int / number
                                        {
                                            if(order == 1)  //  Ascend
                                            {
                                                this.Print(this.aStudentController.GetSupplierOrderByAscending(orderBy));
                                            }
                                            else if(order == 2) //  Descend
                                            {
                                                this.Print(this.aStudentController.GetSupplierOrderByDescending(orderBy));
                                            }
                                            else if(orderBy != "")  //   Output if File doesn't exist
                                            {
                                                this.PrintExist("The file does not exist!!");
                                            }
                                        }
                                        else if(orderBy != "")  //  Output if value is not a int / number
                                        {
                                            this.PrintExist("Your entry is not a valid integer / number!!");
                                        }
                                    }
                                    else if(answer != "")  //   Output if File doesn't exist
                                    {
                                        this.PrintExist("The file does not exist!!");
                                    }
                                }
                                else if(answer != "")  //  Output if value is not a int / number
                                {
                                    this.PrintExist("Your entry is not a valid integer / number!!");
                                }
                                break;
                            default:
                                this.PrintExist("The file does not exist!!");
                                break;
                        }   //  End of switch
                    }   //  Switch Statment Range
                    else if(answer != "")  //   Output if File doesn't exist
                    {
                        this.PrintExist("The file does not exist!!");
                    }
                }   //  Number Range test if statement 
                else if(answer != "")  //  Output if value is not a int / number
                {
                    this.PrintExist("Your entry is not a valid integer / number!!");
                }  // End of Test for number
                if (answer != "")
                {
                    answer = "";
                    Print("Do you want to continue? Y = Yes, N = No: ");
                    answer = Console.ReadLine();
                }
                while (answer != "y" || answer != "Y" || answer != "n" || answer != "N" || answer != "")
                {
                    if (answer == "Y" || answer == "y" || answer == "n" || answer == "N" || answer == "")
                    {
                        break;
                    }
                    else
                    {
                        PrintExist("Your response is not valid answer!!");
                        answer = "";
                        Print("Do you want to continue? Y = Yes, N = No: ");
                        answer = Console.ReadLine();
                    }
                }
                if (answer == "Y" || answer == "y")
                {
                    Console.Clear();
                    this.PrintList("Students = 1, Category = 2, Customers = 3, Employee = 4, Order Details = 5: \n" + 
                        "Order = 6, Product = 7, Shipper = 8, Supplier = 9: ");
                    this.PrintList("Press a number 1 - 9: ");
                    answer = Console.ReadLine();     //  Collecting input from Console
                }
                else if (answer == "n" || answer == "N")
                {
                    break;
                }
            }   //  End of While statement
        }   // End of Print Menu Void
    }   //  End of ConsoleView Class
}   //  End of namespace
