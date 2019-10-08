﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data;
using System.Data.OleDb;

namespace Connection
{
    public class DBUtilityAdapterLoader
    {
        //  Student List
        List<Student> aStudentList = new List<Student>();
        //  Customer String Filter
        List<String> aCustomerStringList = new List<String>();
        //  Mayflower.xml - aStudentFile
        private XDocument aStudentFile = XDocument.Load(@"C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\Connection\Connection\Data Loader\Mayflower.xml");
		//	Connection Variable
		private  static OleDbConnection aConnection = new OleDbConnection();
		//	Command Variable
        private  static OleDbCommand aCommand = aConnection.CreateCommand();
		//	Adapter Varaible
        private  static OleDbDataAdapter anAdapter = new OleDbDataAdapter(aCommand);
		//	DataSet Variable
        private  static DataSet aDataSet = new DataSet();
		//	Instance Variable
        private static DBUtilityAdapterLoader anInstance = null;

        public static DBUtilityAdapterLoader GetanInstance
        {
            get
            {
                if(DBUtilityAdapterLoader.anInstance == null)
                {
                    DBUtilityAdapterLoader.anInstance = new DBUtilityAdapterLoader();
                }
                return DBUtilityAdapterLoader.anInstance;
            }
        }

        public DBUtilityAdapterLoader()
        {
            // This is private which prevents any other code
            // from creating one.
            // No code anywhere -- EXCEPT from within
            // this class -- can create an object 
            // from this class

            // set the connection string
            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\Connection\Connection\Data\Northwind.accdb";
           
        }

        /*//  Open the Connection
           aConnection.Open();

           //  Test the connection
           if(aConnection.State == System.Data.ConnectionState.Open)
           {
               Console.WriteLine("The Connection is Open");
           }
           else
           {
               Console.WriteLine("The Connection did not open correctly");
           }
           Console.ReadLine();

           //  Set the SQL statements
           //  Products SQL
           string aSQLProducts = "SELECT Products.ProductID, Products.ProductName, Suppliers.CompanyName, Categories.CategoryName, " +
               "Products.QuantityPerUnit, Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, " +
               "Products.Discontinued " +
               "FROM ((Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN Suppliers ON " +
               "Products.SupplierID = Suppliers.SupplierID)" +
               "ORDER BY Products.ProductID ASC;";

           //  Categories SQL
           string aSQLCategories = "SELECT CategoryID, CategoryName, Description FROM Categories ";

           aCommand.CommandText = aSQLProducts;

           anAdapter.Fill(aDataSet, "MyProducts");

           aCommand.CommandText = aSQLCategories;

           anAdapter.Fill(aDataSet, "MyCategories");

           aConnection.Close();

           Console.WriteLine("Loaded the Data Tables!");
           Console.ReadLine();*/
        /*public void GetProducts()
        {
            

            foreach(DataRow aRow in aDataSet.Tables["MyProducts"].Rows)
            {
                Console.WriteLine("Product ID = " + aRow["ProductID"].ToString());
                Console.WriteLine("Product Name = " + aRow["ProductName"].ToString());
                Console.WriteLine("Supplier ID = " + aRow["CompanyName"].ToString());
                Console.WriteLine("Category ID = " + aRow["CategoryName"].ToString());
                Console.WriteLine("Quantity Per Unit = " + aRow["QuantityPerUnit"].ToString());
                Console.WriteLine("Unit Price = " + aRow["UnitPrice"].ToString());
                Console.WriteLine("Units In Stock = " + aRow["UnitsInStock"].ToString());
                Console.WriteLine("Units On Order = " + aRow["UnitsOnOrder"].ToString());
                Console.WriteLine("ReOrderLevel = " + aRow["ReorderLevel"].ToString());
                Console.WriteLine("Discontinued = " + aRow["Discontinued"].ToString());

                Console.WriteLine();
            }
         }*/
        
        //  Get DataSet
        public static DataSet GetDataSet
        {
            get
            {
                return aDataSet;
            }
        }

        //  Student SQL                             -       Student          -   1                      -   DONE
        public List<Student> GetStudentsOrder(string answer)
        {
            string aStudentId = "n/a";    //  Student ID
            string aFirstName = "n/a";
            string aLastName = "n/a";
            string aMiddleName = "n/a";

            IEnumerable<XElement> rows = from row in aStudentFile.Descendants("name")
                                         where row.Attribute("IDNumber").Value.Equals(answer)
                                         select row;

            foreach(var aRow in rows)
            {
                aStudentId = aRow.Attribute("IDNumber").Value;
                aFirstName = aRow.Attribute("FirstName").Value;
                aLastName = aRow.Attribute("LastName").Value;
                aMiddleName = aRow.Attribute("MiddleName").Value;

                Student aStudent = new Student(aStudentId, aFirstName, aLastName, aMiddleName);
                aStudentList.Add(aStudent);
            }
            return aStudentList;
        }

        //  Student Ascending                       -       Student          -   1 - 0 - 1              -   DONE
        public List<Student> GetStudentsOrderByAscending(string orderBy)
        {
            string aStudentId = "n/a";    //  Student ID
            string aFirstName = "n/a";
            string aLastName = "n/a";
            string aMiddleName = "n/a";
            List<Student> aList = new List<Student>();

            IEnumerable<XElement> rows = from row in aStudentFile.Descendants("name")
                                         orderby Convert.ToInt32(row.Attribute("IDNumber").Value) ascending
                                         select row;

            foreach(var aRow in rows)
            {
                aStudentId = aRow.Attribute("IDNumber").Value;
                aFirstName = aRow.Attribute("FirstName").Value;
                aLastName = aRow.Attribute("LastName").Value;
                aMiddleName = aRow.Attribute("MiddleName").Value;

                Student aStudent = new Student(aStudentId, aFirstName, aLastName, aMiddleName);
                aList.Add(aStudent);
            }
            return aList;
        }

        //  Student Descending                      -       Student          -   1 - 0 - 2              -   DONE
        public List<Student> GetStudentsOrderByDescending(string orderBy)
        {
            string anId = "n/a";    //  Student ID
            string aFirstName = "n/a";
            string aLastName = "n/a";
            string aMiddleName = "n/a";
            List<Student> aList = new List<Student>();

            IEnumerable<XElement> rows = from row in aStudentFile.Descendants("name")
                                         orderby Convert.ToInt32(row.Attribute("IDNumber").Value) descending
                                         select row;

            foreach(var aRow in rows)
            {
                anId = aRow.Attribute("IDNumber").Value;
                aFirstName = aRow.Attribute("FirstName").Value;
                aLastName = aRow.Attribute("LastName").Value;
                aMiddleName = aRow.Attribute("MiddleName").Value;

                Student aStudent = new Student(anId, aFirstName, aLastName, aMiddleName);
                aStudentList.Add(aStudent);
            }
            return aStudentList;
        }
        
        //  Category SQL                            -       Category         -   2                      -   DONE
        public DataTable GetCategoryOrder(string answer)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories;";

            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("CategoryTable"))
            {
                aDataSet.Tables["CategoryTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "CategoryTable");
            //  Filter
            var categoryanswer = from category in aDataSet.Tables["CategoryTable"].AsEnumerable()
                                 where category.Field<int>("Categories.CategoryID") == Convert.ToInt32(answer)
                                 select category;

            return categoryanswer.CopyToDataTable();
        }

        //  Category Ascending                      -       Category         -   2 - 0 - 1              -   DONE
        public DataTable GetCategoryOrderByAscending(string orderBy)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories;";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("CategoryTable"))
            {
                aDataSet.Tables["CategoryTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "CategoryTable");

            var categoryascendinganswer = from category in aDataSet.Tables["CategoryTable"].AsEnumerable()
                                 orderby category.Field<int>("Categories.CategoryID") ascending
                                 select category;

            return categoryascendinganswer.CopyToDataTable();
        }

        //  Category Descending                     -       Category         -   2 - 0 - 2              -   DONE
        public DataTable GetCategoryOrderByDescending(string orderBy)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories;";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("CategoryTable"))
            {
                aDataSet.Tables["CategoryTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "CategoryTable");

            var categorydescendinganswer = from category in aDataSet.Tables["CategoryTable"].AsEnumerable()
                                 orderby category.Field<int>("Categories.CategoryID") descending
                                 select category;

            return categorydescendinganswer.CopyToDataTable();
        }

        //  Get CustomerID Name Range               -       Customer         -   3                      -   DONE
        public List<String> GetCustomerIDs()
        {
            string aCustomerFilterId = "n/a";                  //CustomerID

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT Customers.CustomerID FROM Customers;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aCustomerFilterId = (string)aReader["Customers.CustomerID"];
                String aCustomer = aCustomerFilterId;
                aCustomerStringList.Add(aCustomer);
            }
            //  Close Connection
            aConnection.Close();
            return aCustomerStringList;
        }

        //  Customer SQL                            -       Customer         -   3                      -   DONE
        public DataTable GetCustomerOrder(string answer)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, " +
                "PostalCode, Country, Phone, Fax FROM Customers;";

            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("CustomerTable"))
            {
                aDataSet.Tables["CustomerTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "CustomerTable");
            //  Filter
            var customeranswer = from customer in aDataSet.Tables["CustomerTable"].AsEnumerable()
                                 where customer.Field<int>("Customers.CustomerID") == Convert.ToInt32(answer)
                                 select customer;

            return customeranswer.CopyToDataTable();
        }

        //  Customer Ascending                      -       Customer         -   3 - 0 - 1              -   DONE
        public DataTable GetCustomerOrderByAscending(string orderBy)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, " +
                "PostalCode, Country, Phone, Fax FROM Customers;";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("CustomerTable"))
            {
                aDataSet.Tables["CustomerTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "CustomerTable");

            var customeranswer = from customer in aDataSet.Tables["CustomerTable"].AsEnumerable()
                                 orderby customer.Field<int>("Customers.CustomerID") ascending
                                 select customer;

            return customeranswer.CopyToDataTable();
        }

        //  Customer Descending                     -       Customer         -   3 - 0 - 2              -   DONE
        public DataTable GetCustomerOrderByDescending(string orderBy)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, " +
                "PostalCode, Country, Phone, Fax FROM Customers;";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("CustomerTable"))
            {
                aDataSet.Tables["CustomerTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "CustomerTable");

            var customeranswer = from customer in aDataSet.Tables["CustomerTable"].AsEnumerable()
                                 orderby customer.Field<int>("Customers.CustomerID") descending
                                 select customer;

            return customeranswer.CopyToDataTable();
        }

        //  Employee SQL                            -       Employee         -   4                      -   DONE
        public DataTable GetEmployeeOrder(string answer)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT EmployeeID, (Employees.FirstName + " + " " + "Employees.LastName) AS [Employees Name], " + 
                    "Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, " + 
                    "Photo, Notes, ReportsTo FROM Employees;";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("EmployeeTable"))
            {
                aDataSet.Tables["EmployeeTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "EmployeeTable");

            var employeeanswer = from employee in aDataSet.Tables["EmployeeTable"].AsEnumerable()
                                 where employee.Field<int>("Employees.EmployeeID") == Convert.ToInt32(answer)
                                 select employee;

            return employeeanswer.CopyToDataTable();
        }

        //  Employee Ascending                      -       Employee         -   4 - 0 - 1              -   DONE
        public DataTable GetEmployeeOrderByAscending(string orderBy)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT EmployeeID, (Employees.FirstName + " + " " + "Employees.LastName) AS [Employees Name], " + 
                    "Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, " + 
                    "Photo, Notes, ReportsTo FROM Employees;";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("EmployeeTable"))
            {
                aDataSet.Tables["EmployeeTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "EmployeeTable");

            var employeeanswer = from employee in aDataSet.Tables["EmployeeTable"].AsEnumerable()
                                 orderby employee.Field<int>("Employees.EmployeeID") ascending
                                 select employee;

            return employeeanswer.CopyToDataTable();
        }

        //  Employee Descending                     -       Employee         -   4 - 0 - 2              -   DONE
        public DataTable GetEmployeeOrderByDescending(string orderBy)  
        {                       
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT EmployeeID, (Employees.FirstName + " + " " + "Employees.LastName) AS [Employees Name], " + 
                    "FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, " + 
                    "Extension, Photo, Notes, ReportsTo FROM Employees;";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("EmployeeTable"))
            {
                aDataSet.Tables["EmployeeTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "EmployeeTable");

            var employeeanswer = from employee in aDataSet.Tables["EmployeeTable"].AsEnumerable()
                                 orderby employee.Field<int>("Employees.EmployeeID") descending
                                 select employee;

            return employeeanswer.CopyToDataTable();
        }

        //  Order Detail File                       -       Order Detail     -   5                      -   DONE    -   Java / C / C++    -   Break it down even more
        /*  Old Section
        public List<Order_Detail> GetOrderDetails(string answer)
        {
            int anId = -1;          //  Order Number
            int aProductId = -1;
            double aUnitPrice = 0;
            int aQuantity = -1;
            string aDiscount = "n/a";
            List<Order_Detail> aList = new List<Order_Detail>();

            IEnumerable<XElement> rows = from row in aOrderDetailsFile.Descendants("OrderDetail")
                                         where row.Attribute("OrderID").Value.Equals(answer)
                                         select row;

            foreach(var aRow in rows)
            {
                anId = Convert.ToInt32(aRow.Attribute("OrderID").Value);
                aProductId = Convert.ToInt32(aRow.Attribute("ProductID").Value);
                aUnitPrice = Convert.ToDouble(aRow.Attribute("UnitPrice").Value);
                aQuantity = Convert.ToInt32(aRow.Attribute("Quantity").Value);
                aDiscount = aRow.Attribute("Discount").Value;
                
                Order_Detail aOrderDetails = new Order_Detail(anId, aProductId,  aUnitPrice, aQuantity,aDiscount);
                aList.Add(aOrderDetails);
            }
            return aList;
        }*/

        /*  In Progress 
        //  Order Detail File                       -       Order Detail     -   5                      -   DONE    -   BREAK IT DOWN EVEN MORE NOW!
        public List<Order_Detail> GetOrderDetailOrder(string answer)
        {
            int orderId = -1;          //  Order Number
            string aProductId = "n/a";
            Customer Customer = null;
            Employee Employee = null;
            double aUnitPrice = 0;
            int aQuantity = -1;
            string aDiscount = "n/a";
            //List<Order_Detail> aList = new List<Order_Detail>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT [Order Details].OrderID, Products.ProductName, Customers.ContactTitle, Customers.ContactName, " + 
            "Employees.TitleOfCourtesy, Employees.FirstName, Employees.LastName, Employees.Title, [Order Details].Quantity, [Order Details].Discount " +
            "FROM Products INNER JOIN ((Employees INNER JOIN (Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) " + 
                "ON Employees.EmployeeID = Orders.EmployeeID) INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) " +
                "ON Products.ProductID = [Order Details].ProductID " +
            "WHERE [Order Details].OrderID = " + answer + " " +
            "ORDER BY [Order Details].OrderID;";

            
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                orderId = (int)aReader["OrderID"];
                aProductId = Convert.ToString(aReader["ProductName"]);
                Customer.ContactTitle = Convert.ToString((aReader["ContactTitle"]));
                Customer.ContactName = Convert.ToString(aReader["ContactName"]);
                Employee.TitleOfCourtesy = (string)(aReader["TitleOfCourtesy"]);
                Employee.FirstName = (string)(aReader["FirstName"]);
                Employee.LastName = (string)(aReader["LastName"]);
                Employee.Title = (string)(aReader["Title"]);
                aUnitPrice = Convert.ToDouble(aReader["UnitPrice"]);
                aQuantity = Convert.ToInt32(aReader["Quantity"]);
                aDiscount = Convert.ToString(Convert.ToDouble(aReader["Discount"]));


                Order_Detail aOrderDetails = new Order_Detail(orderId, aProductId, Customer.ContactTitle, Customer.ContactName, Employee.TitleOfCourtesy,
                Employee.FirstName, Employee.LastName, Employee.Title, aUnitPrice, aQuantity, aDiscount);
                aOrder_DetailList.Add(aOrderDetails);
            }
            //  Close Connection
            aConnection.Close();
            return aOrder_DetailList;
        }

        //  Order Detail Ascending                  -       Order Detail     -   5 - 0 - 1              -   DONE
        public List<Order_Detail> GetOrderDetailsOrderByAscending(string orderBy)
        {
            int orderId = -1;          //  Order Number
            string aProductId = "n/a";
            Customer Customer = null;
            Employee Employee = null;
            double aUnitPrice = 0;
            int aQuantity = -1;
            string aDiscount = "n/a";
            //  List<Order_Detail> aList = new List<Order_Detail>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details];";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();
            // 
            while(aReader.Read())
            {
                orderId = (int)aReader["OrderID"];
                aProductId = Convert.ToString(aReader["ProductID"]);
                aUnitPrice = Convert.ToDouble(aReader["UnitPrice"]);
                aQuantity = Convert.ToInt32(aReader["Quantity"]);
                aDiscount = Convert.ToString(Convert.ToDouble(aReader["Discount"]));

                Order_Detail aOrderDetails = new Order_Detail(orderId, aProductId, Customer.ContactTitle, Customer.ContactName, 
                Employee.TitleOfCourtesy, Employee.FirstName, Employee.LastName, Employee.Title, aUnitPrice, aQuantity, aDiscount);
                aOrder_DetailList.Add(aOrderDetails);
            }
            //  Close Connection
            aConnection.Close();
            return aOrder_DetailList;
        }

        //  Order Detail Descending                 -       Order Detail     -   5 - 0 - 2              -   DONE
        public List<Order_Detail> GetOrderDetailsOrderByDescending(string orderBy)
        {
            int orderId = -1;          //  Order Number
            string aProductId = "n/a";
            Customer Customer = null;
            Employee Employee = null;
            double aUnitPrice = 0;
            int aQuantity = -1;
            string aDiscount = "n/a";
            List<Order_Detail> aList = new List<Order_Detail>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details];";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                orderId = (int)aReader["OrderID"];
                aProductId = Convert.ToString(aReader["ProductID"]);
                aUnitPrice = Convert.ToDouble(aReader["UnitPrice"]);
                aQuantity = Convert.ToInt32(aReader["Quantity"]);
                aDiscount = Convert.ToString(Convert.ToDouble(aReader["Discount"]));

                Order_Detail aOrderDetails = new Order_Detail(orderId, aProductId, Customer.ContactTitle, Customer.ContactName,
                Employee.TitleOfCourtesy, Employee.FirstName, Employee.LastName, Employee.Title, aUnitPrice, aQuantity, aDiscount);
                aOrder_DetailList.Add(aOrderDetails);
            }
            //  Close Connection
            aConnection.Close();
            return aOrder_DetailList;
        }*/

        /*  In Progress Side Way  */
        //  Order Detail File                       -       Order Detail     -   5                      -   DONE    -   BREAK IT DOWN EVEN MORE NOW!
        public DataTable GetOrderDetailOrder(string answer)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT [Order Details].OrderID, Products.ProductName, Customers.ContactTitle, Customers.ContactName, " +
            "Employees.TitleOfCourtesy, Employees.FirstName, Employees.LastName, Employees.Title, [Order Details].UnitPrice, " +
            "[Order Details].Quantity, [Order Details].Discount " +
            "FROM Products INNER JOIN ((Employees INNER JOIN (Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) " +
                "ON Employees.EmployeeID = Orders.EmployeeID) INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) " +
                "ON Products.ProductID = [Order Details].ProductID;";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("OrderDetailsTable"))
            {
                aDataSet.Tables["OrderDetailsTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "OrderDetailsTable");

            var orderdetailsanswer = from orderdetails in aDataSet.Tables["OrderDetailsTable"].AsEnumerable()
                                     where orderdetails.Field<int>("[Order Details].OrderID") == Convert.ToInt32(answer)
                                     orderby orderdetails.Field<int>("[Order Details].OrderID")
                                     select orderdetails;

            return orderdetailsanswer.CopyToDataTable();
        }

        //  Order Detail Ascending                  -       Order Detail     -   5 - 0 - 1              -   DONE
        public DataTable GetOrderDetailsOrderByAscending(string orderBy)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT [Order Details].OrderID, Products.ProductName, Customers.ContactTitle, Customers.ContactName, " +
            "Employees.TitleOfCourtesy, Employees.FirstName, Employees.LastName, Employees.Title, [Order Details].UnitPrice, " +
            "[Order Details].Quantity, [Order Details].Discount " +
            "FROM Products INNER JOIN ((Employees INNER JOIN (Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) " +
                "ON Employees.EmployeeID = Orders.EmployeeID) INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) " +
                "ON Products.ProductID = [Order Details].ProductID;";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("OrderDetailsTable"))
            {
                aDataSet.Tables["OrderDetailsTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "OrderDetailsTable");

            var orderdetailsanswer = from orderdetails in aDataSet.Tables["OrderDetailsTable"].AsEnumerable()
                                     orderby orderdetails.Field<int>("[Order Details].OrderID") ascending
                                     select orderdetails;

            return orderdetailsanswer.CopyToDataTable();
        }

        //  Order Detail Descending                 -       Order Detail     -   5 - 0 - 2              -   DONE
        public DataTable GetOrderDetailsOrderByDescending(string orderBy)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT [Order Details].OrderID, Products.ProductName, Customers.ContactTitle, Customers.ContactName, " +
            "Employees.TitleOfCourtesy, Employees.FirstName, Employees.LastName, Employees.Title, [Order Details].UnitPrice, " +
            "[Order Details].Quantity, [Order Details].Discount " +
            "FROM Products INNER JOIN ((Employees INNER JOIN (Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) " +
                "ON Employees.EmployeeID = Orders.EmployeeID) INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) " +
                "ON Products.ProductID = [Order Details].ProductID;";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("OrderDetailsTable"))
            {
                aDataSet.Tables["OrderDetailsTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "OrderDetailsTable");

            var orderdetailsanswer = from orderdetails in aDataSet.Tables["OrderDetailsTable"].AsEnumerable()
                                     orderby orderdetails.Field<int>("[Order Details].OrderID") descending
                                     select orderdetails;

            return orderdetailsanswer.CopyToDataTable();
        }//*/

        /*  Old Section 
        //  Order Detail File                       -       Order Detail     -   5                      -   DONE    -   BREAK IT DOWN EVEN MORE NOW!
        public List<Order_Detail> GetOrderDetailOrder(string answer)
        {
            int anId = -1;          //  Order Number
            string aProductId = "n/a";
            double aUnitPrice = 0;
            int aQuantity = -1;
            string aDiscount = "n/a";
            List<Order_Detail> aList = new List<Order_Detail>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT [Order Details].OrderID, Products.ProductName, [Order Details].UnitPrice, [Order Details].Quantity, " +
            "[Order Details].Discount " +
            "FROM [Order Details] INNER JOIN Products ON [Order Details].ProductID = Products.ProductID " +
            "WHERE [Order Details].OrderID = " + answer + ";";
            //" ORDERBY [Order Details].OrderID;";
            //aCommand.CommandText = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details] WHERE OrderID = " + answer + ";";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                anId = (int)aReader["OrderID"];
                aProductId = Convert.ToString(aReader["ProductName"]);
                aUnitPrice = Convert.ToDouble(aReader["UnitPrice"]);
                aQuantity = Convert.ToInt32(aReader["Quantity"]);
                aDiscount = Convert.ToString(Convert.ToDouble(aReader["Discount"]));

                Order_Detail aOrderDetails = new Order_Detail(anId, aProductId, aUnitPrice, aQuantity, aDiscount);
                aList.Add(aOrderDetails);
            }
            //  Close Connection
            aConnection.Close();
            return aList;
        }

        //  Order Detail Ascending                  -       Order Detail     -   5 - 0 - 1              -   DONE
        public List<Order_Detail> GetOrderDetailsOrderByAscending(string orderBy)
        {
            int anId = -1;          //  Order Number
            string aProductId = "n/a";
            double aUnitPrice = 0;
            int aQuantity = -1;
            string aDiscount = "n/a";
            List<Order_Detail> aList = new List<Order_Detail>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT [Order Details].OrderID, Products.ProductName, [Order Details].UnitPrice, [Order Details].Quantity, " + 
            "[Order Details].Discount " + 
            "FROM [Order Details] INNER JOIN Products ON [Order Details].ProductID = Products.ProductID " +
            "ORDER BY [Order Details].OrderID ASC;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();
            // 
            while(aReader.Read())
            {
                anId = (int)aReader["OrderID"];
                aProductId = Convert.ToString(aReader["ProductName"]);
                aUnitPrice = Convert.ToDouble(aReader["UnitPrice"]);
                aQuantity = Convert.ToInt32(aReader["Quantity"]);
                aDiscount = Convert.ToString(Convert.ToDouble(aReader["Discount"]));

                Order_Detail aOrderDetails = new Order_Detail(anId, aProductId, aUnitPrice, aQuantity, aDiscount);
                aList.Add(aOrderDetails);
            }
            //  Close Connection
            aConnection.Close();
            return aList;
        }

        //  Order Detail Descending                 -       Order Detail     -   5 - 0 - 2              -   DONE
        public List<Order_Detail> GetOrderDetailsOrderByDescending(string orderBy)
        {
            int anId = -1;          //  Order Number
            string aProductId = "n/a";
            double aUnitPrice = 0;
            int aQuantity = -1;
            string aDiscount = "n/a";
            List<Order_Detail> aList = new List<Order_Detail>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT [Order Details].OrderID, Products.ProductName, [Order Details].UnitPrice, [Order Details].Quantity, " +
                "[Order Details].Discount " +
                "FROM [Order Details] INNER JOIN Products ON [Order Details].ProductID = Products.ProductID " +
                "ORDER BY [Order Details].OrderID DESC;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                anId = (int)aReader["OrderID"];
                aProductId = Convert.ToString(aReader["ProductName"]);
                aUnitPrice = Convert.ToDouble(aReader["UnitPrice"]);
                aQuantity = Convert.ToInt32(aReader["Quantity"]);
                aDiscount = Convert.ToString(Convert.ToDouble(aReader["Discount"]));

                Order_Detail aOrderDetails = new Order_Detail(anId, aProductId, aUnitPrice, aQuantity, aDiscount);
                aList.Add(aOrderDetails);
            }
            //  Close Connection
            aConnection.Close();
            return aList;
        }//*/

        //  Order File                              -       Order            -   6                      -   DONE
        public DataTable GetOrderOrder(string answer)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT Orders.OrderID, Customers.ContactTitle, Customers.ContactName, (Employees.FirstName + " + 
                " " + "Employees.LastName) AS [Employees Name], Orders.OrderDate, Orders.RequiredDate, Orders.ShippedDate, Orders.ShipVia, " + 
                "Orders.Freight, Orders.ShipName, Orders.ShipAddress, Orders.ShipCity, Orders.ShipRegion, Orders.ShipPostalCode, " + 
                "Orders.ShipCountry" +
                "FROM ((Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) INNER JOIN Employees ON Orders.EmployeeID " + 
                "= Employees.EmployeeID);";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("OrdersTable"))
            {
                aDataSet.Tables["OrdersTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "OrdersTable");

            var ordersanswer = from orders in aDataSet.Tables["OrdersTable"].AsEnumerable()
                                 where orders.Field<int>("Orders.OrderID") == Convert.ToInt32(answer)
                                 orderby orders.Field<int>("Orders.OrdersID") 
                                 select orders;

            return ordersanswer.CopyToDataTable();
        }

        //  Order File Ascending                    -       Order            -   6 - 0 - 1              -   DONE
        public DataTable GetOrderOrderByAscending(string orderBy)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT Orders.OrderID, Customers.ContactTitle, Customers.ContactName, (Employees.FirstName + " +
                " " + "Employees.LastName) AS [Employees Name], Orders.OrderDate, Orders.RequiredDate, Orders.ShippedDate, Orders.ShipVia, " +
                "Orders.Freight, Orders.ShipName, Orders.ShipAddress, Orders.ShipCity, Orders.ShipRegion, Orders.ShipPostalCode, " +
                "Orders.ShipCountry" +
                "FROM ((Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) INNER JOIN Employees ON Orders.EmployeeID " +
                "= Employees.EmployeeID);";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("OrdersTable"))
            {
                aDataSet.Tables["OrdersTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "OrdersTable");

            var ordersanswer = from orders in aDataSet.Tables["OrdersTable"].AsEnumerable()
                               orderby orders.Field<int>("Orders.OrdersID") ascending
                               select orders;

            return ordersanswer.CopyToDataTable();
        }

        //  Order File Descending                   -       Order            -   6 - 0 - 2              -   DONE
        public DataTable GetOrderOrderByDescending(string orderBy)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT Orders.OrderID, Customers.ContactTitle, Customers.ContactName, (Employees.FirstName + " +
                " " + "Employees.LastName) AS [Employees Name], Orders.OrderDate, Orders.RequiredDate, Orders.ShippedDate, Orders.ShipVia, " +
                "Orders.Freight, Orders.ShipName, Orders.ShipAddress, Orders.ShipCity, Orders.ShipRegion, Orders.ShipPostalCode, " +
                "Orders.ShipCountry" +
                "FROM ((Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) INNER JOIN Employees ON Orders.EmployeeID " +
                "= Employees.EmployeeID);";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("OrdersTable"))
            {
                aDataSet.Tables["OrdersTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "OrdersTable");

            var ordersanswer = from orders in aDataSet.Tables["OrdersTable"].AsEnumerable()
                               orderby orders.Field<int>("Orders.OrdersID") descending
                               select orders;

            return ordersanswer.CopyToDataTable();
        }

        //  Product File                            -       Product          -   7                      -   DONE
        public DataTable GetProductOrder(string answer)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT Products.ProductID, Products.ProductName, Suppliers.CompanyName, Categories.CategoryName, " +
                "Products.QuantityPerUnit, Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, " +
                "Products.Discontinued " +
                "FROM ((Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN Suppliers ON " +
                "Products.SupplierID = Suppliers.SupplierID);";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("ProductsTable"))
            {
                aDataSet.Tables["ProductsTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "ProductsTable");

            var productsanswer = from products in aDataSet.Tables["ProductsTable"].AsEnumerable()
                               where products.Field<int>("Products.ProductID") == Convert.ToInt32(answer)
                               select products;

            return productsanswer.CopyToDataTable();
        }

        //  Product Ascending                       -       Product          -   7 - 1 - 0 - 1          -   DONE
        public DataTable GetProductOrderByAscending(string orderBy)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT Products.ProductID, Products.ProductName, Suppliers.CompanyName, Categories.CategoryName, " +
                "Products.QuantityPerUnit, Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, " +
                "Products.Discontinued " +
                "FROM ((Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN Suppliers ON " +
                "Products.SupplierID = Suppliers.SupplierID);";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("ProductsTable"))
            {
                aDataSet.Tables["ProductsTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "ProductsTable");

            var productsanswer = from products in aDataSet.Tables["ProductsTable"].AsEnumerable()
                                 orderby products.Field<int>("Products.ProductID") ascending
                                 select products;

            return productsanswer.CopyToDataTable();
        }

        //  Product Descending                      -       Product          -   7 - 1 - 0 - 2          -   DONE
        public DataTable GetProductOrderByDescending(string orderBy)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT Products.ProductID, Products.ProductName, Suppliers.CompanyName, Categories.CategoryName, " +
                "Products.QuantityPerUnit, Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, " +
                "Products.Discontinued " +
                "FROM ((Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN Suppliers ON " +
                "Products.SupplierID = Suppliers.SupplierID);";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("ProductsTable"))
            {
                aDataSet.Tables["ProductsTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "ProductsTable");

            var productsanswer = from products in aDataSet.Tables["ProductsTable"].AsEnumerable()
                                 orderby products.Field<int>("Products.ProductID") descending
                                 select products;

            return productsanswer.CopyToDataTable();
        }

        //  Product Category                        -       Product          -   7 - 2                  -   DONE
        public DataTable GetProductCategory(string answer)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT Products.ProductID, Products.ProductName, Suppliers.CompanyName,Categories.CategoryName, " +
                "Products.QuantityPerUnit, Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, " +
                 "Products.Discontinued " +
                "FROM ((Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN Suppliers ON Products.SupplierID " +
                "= Suppliers.SupplierID) ";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("ProductsTable"))
            {
                aDataSet.Tables["ProductsTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "ProductsTable");

            var productsanswer = from products in aDataSet.Tables["ProductsTable"].AsEnumerable()
                                 where products.Field<int>("Products.CategoryID") == Convert.ToInt32(answer)
                                 select products;

            return productsanswer.CopyToDataTable();
        }

        //  Product Range                           -       Product          -   7 - 3                  -   DONE
        public DataTable GetProductRange(string answerMin, string answerMax)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT Products.ProductID, Products.ProductName, Suppliers.CompanyName,Categories.CategoryName, " +
                "Products.QuantityPerUnit, Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, " +
                 "Products.Discontinued " +
                "FROM ((Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN Suppliers ON Products.SupplierID " +
                "= Suppliers.SupplierID) ";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("ProductsTable"))
            {
                aDataSet.Tables["ProductsTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "ProductsTable");

            var productsrangeanswer = from productsrange in aDataSet.Tables["ProductsTable"].AsEnumerable()
                                 where productsrange.Field<int>("Products.UnitPrice") == Convert.ToInt32(answerMin) && productsrange.Field<int>("Products.UnitPrice") == Convert.ToInt32(answerMax)
                                 orderby productsrange.Field<int>("Products.UnitPrice"), productsrange.Field<int>("Products.ProductName") 
                                 select productsrange;

            return productsrangeanswer.CopyToDataTable();

        }

        /*//  Set the Product Range SQL Statement
    aCommand.CommandText = "SELECT Products.ProductID, Products.ProductName, Suppliers.CompanyName, Categories.CategoryName, Products.QuantityPerUnit, " +
    "Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, Products.Discontinued " +
    "FROM ((Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN Suppliers ON Products.SupplierID = " +
    "Suppliers.SupplierID) " +
    "WHERE Products.UnitPrice >= " + answerMin + " AND Products.UnitPrice <= " + answerMax + " " +
    "ORDER BY Products.UnitPrice, Products.ProductName;";*/

        //  Shipper File                            -       Shipper          -   8                      -   DONE
        public DataTable GetShipperOrder(string answer)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT Shippers.ShipperID, Shippers.CompanyName, Shippers.Phone FROM Shippers;";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("ShipperTable"))
            {
                aDataSet.Tables["ShipperTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "ShipperTable");

            var shipperanswer = from shipper in aDataSet.Tables["ShipperTable"].AsEnumerable()
                                      where shipper.Field<int>("Shippers.ShipperID") == Convert.ToInt32(answer)
                                      select shipper;

            return shipperanswer.CopyToDataTable();
        }

        //  Shipper Ascending                       -       Shipper          -   8 - 0 - 1              -   DONE
        public DataTable GetShipperOrderByAscending(string orderBy)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT Shippers.ShipperID, Shippers.CompanyName, Shippers.Phone FROM Shippers;";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("ShipperTable"))
            {
                aDataSet.Tables["ShipperTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "ShipperTable");

            var shipperanswer = from shipper in aDataSet.Tables["ShipperTable"].AsEnumerable()
                                orderby shipper.Field<int>("Shippers.ShipperID") ascending
                                select shipper;

            return shipperanswer.CopyToDataTable();
        }

        //  Shipper Descending                      -       Shipper          -   8 - 0 - 2              -   DONE
        public DataTable GetShipperOrderByDescending(string orderBy)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT Shippers.ShipperID, Shippers.CompanyName, Shippers.Phone FROM Shippers;";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("ShipperTable"))
            {
                aDataSet.Tables["ShipperTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "ShipperTable");

            var shipperanswer = from shipper in aDataSet.Tables["ShipperTable"].AsEnumerable()
                                orderby shipper.Field<int>("Shippers.ShipperID") descending
                                select shipper;

            return shipperanswer.CopyToDataTable();
        }

        //  Supplier File                           -       Supplier         -   9                      -   DONE
        public DataTable GetSupplierOrder(string answer)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, " +
            "Country, Phone, Fax, HomePage FROM Suppliers;";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("SuppliersTable"))
            {
                aDataSet.Tables["SuppliersTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "SuppliersTable");

            var supplieranswer = from supplier in aDataSet.Tables["SuppliersTable"].AsEnumerable()
                                       where supplier.Field<int>("Suppliers.SupplierID") == Convert.ToInt32(answer)
                                       select supplier;

            return supplieranswer.CopyToDataTable();
        }

        //  Supplier Ascending                      -       Supplier         -   9 - 0 - 1              -   DONE
        public DataTable GetSupplierOrderByAscending(string orderBy)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, " +
            "Country, Phone, Fax, HomePage FROM Suppliers;";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("SuppliersTable"))
            {
                aDataSet.Tables["SuppliersTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "SuppliersTable");

            var supplieranswer = from supplier in aDataSet.Tables["SuppliersTable"].AsEnumerable()
                                 orderby supplier.Field<int>("Suppliers.SupplierID") ascending
                                 select supplier;

            return supplieranswer.CopyToDataTable();
        }

        //  Supplier Descending                     -       Supplier         -   9 - 0 - 2              -   DONE
        public DataTable GetSupplierOrderByDescending(String orderBy)
        {
            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, " +
            "Country, Phone, Fax, HomePage FROM Suppliers;";
            //  Close Connection
            aConnection.Close();
            if(aDataSet.Tables.Contains("SuppliersTable"))
            {
                aDataSet.Tables["SuppliersTable"].Clear();
            }
            anAdapter.Fill(aDataSet, "SuppliersTable");

            var supplieranswer = from supplier in aDataSet.Tables["SuppliersTable"].AsEnumerable()
                                 orderby supplier.Field<int>("Suppliers.SupplierID") descending
                                 select supplier;

            return supplieranswer.CopyToDataTable();
        }
    }
}