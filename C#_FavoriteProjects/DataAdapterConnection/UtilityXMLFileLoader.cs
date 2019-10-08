/* 
 * Chris Carrier
 * 2-4-14
 * Visual Studio Class 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data;
using System.Data.OleDb;

namespace Connection
{
    public sealed class UtilityXMLFileLoader
    {
        //  Create Connection Object
        private OleDbConnection aConnection = new OleDbConnection();
        //  Student Object List Filter
        List<Object> aObjectList = new List<Object>();
        //  Student List
        List<Student> aStudentList = new List<Student>();
        //  Customer String Filter
        List<String> aCustomerStringList = new List<String>();
        //  Customer List
        List<Customer> aCustomerList = new List<Customer>();
        //  Category List
        List<Category> aCategoryList = new List<Category>();
        //  Employee List
        List<Employee> aEmployeeList = new List<Employee>();
        //  Order List
        List<Order> aOrderList = new List<Order>();
        //  Order_Detail List
        List<Order_Detail> aOrder_DetailList = new List<Order_Detail>();
        //  Product List
        List<Product> aProductList = new List<Product>();
        //  Shipper List
        List<Shipper> aShipperList = new List<Shipper>();
        //  Supplier List
        List<Supplier> aSupplierList = new List<Supplier>();
        

                                        /*  XML Data Input   */
        //  Mayflower.xml - aStudentFile
        private XDocument aStudentFile = XDocument.Load(@"C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\Connection\Connection\Data Loader\Mayflower.xml");
        //  Categories.xml - aCategoryFile
        private XDocument aCategoryFile = XDocument.Load(@"C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\Connection\Connection\Data Loader\Categories.xml");
        //  Customers.xml - aCustomerFile
        private XDocument aCustomerFile = XDocument.Load(@"C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\Connection\Connection\Data Loader\Customers.xml");
        //  Employees.xml - aEmployeesFile
        private XDocument aEmployeesFile = XDocument.Load(@"C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\Connection\Connection\Data Loader\Employees.xml");
        //  OrderDetails.xml - aOrderDetailsFile
        private XDocument aOrderDetailsFile = XDocument.Load(@"C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\Connection\Connection\Data Loader\OrderDetails.xml");
        //  Orders.xml - aOrderFile
        private XDocument aOrderFile = XDocument.Load(@"C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\Connection\Connection\Data Loader\Orders.xml");
        //  Products.xml - aProductsFile
        private XDocument aProductsFile = XDocument.Load(@"C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\Connection\Connection\Data Loader\Products.xml");
        //  Shippers.xml - aShippersFile
        private XDocument aShippersFile = XDocument.Load(@"C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\Connection\Connection\Data Loader\Shippers.xml");
        //  Suppliers.xml - aSuppliersFile
        private XDocument aSuppliersFile = XDocument.Load(@"C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\Connection\Connection\Data Loader\Suppliers.xml");

        private static UtilityXMLFileLoader anInstance = null;

        public static UtilityXMLFileLoader GetanInstance
        {
            get
            {
                if(UtilityXMLFileLoader.anInstance == null)
                {
                    UtilityXMLFileLoader.anInstance = new UtilityXMLFileLoader();
                }
                return UtilityXMLFileLoader.anInstance;
            }
        }

        private UtilityXMLFileLoader()
        {
            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\Connection\Connection\Data\Northwind.accdb";

            //  This is private which prevents any other code
            //  from creating on.
            //  No code anywhere -- EXCEPT from within
            //  this class -- can create an object
            //  from this class
        }

        //  Converter Order List    -       In Progress, Not In Use!
        public List<Object> GetStudentsOrderByAscendingTest(string orderBy)
        {
            string aStudentObjectId = "n/a";    //  Student ID
            string aFirstName = "n/a";
            string aLastName = "n/a";
            string aMiddleName = "n/a";
            List<Object> aList = new List<Object>();

            IEnumerable<XElement> rows = from row in aStudentFile.Descendants("name")
                                         orderby Convert.ToInt32(row.Attribute("IDNumber").Value) ascending
                                         select row;

            foreach(var aRow in rows)
            {
                aStudentObjectId = aRow.Attribute("IDNumber").Value;
                aFirstName = aRow.Attribute("FirstName").Value;
                aLastName = aRow.Attribute("LastName").Value;
                aMiddleName = aRow.Attribute("MiddleName").Value;

                Object aStudent = new Student(aStudentObjectId, aFirstName, aLastName, aMiddleName);
                aList.Add(aStudent);
            }
            return aList;
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
            //  List<Student> aList = new List<Student>();

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
        public List<Category> GetCategoryOrder(string answer)
        {
            int aCategoryId = -1;          //  Category ID
            string aCategoryName = "n/a";
            string aDescription = "n/a";
            //List<Category> aCategoryList = new List<Category>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories WHERE CategoryID =" + answer + ";";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aCategoryId = (int)aReader["CategoryID"];
                aCategoryName = (string)aReader["CategoryName"];
                aDescription = (string)aReader["Description"];
                Category aCategory = new Category(aCategoryId, aCategoryName, aDescription);
                aCategoryList.Add(aCategory);
            }
            //  Close Connection
            aConnection.Close();
            return aCategoryList;
        }

        //  Category Ascending                      -       Category         -   2 - 0 - 1              -   DONE
        public List<Category> GetCategoryOrderByAscending(string orderBy)
        {
            int aCategoryId = -1;          //  Category ID
            string aCategoryName = "n/a";
            string aDescription = "n/a";
            List<Category> aList = new List<Category>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories ORDER BY CategoryID ASC;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aCategoryId = (int)aReader["CategoryID"];
                aCategoryName = (string)aReader["CategoryName"];
                aDescription = (string)aReader["Description"];
                Category aCategory = new Category(aCategoryId, aCategoryName, aDescription);
                aList.Add(aCategory);
            }
            //  Close Connection
            aConnection.Close();
            return aList;
        }

        //  Category Descending                     -       Category         -   2 - 0 - 2              -   DONE
        public List<Category> GetCategoryOrderByDescending(string orderBy)
        {
            int aCategoryId = -1;          //  Category ID
            string aCategoryName = "n/a";
            string aDescription = "n/a";
            List<Category> aList = new List<Category>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories ORDER BY CategoryID DESC;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aCategoryId = (int)aReader["CategoryID"];
                aCategoryName = (string)aReader["CategoryName"];
                aDescription = (string)aReader["Description"];
                Category aCategory = new Category(aCategoryId, aCategoryName, aDescription);
                aList.Add(aCategory);
            }
            //  Close Connection
            aConnection.Close();
            return aList;
        }

        //  Get CustomerID Name Range               -       Customer         -   3                      -   DONE
        public List<String> GetCustomerIDs()
        {
            string aCustomerFilterId = "n/a";                  //CustomerID
            //List<String> aList = new List<String>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT CustomerID FROM Customers;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aCustomerFilterId = (string)aReader["CustomerID"];
                String aCustomer = aCustomerFilterId;
                aCustomerStringList.Add(aCustomer);
            }
            //  Close Connection
            aConnection.Close();
            return aCustomerStringList;
        }

        //  Customer SQL                            -       Customer         -   3                      -   DONE
        public List<Customer> GetCustomerOrder(string answer)
        {
            string aCustomerId = "n/a";                  //CustomerID
            string aCompanyName = "n/a";
            string aContactName = "n/a";
            string aContactTitle = "n/a";
            string aAddress = "n/a";
            string aCity = "n/a";
            string aRegion = "n/a";
            string aPostalCode = "n/a";
            string aCountry = "n/a";
            string aPhone = "n/a";
            string aFax = "n/a";
            //List<Customer> aList = new List<Customer>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, " +
                "PostalCode, Country, Phone, Fax FROM Customers WHERE CustomerID = '" + answer + "';";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aCustomerId = (string)aReader["CustomerID"];
                aCompanyName = (string)aReader["CompanyName"];
                aContactName = (string)aReader["ContactName"];
                aContactTitle = (string)aReader["ContactTitle"];
                aAddress = (string)aReader["Address"];
                aCity = (string)aReader["City"];
                aRegion = Convert.ToString(aReader["Region"]) ?? "n\a";
                aPostalCode = Convert.ToString(aReader["PostalCode"]) ?? "n\a";
                aCountry = (string)aReader["Country"];
                aPhone = (string)aReader["Phone"];
                aFax = Convert.ToString(aReader["Fax"]) ?? "n\a";

                Customer aCustomer = new Customer(aCustomerId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion,
                aPostalCode, aCountry, aPhone, aFax);
                aCustomerList.Add(aCustomer);
            }
            //  Close Connection
            aConnection.Close();
            return aCustomerList;
        }

        //  Customer Ascending                      -       Customer         -   3 - 0 - 1              -   DONE
        public List<Customer> GetCustomerOrderByAscending(string orderBy)
        {
            string aCustomerId = "n/a";                  //CustomerID
            string aCompanyName = "n/a";
            string aContactName = "n/a";
            string aContactTitle = "n/a";
            string aAddress = "n/a";
            string aCity = "n/a";
            string aRegion = "n/a";
            string aPostalCode = "n/a";
            string aCountry = "n/a";
            string aPhone = "n/a";
            string aFax = "n/a";
            //List<Customer> aList = new List<Customer>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, " +
                "PostalCode, Country, Phone, Fax FROM Customers ORDER BY CustomerID ASC;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aCustomerId = (string)aReader["CustomerID"];
                aCompanyName = (string)aReader["CompanyName"];
                aContactName = (string)aReader["ContactName"];
                aContactTitle = (string)aReader["ContactTitle"];
                aAddress = (string)aReader["Address"];
                aCity = (string)aReader["City"];
                aRegion = Convert.ToString(aReader["Region"]) ?? "n\a";
                aPostalCode = Convert.ToString(aReader["PostalCode"]) ?? "n\a";
                aCountry = (string)aReader["Country"];
                aPhone = (string)aReader["Phone"];
                aFax = Convert.ToString(aReader["Fax"]) ?? "n\a";

                Customer aCustomer = new Customer(aCustomerId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion,
                aPostalCode, aCountry, aPhone, aFax);
                aCustomerList.Add(aCustomer);
            }
            //  Close Connection
            aConnection.Close();
            return aCustomerList;
        }

        //  Customer Descending                     -       Customer         -   3 - 0 - 2              -   DONE
        public List<Customer> GetCustomerOrderByDescending(string orderBy)
        {
            string aCustomerId = "n/a";                  //CustomerID
            string aCompanyName = "n/a";
            string aContactName = "n/a";
            string aContactTitle = "n/a";
            string aAddress = "n/a";
            string aCity = "n/a";
            string aRegion = "n/a";
            string aPostalCode = "n/a";
            string aCountry = "n/a";
            string aPhone = "n/a";
            string aFax = "n/a";
            //List<Customer> aList = new List<Customer>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, " +
                "PostalCode, Country, Phone, Fax FROM Customers ORDER BY CustomerID DESC;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aCustomerId = (string)aReader["CustomerID"];
                aCompanyName = (string)aReader["CompanyName"];
                aContactName = (string)aReader["ContactName"];
                aContactTitle = (string)aReader["ContactTitle"];
                aAddress = (string)aReader["Address"];
                aCity = (string)aReader["City"];
                aRegion = Convert.ToString(aReader["Region"]) ?? "n\a";
                aPostalCode = Convert.ToString(aReader["PostalCode"]) ?? "n\a";
                aCountry = (string)aReader["Country"];
                aPhone = (string)aReader["Phone"];
                aFax = Convert.ToString(aReader["Fax"]) ?? "n\a";

                Customer aCustomer = new Customer(aCustomerId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion,
                aPostalCode, aCountry, aPhone, aFax);
                aCustomerList.Add(aCustomer);
            }
            //  Close Connection
            aConnection.Close();
            return aCustomerList;
        }

        //  Employee SQL                            -       Employee         -   4                      -   DONE
        public List<Employee> GetEmployeeOrder(string answer)
        {
            int aEmployeeId = -1;         //Employee ID
            string aLastName = "n/a";
            string aFirstName = "n/a";
            string aTitle = "n/a";
            string aTitleOfCourtesy = "n/a";
            string aBirthDate = "n/a";
            string aHireDate = "n/a";
            string aAddress = "n/a";
            string aCity = "n/a";
            string aRegion = "n/a";
            string aPostalCode = "n/a";
            string aCountry = "n/a";
            string aHomePhone = "n/a";
            string aExtension = "n/a";
            string aPhoto = "n/a";
            string aNotes = "n/a";
            int aReportsTo = -1;
            //List<Employee> aList = new List<Employee>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, " +
                    "HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, " +
                    "ReportsTo FROM Employees WHERE EmployeeID = " + answer+ ";";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aEmployeeId = (int)aReader["EmployeeID"];
                aLastName = (string)aReader["LastName"];
                aFirstName = (string)aReader["FirstName"];
                aTitle = (string)aReader["Title"];
                aTitleOfCourtesy = (string)aReader["TitleOfCourtesy"];
                aBirthDate = Convert.ToString(aReader["BirthDate"]);
                aHireDate = Convert.ToString(aReader["HireDate"]);
                aAddress = (string)aReader["Address"];
                aCity = (string)aReader["City"];
                aRegion = Convert.ToString(aReader["Region"]) ?? "n\a";
                aPostalCode = Convert.ToString(aReader["PostalCode"]) ?? "n\a";
                aCountry = (string)aReader["Country"];
                aHomePhone = (string)aReader["HomePhone"];
                aExtension = Convert.ToString(aReader["Extension"]) ?? "n\a";
                aPhoto = (string)aReader["Photo"];
                aNotes = (string)aReader["Notes"];
                //aReportsTo = (int?)aReader["ReportsTo"] ?? -1;
                aReportsTo = aReader["ReportsTo"] as int? ?? 0;

                Employee aEmployee = new Employee(aEmployeeId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate,
                    aHireDate, aAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, aExtension, aPhoto, aNotes,
                    aReportsTo);
                aEmployeeList.Add(aEmployee);
            }
            //  Close Connection
            aConnection.Close();
            return aEmployeeList;
        }

        //  Employee Ascending                      -       Employee         -   4 - 0 - 1              -   DONE
        public List<Employee> GetEmployeeOrderByAscending(string orderBy)
        {                       
            int aEmployeeId = -1;         //Employee ID
            string aLastName = "n/a";
            string aFirstName = "n/a";
            string aTitle = "n/a";
            string aTitleOfCourtesy = "n/a";
            string aBirthDate = "n/a";
            string aHireDate = "n/a";
            string aAddress = "n/a";
            string aCity = "n/a";
            string aRegion = "n/a";
            string aPostalCode = "n/a";
            string aCountry = "n/a";
            string aHomePhone = "n/a";
            string aExtension = "n/a";
            string aPhoto = "n/a";
            string aNotes = "n/a";
            int aReportsTo = -1;
            //List<Employee> aList = new List<Employee>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, " +
                    "HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, " +
                    "ReportsTo FROM Employees ORDER BY EmployeeID ASC;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aEmployeeId = (int)aReader["EmployeeID"];
                aLastName = (string)aReader["LastName"];
                aFirstName = (string)aReader["FirstName"];
                aTitle = (string)aReader["Title"];
                aTitleOfCourtesy = (string)aReader["TitleOfCourtesy"];
                aBirthDate = Convert.ToString(aReader["BirthDate"]);
                aHireDate = Convert.ToString(aReader["HireDate"]);
                aAddress = (string)aReader["Address"];
                aCity = (string)aReader["City"];
                aRegion = Convert.ToString(aReader["Region"]) ?? "n\a";
                aPostalCode = Convert.ToString(aReader["PostalCode"]) ?? "n\a";
                aCountry = (string)aReader["Country"];
                aHomePhone = (string)aReader["HomePhone"];
                aExtension = Convert.ToString(aReader["Extension"]) ?? "n\a";
                aPhoto = (string)aReader["Photo"];
                aNotes = (string)aReader["Notes"];
                aReportsTo = aReader["ReportsTo"] as int? ?? 0;

                Employee aEmployee = new Employee(aEmployeeId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate,
                    aHireDate, aAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, aExtension, aPhoto, aNotes,
                    aReportsTo);
                aEmployeeList.Add(aEmployee);
            }
            //  Close Connection
            aConnection.Close();
            return aEmployeeList;
        }

        //  Employee Descending                     -       Employee         -   4 - 0 - 2              -   DONE
        public List<Employee> GetEmployeeOrderByDescending(string orderBy)
        {                       //GetEmployeeOrderByDescending
            int aEmployeeId = -1;         //Employee ID
            string aLastName = "n/a";
            string aFirstName = "n/a";
            string aTitle = "n/a";
            string aTitleOfCourtesy = "n/a";
            string aBirthDate = "n/a";
            string aHireDate = "n/a";
            string aAddress = "n/a";
            string aCity = "n/a";
            string aRegion = "n/a";
            string aPostalCode = "n/a";
            string aCountry = "n/a";
            string aHomePhone = "n/a";
            string aExtension = "n/a";
            string aPhoto = "n/a";
            string aNotes = "n/a";
            int aReportsTo = -1;
            //List<Employee> aList = new List<Employee>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, " +
                    "HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, " +
                    "ReportsTo FROM Employees ORDER BY EmployeeID DESC;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aEmployeeId = (int)aReader["EmployeeID"];
                aLastName = (string)aReader["LastName"];
                aFirstName = (string)aReader["FirstName"];
                aTitle = (string)aReader["Title"];
                aTitleOfCourtesy = (string)aReader["TitleOfCourtesy"];
                aBirthDate = Convert.ToString(aReader["BirthDate"]);
                aHireDate = Convert.ToString(aReader["HireDate"]);
                aAddress = (string)aReader["Address"];
                aCity = (string)aReader["City"];
                aRegion = Convert.ToString(aReader["Region"]) ?? "n\a";
                aPostalCode = Convert.ToString(aReader["PostalCode"]) ?? "n\a";
                aCountry = (string)aReader["Country"];
                aHomePhone = (string)aReader["HomePhone"];
                aExtension = Convert.ToString(aReader["Extension"]) ?? "n\a";
                aPhoto = (string)aReader["Photo"];
                aNotes = (string)aReader["Notes"];
                aReportsTo = aReader["ReportsTo"] as int? ?? 0;

                Employee aEmployee = new Employee(aEmployeeId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate,
                    aHireDate, aAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, aExtension, aPhoto, aNotes,
                    aReportsTo);
                aEmployeeList.Add(aEmployee);
            }
            //  Close Connection
            aConnection.Close();
            return aEmployeeList;
        }

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
        public List<Order_Detail> GetOrderDetailOrder(string answer)
        {
            int orderId = -1;          //  Order Number
            string aProductId = "n/a";
            string aCustomerTitle = "n/a";
            string aCustomerName = "n/a";
            string aEmployeeTitleCourtesy = "n/a";
            string aEmployeeFirstName = "n/a";
            string aEmployeeLastName = "n/a";
            string aEmployeeTitle = "n/a";
            double aUnitPrice = 0;
            int aQuantity = -1;
            string aDiscount = "n/a";

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
                "ON Products.ProductID = [Order Details].ProductID " +
            "WHERE [Order Details].OrderID = " + answer + " " +
            "ORDER BY [Order Details].OrderID;";


            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                orderId = (int)aReader["OrderID"];
                aProductId = (string)(aReader["ProductName"]);
                aCustomerTitle = (string)(aReader["ContactTitle"]);
                aCustomerName = (string)(aReader["ContactName"]);
                aEmployeeTitleCourtesy = (string)(aReader["TitleOfCourtesy"]);
                aEmployeeFirstName = (string)(aReader["FirstName"]);
                aEmployeeLastName = (string)(aReader["LastName"]);
                aEmployeeTitle = (string)(aReader["Title"]);
                aUnitPrice = Convert.ToDouble(aReader["UnitPrice"]);
                aQuantity = Convert.ToInt32(aReader["Quantity"]);
                aDiscount = Convert.ToString(Convert.ToDouble(aReader["Discount"]));


                Order_Detail aOrderDetails = new Order_Detail(orderId, aProductId, aCustomerTitle, aCustomerName, aEmployeeTitleCourtesy,
                aEmployeeFirstName, aEmployeeLastName, aEmployeeTitle, aUnitPrice, aQuantity, aDiscount);
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
            string aCustomerTitle = "n/a";
            string aCustomerName = "n/a";
            string aEmployeeTitleCourtesy = "n/a";
            string aEmployeeFirstName = "n/a";
            string aEmployeeLastName = "n/a";
            string aEmployeeTitle = "n/a";
            double aUnitPrice = 0;
            int aQuantity = -1;
            string aDiscount = "n/a";

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            //  aCommand.CommandText = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details];";
            aCommand.CommandText = "SELECT [Order Details].OrderID, Products.ProductName, Customers.ContactTitle, Customers.ContactName, " +
            "Employees.TitleOfCourtesy, Employees.FirstName, Employees.LastName, Employees.Title, [Order Details].UnitPrice, " +
            "[Order Details].Quantity, [Order Details].Discount " +
            "FROM Products INNER JOIN ((Employees INNER JOIN (Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) " +
                "ON Employees.EmployeeID = Orders.EmployeeID) INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) " +
                "ON Products.ProductID = [Order Details].ProductID " +
            "ORDER BY [Order Details].OrderID;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();
            // 
            while(aReader.Read())
            {
                orderId = (int)aReader["OrderID"];
                aProductId = (string)(aReader["ProductName"]);
                aCustomerTitle = (string)(aReader["ContactTitle"]);
                aCustomerName = (string)(aReader["ContactName"]);
                aEmployeeTitleCourtesy = (string)(aReader["TitleOfCourtesy"]);
                aEmployeeFirstName = (string)(aReader["FirstName"]);
                aEmployeeLastName = (string)(aReader["LastName"]);
                aEmployeeTitle = (string)(aReader["Title"]);
                aUnitPrice = Convert.ToDouble(aReader["UnitPrice"]);
                aQuantity = Convert.ToInt32(aReader["Quantity"]);
                aDiscount = Convert.ToString(Convert.ToDouble(aReader["Discount"]));


                Order_Detail aOrderDetails = new Order_Detail(orderId, aProductId, aCustomerTitle, aCustomerName, aEmployeeTitleCourtesy,
                aEmployeeFirstName, aEmployeeLastName, aEmployeeTitle, aUnitPrice, aQuantity, aDiscount);
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
            string aCustomerTitle = "n/a";
            string aCustomerName = "n/a";
            string aEmployeeTitleCourtesy = "n/a";
            string aEmployeeFirstName = "n/a";
            string aEmployeeLastName = "n/a";
            string aEmployeeTitle = "n/a";
            double aUnitPrice = 0;
            int aQuantity = -1;
            string aDiscount = "n/a";

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
                "ON Products.ProductID = [Order Details].ProductID " +
            "ORDER BY [Order Details].OrderID DESC;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                orderId = (int)aReader["OrderID"];
                aProductId = (string)(aReader["ProductName"]);
                aCustomerTitle = (string)(aReader["ContactTitle"]);
                aCustomerName = (string)(aReader["ContactName"]);
                aEmployeeTitleCourtesy = (string)(aReader["TitleOfCourtesy"]);
                aEmployeeFirstName = (string)(aReader["FirstName"]);
                aEmployeeLastName = (string)(aReader["LastName"]);
                aEmployeeTitle = (string)(aReader["Title"]);
                aUnitPrice = Convert.ToDouble(aReader["UnitPrice"]);
                aQuantity = Convert.ToInt32(aReader["Quantity"]);
                aDiscount = Convert.ToString(Convert.ToDouble(aReader["Discount"]));


                Order_Detail aOrderDetails = new Order_Detail(orderId, aProductId, aCustomerTitle, aCustomerName, aEmployeeTitleCourtesy,
                aEmployeeFirstName, aEmployeeLastName, aEmployeeTitle, aUnitPrice, aQuantity, aDiscount);
                aOrder_DetailList.Add(aOrderDetails);
            }
            //  Close Connection
            aConnection.Close();
            return aOrder_DetailList;
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
        public List<Order> GetOrderOrder(string answer)
        {
            int aOrderId = -1;              //  Order ID
            string aCustomerId = "n/a";
            int aEmployeeId = -1;
            string aOrderDate = "n/a";
            string aRequiredDate = "n/a";
            string aShippedDate = "n/a";
            int aShipVia = -1;
            double aFreight = 0;
            string aShipName = "n/a";
            string aShipAddress = "n/a";
            string aShipCity = "n/a";
            string aShipRegion = "n/a";
            string aShipPostalCode = "n/a";
            string aShipCountry = "n/a";
            //List<Order> aList = new List<Order>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, " +
                "Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM Orders WHERE OrderID = " + answer + ";";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aOrderId = (int)aReader["OrderID"];
                aCustomerId = (string)aReader["CustomerID"];
                aEmployeeId = Convert.ToInt32(aReader["EmployeeID"]);
                aOrderDate = Convert.ToString(aReader["OrderDate"]);
                aRequiredDate = Convert.ToString(aReader["RequiredDate"]);
                aShippedDate = Convert.ToString(aReader["ShippedDate"]) ?? "n/a";
                aShipVia = Convert.ToInt32(aReader["ShipVia"]);
                aFreight = Convert.ToDouble(aReader["Freight"]);
                aShipName = (string)aReader["ShipName"];
                aShipAddress = (string)aReader["ShipAddress"];
                aShipCity = (string)aReader["ShipCity"];
                aShipRegion = Convert.ToString(aReader["ShipRegion"]) ?? "n/a";
                aShipPostalCode = (string)aReader["ShipPostalCode"] ?? "n/a";
                aShipCountry = (string)aReader["ShipCountry"];

                Order aOrder = new Order(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia,
                aFreight, aShipName, aShipAddress, aShipCity, aShipRegion, aShipPostalCode, aShipCountry);
                aOrderList.Add(aOrder);
            }
            //  Close Connection
            aConnection.Close();
            return aOrderList;
        }

        //  Order File Ascending                    -       Order            -   6 - 0 - 1              -   DONE
        public List<Order> GetOrderOrderByAscending(string orderBy)
        {
            int aOrderId = -1;              //  Order ID
            int aEmployeeId = -1;
            int aShipVia = -1;
            double aFreight = 0;
            string aCustomerId = "n/a";
            string aOrderDate = "n/a";
            string aRequiredDate = "n/a";
            string aShippedDate = "n/a";
            string aShipName = "n/a";
            string aShipAddress = "n/a";
            string aShipCity = "n/a";
            string aShipRegion = "n/a";
            string aShipPostalCode = "n/a";
            string aShipCountry = "n/a";            
            //List<Order> aList = new List<Order>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, " +
                "Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM Orders ORDER BY OrderID ASC;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aOrderId = (int)aReader["OrderID"];
                aCustomerId = (string)aReader["CustomerID"];
                aEmployeeId = Convert.ToInt32(aReader["EmployeeID"]);
                aOrderDate = Convert.ToString(aReader["OrderDate"]);
                aRequiredDate = Convert.ToString(aReader["RequiredDate"]);
                aShippedDate = Convert.ToString(aReader["ShippedDate"]) ?? "n/a";
                aShipVia = Convert.ToInt32(aReader["ShipVia"]);
                aFreight = Convert.ToDouble(aReader["Freight"]);
                aShipName = (string)aReader["ShipName"];
                aShipAddress = (string)aReader["ShipAddress"];
                aShipCity = (string)aReader["ShipCity"];
                aShipRegion = Convert.ToString(aReader["ShipRegion"]) ?? "n/a";
                aShipPostalCode = Convert.ToString(aReader["ShipPostalCode"]) ?? "n/a";
                aShipCountry = (string)aReader["ShipCountry"];

                Order aOrder = new Order(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, 
                aFreight, aShipName, aShipAddress, aShipCity, aShipRegion, aShipPostalCode, aShipCountry);
                aOrderList.Add(aOrder);
            }
            //  Close Connection
            aConnection.Close();
            return aOrderList;
        }

        //  Order File Descending                   -       Order            -   6 - 0 - 2              -   DONE
        public List<Order> GetOrderOrderByDescending(string orderBy)
        {
            int aOrderId = -1;              //  Order ID
            int aEmployeeId = -1;
            string aCustomerId = "n/a";
            string aOrderDate = "n/a";
            string aRequiredDate = "n/a";
            string aShippedDate = "n/a";
            int aShipVia = -1;
            double aFreight = 0;
            string aShipName = "n/a";
            string aShipAddress = "n/a";
            string aShipCity = "n/a";
            string aShipRegion = "n/a";
            string aShipPostalCode = "n/a";
            string aShipCountry = "n/a";
            //List<Order> aList = new List<Order>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, " +
                "Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM Orders ORDER BY OrderID DESC;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aOrderId = (int)aReader["OrderID"];
                aCustomerId = (string)aReader["CustomerID"];
                aEmployeeId = Convert.ToInt32(aReader["EmployeeID"]);
                aOrderDate = (string)aReader["OrderDate"];
                aRequiredDate = (string)aReader["RequiredDate"];
                aShippedDate = (string)aReader["ShippedDate"] ?? "n/a";
                aShipVia = Convert.ToInt32(aReader["ShipVia"]);
                aFreight = Convert.ToDouble(aReader["Freight"]);
                aShipName = (string)aReader["ShipName"];
                aShipAddress = (string)aReader["ShipAddress"];
                aShipCity = (string)aReader["ShipCity"];
                aShipRegion = (string)aReader["ShipRegion"] ?? "n/a";
                aShipPostalCode = (string)aReader["ShipPostalCode"] ?? "n/a";
                aShipCountry = (string)aReader["ShipCountry"];

                Order aOrder = new Order(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia,
                aFreight, aShipName, aShipAddress, aShipCity, aShipRegion, aShipPostalCode, aShipCountry);
                aOrderList.Add(aOrder);
            }
            //  Close Connection
            aConnection.Close();
            return aOrderList;
        }

        //  Product File                            -       Product          -   7                      -   DONE
        public List<Product> GetProductOrder(string answer)
        {
            int aProductId = -1;              //  Product ID
            string aProductName = "n/a";
            string aSupplierId = "n/a";
            string aCategoryId = "n/a";
            string aQuantityPerUnit = "n/a";
            double aUnitPrice = 1000000000;
            int aUnitsInStock = -1;
            int aUnitsOnOrder = -1;
            int aReorderLevel = -1;
            bool aDiscontinued = false;
            //List<Product> aList = new List<Product>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT Products.ProductID, Products.ProductName, Suppliers.CompanyName, Categories.CategoryName, " + 
                "Products.QuantityPerUnit, Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, " + 
                "Products.Discontinued " + 
                "FROM ((Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN Suppliers ON " + 
                "Products.SupplierID = Suppliers.SupplierID) " + 
                "WHERE Products.ProductID = " + answer + ";";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aProductId = (int)aReader["ProductID"];
                aProductName = (string)aReader["ProductName"];
                aSupplierId = (string)aReader["CompanyName"];
                aCategoryId = (string)aReader["CategoryName"];
                aQuantityPerUnit = (string)aReader["QuantityPerUnit"];
                aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                aUnitsInStock = (short)aReader["UnitsInStock"];
                aUnitsOnOrder = (short)aReader["UnitsOnOrder"];
                aReorderLevel = (short)aReader["ReorderLevel"];
                bool isDiscontinued = (bool)aReader["DisContinued"];

                Product aProduct = new Product(aProductId, aProductName, aSupplierId, aCategoryId, aQuantityPerUnit, aUnitPrice, aUnitsInStock,
                    aUnitsOnOrder, aReorderLevel, aDiscontinued);

                aProductList.Add(aProduct);
            }
            //  Close Connection
            aConnection.Close();
            return aProductList;
        }

        //  Product Ascending                       -       Product          -   7 - 1 - 0 - 1          -   DONE
        public List<Product> GetProductOrderByAscending(string orderBy)
        {
            int aProductId = -1;              //  Product ID
            string aProductName = "n/a";
            string aSupplierId = "n/a";
            string aCategoryId = "n/a";
            string aQuantityPerUnit = "n/a";
            double aUnitPrice = 1000000000;
            int aUnitsInStock = -1;
            int aUnitsOnOrder = -1;
            int aReorderLevel = -1;
            bool aDiscontinued = false;
            //List<Product> aList = new List<Product>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT Products.ProductID, Products.ProductName, Suppliers.CompanyName, Categories.CategoryName, " + 
                "Products.QuantityPerUnit, Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, " + 
                "Products.Discontinued " +
                "FROM ((Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN Suppliers ON " + 
                "Products.SupplierID = Suppliers.SupplierID)" +
                "ORDER BY Products.ProductID ASC;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();
            while(aReader.Read())
            {
                aProductId = (int)aReader["ProductID"];
                aProductName = (string)aReader["ProductName"];
                aSupplierId = (string)aReader["CompanyName"];
                aCategoryId = (string)aReader["CategoryName"];
                aQuantityPerUnit = (string)aReader["QuantityPerUnit"];
                aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                aUnitsInStock = (short)aReader["UnitsInStock"];
                aUnitsOnOrder = (short)aReader["UnitsOnOrder"];
                aReorderLevel = (short)aReader["ReorderLevel"];
                bool isDiscontinued = (bool)aReader["DisContinued"];

                Product aProduct = new Product(aProductId, aProductName, aSupplierId, aCategoryId, aQuantityPerUnit, aUnitPrice, aUnitsInStock,
                    aUnitsOnOrder, aReorderLevel, aDiscontinued);

                aProductList.Add(aProduct);
            }
            //  Close Connection
            aConnection.Close();
            return aProductList;
        }

        //  Product Descending                      -       Product          -   7 - 1 - 0 - 2          -   DONE
        public List<Product> GetProductOrderByDescending(string orderBy)
        {
            int aProductId = -1;              //  Product ID
            string aProductName = "n/a";
            string aSupplierId = "n/a";
            string aCategoryId = "n/a";
            string aQuantityPerUnit = "n/a";
            double aUnitPrice = 1000000000;
            int aUnitsInStock = -1;
            int aUnitsOnOrder = -1;
            int aReorderLevel = -1;
            bool aDiscontinued = false;
            //List<Product> aList = new List<Product>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT Products.ProductID, Products.ProductName, Suppliers.CompanyName, Categories.CategoryName, " + 
                "Products.QuantityPerUnit, Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, " + 
                "Products.Discontinued " +
                "FROM ((Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN Suppliers ON " + 
                "Products.SupplierID = Suppliers.SupplierID)" +
                "ORDER BY Products.ProductID DESC;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aProductId = (int)aReader["ProductID"];
                aProductName = (string)aReader["ProductName"];
                aSupplierId = (string)aReader["CompanyName"];
                aCategoryId = (string)aReader["CategoryName"];
                aQuantityPerUnit = (string)aReader["QuantityPerUnit"];
                aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                aUnitsInStock = (short)aReader["UnitsInStock"];
                aUnitsOnOrder = (short)aReader["UnitsOnOrder"];
                aReorderLevel = (short)aReader["ReorderLevel"];
                bool isDiscontinued = (bool)aReader["DisContinued"];

                Product aProduct = new Product(aProductId, aProductName, aSupplierId, aCategoryId, aQuantityPerUnit, aUnitPrice, aUnitsInStock,
                    aUnitsOnOrder, aReorderLevel, aDiscontinued);

                aProductList.Add(aProduct);
            }
            //  Close Connection
            aConnection.Close();
            return aProductList;
        }

        //  Product Category                        -       Product          -   7 - 2                  -   DONE
        public List<Product> GetProductCategory(string answer)
        {
            int aProductId = -1;              //  Product ID
            string aProductName = "n/a";
            string aSupplierId = "n/a";
            string aCategoryId = "n/a";
            string aQuantityPerUnit = "n/a";
            double aUnitPrice = 1000000000;
            int aUnitsInStock = -1;
            int aUnitsOnOrder = -1;
            int aReorderLevel = -1;
            bool aDiscontinued = false;
            //List<Product> aList = new List<Product>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT Products.ProductID, Products.ProductName, Suppliers.CompanyName,Categories.CategoryName, " + 
                "Products.QuantityPerUnit, Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, " + 
                 "Products.Discontinued " + 
                "FROM ((Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN Suppliers ON Products.SupplierID " + 
                "= Suppliers.SupplierID) " + 
                "WHERE Products.CategoryID =  " + answer + ";";

            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aProductId = (int)aReader["ProductID"];
                aProductName = (string)aReader["ProductName"];
                aSupplierId = (string)aReader["CompanyName"];
                aCategoryId = (string)aReader["Categoryname"];
                aQuantityPerUnit = (string)aReader["QuantityPerUnit"];
                aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                aUnitsInStock = (short)aReader["UnitsInStock"];
                aUnitsOnOrder = (short)aReader["UnitsOnOrder"];
                aReorderLevel = (short)aReader["ReorderLevel"];
                aDiscontinued = Convert.ToBoolean(Convert.ToInt32(aReader["DisContinued"]));

                Product aProduct = new Product(aProductId, aProductName, aSupplierId, aCategoryId, aQuantityPerUnit, aUnitPrice, aUnitsInStock,
                    aUnitsOnOrder, aReorderLevel, aDiscontinued);

                aProductList.Add(aProduct);
            }
            //  Close Connection
            aConnection.Close();
            return aProductList;
        }

        //  Product Range                           -       Product          -   7 - 3                  -   DONE
        public List<Product> GetProductRange(string answerMin, string answerMax)
        {
            int aProductId = -1;              //  Product ID
            string aProductName = "n/a";
            string aSupplierId = "n/a";
            string aCategoryId = "n/a";
            string aQuantityPerUnit = "n/a";
            double aUnitPrice = 1000000000;
            int aUnitsInStock = -1;
            int aUnitsOnOrder = -1;
            int aReorderLevel = -1;
            bool aDiscontinued = false;
            //List<Product> aList = new List<Product>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT Products.ProductID, Products.ProductName, Suppliers.CompanyName, Categories.CategoryName, Products.QuantityPerUnit, " + 
                "Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, Products.Discontinued " +
                "FROM ((Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN Suppliers ON Products.SupplierID = " + 
                "Suppliers.SupplierID) " +
                "WHERE Products.UnitPrice >= " + answerMin + " AND Products.UnitPrice <= " + answerMax + " " +
                "ORDER BY Products.UnitPrice, Products.ProductName;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();
            //Suppliers.CompanyName, Categories.CategoryName,
            while(aReader.Read())
            {
                aProductId = (int)aReader["ProductID"];
                aProductName = (string)aReader["ProductName"];
                aSupplierId = (string)aReader["CompanyName"];
                aCategoryId = (string)aReader["CategoryName"];
                aQuantityPerUnit = (string)aReader["QuantityPerUnit"];
                aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                aUnitsInStock = (short)aReader["UnitsInStock"];
                aUnitsOnOrder = (short)aReader["UnitsOnOrder"];
                aReorderLevel = (short)aReader["ReorderLevel"];
                aDiscontinued = Convert.ToBoolean(Convert.ToInt32(aReader["Discontinued"]));

                Product aProduct = new Product(aProductId, aProductName, aSupplierId, aCategoryId, aQuantityPerUnit, aUnitPrice, aUnitsInStock,
                    aUnitsOnOrder, aReorderLevel, aDiscontinued);

                aProductList.Add(aProduct);
            }
            //  Close Connection
            aConnection.Close();
            return aProductList;
        }

        //  Shipper File                            -       Shipper          -   8                      -   DONE
        public List<Shipper> GetShipperOrder(string answer)
        {
            int aShipperId = -1;          //  Shipper Number
            string aCompanyName = "n/a";
            string aPhone = "n/a";
            //List<Shipper> aList = new List<Shipper>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT ShipperID, CompanyName, Phone FROM Shippers WHERE ShipperID = " + answer  + ";";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aShipperId = Convert.ToInt32(aReader["ShipperID"]);
                aCompanyName = (string)aReader["CompanyName"];
                aPhone = (string)aReader["Phone"];

                Shipper aShippers = new Shipper(aShipperId, aCompanyName, aPhone);
                aShipperList.Add(aShippers);
            }
            //  Close Connection
            aConnection.Close();
            return aShipperList;
        }

        //  Shipper Ascending                       -       Shipper          -   8 - 0 - 1              -   DONE
        public List<Shipper> GetShipperOrderByAscending(string orderBy)
        {
            int aShipperId = -1;          //  Shipper Number
            string aCompanyName = "n/a";
            string aPhone = "n/a";
            //List<Shipper> aList = new List<Shipper>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT ShipperID, CompanyName, Phone FROM Shippers ORDER BY ShipperID ASC;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aShipperId = Convert.ToInt32(aReader["ShipperID"]);
                aCompanyName = (string)aReader["CompanyName"];
                aPhone = (string)aReader["Phone"];

                Shipper aShippers = new Shipper(aShipperId, aCompanyName, aPhone);
                aShipperList.Add(aShippers);
            }
            //  Close Connection
            aConnection.Close();
            return aShipperList;
        }

        //  Shipper Descending                      -       Shipper          -   8 - 0 - 2              -   DONE
        public List<Shipper> GetShipperOrderByDescending(string orderBy)
        {
            int aShipperId = -1;          //  Shipper Number
            string aCompanyName = "n/a";
            string aPhone = "n/a";
            //List<Shipper> aList = new List<Shipper>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT ShipperID, CompanyName, Phone FROM Shippers ORDER BY ShipperID DESC;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aShipperId = Convert.ToInt32(aReader["ShipperID"]);
                aCompanyName = (string)aReader["CompanyName"];
                aPhone = (string)aReader["Phone"];

                Shipper aShippers = new Shipper(aShipperId, aCompanyName, aPhone);
                aShipperList.Add(aShippers);
            }
            //  Close Connection
            aConnection.Close();
            return aShipperList;
        }

        //  Supplier File                           -       Supplier         -   9                      -   DONE
        public List<Supplier> GetSupplierOrder(string answer)
        {
            int aSupplierId = -1;              //  Supplier ID
            string aCompanyName = "n/a";
            string aContactName = "n/a";
            string aContactTitle = "n/a";
            string aAddress = "n/a";
            string aCity = "n/a";
            string aRegion = "n/a";
            string aPostalCode = "n/a";
            string aCountry = "n/a";
            string aPhone = "n/a";
            string aFax = "n/a";
            string aHomePage = "n/a";
            //List<Supplier> aList = new List<Supplier>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, " + 
            "Country, Phone, Fax, HomePage FROM Suppliers WHERE SupplierID = " + answer + ";";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aSupplierId = Convert.ToInt32(aReader["SupplierID"]);
                aCompanyName = (string)aReader["CompanyName"];
                aContactName = (string)aReader["ContactName"];
                aContactTitle = (string)aReader["ContactTitle"];
                aAddress = (string)aReader["Address"];
                aCity = (string)aReader["City"];
                aRegion = Convert.ToString(aReader["Region"]) ?? "n/a";
                aPostalCode = (string)aReader["PostalCode"];
                aCountry = (string)aReader["Country"];
                aPhone = (string)aReader["Phone"];
                aFax = Convert.ToString(aReader["Fax"]) ?? "n/a";
                aHomePage = Convert.ToString(aReader["HomePage"]) ?? "n/a";

                Supplier aSupplier = new Supplier(aSupplierId, aCompanyName, aContactName, aContactTitle, aAddress, aCity,
                    aRegion, aPostalCode, aCountry, aPhone, aFax, aHomePage);
                aSupplierList.Add(aSupplier);
            }
            //  Close Connection
            aConnection.Close();
            return aSupplierList;
        }

        //  Supplier Ascending                      -       Supplier         -   9 - 0 - 1              -   DONE
        public List<Supplier> GetSupplierOrderByAscending(string orderBy)
        {
            int aSupplierId = -1;              //  Supplier ID
            string aCompanyName = "n/a";
            string aContactName = "n/a";
            string aContactTitle = "n/a";
            string aAddress = "n/a";
            string aCity = "n/a";
            string aRegion = "n/a";
            string aPostalCode = "n/a";
            string aCountry = "n/a";
            string aPhone = "n/a";
            string aFax = "n/a";
            string aHomePage = "n/a";
            //List<Supplier> aList = new List<Supplier>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, " +
            "Country, Phone, Fax, HomePage FROM Suppliers ORDER BY SupplierID ASC;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aSupplierId = Convert.ToInt32(aReader["SupplierID"]);
                aCompanyName = (string)aReader["CompanyName"];
                aContactName = (string)aReader["ContactName"];
                aContactTitle = (string)aReader["ContactTitle"];
                aAddress = (string)aReader["Address"];
                aCity = (string)aReader["City"];
                aRegion = Convert.ToString(aReader["Region"]) ?? "n/a";
                aPostalCode = (string)aReader["PostalCode"];
                aCountry = (string)aReader["Country"];
                aPhone = (string)aReader["Phone"];
                aFax = Convert.ToString(aReader["Fax"]) ?? "n/a";
                aHomePage = Convert.ToString(aReader["HomePage"]) ?? "n/a";

                Supplier aSupplier = new Supplier(aSupplierId, aCompanyName, aContactName, aContactTitle, aAddress, aCity,
                    aRegion, aPostalCode, aCountry, aPhone, aFax, aHomePage);
                aSupplierList.Add(aSupplier);
            }
            //  Close Connection
            aConnection.Close();
            return aSupplierList;
        }

        //  Supplier Descending                     -       Supplier         -   9 - 0 - 2              -   DONE
        public List<Supplier> GetSupplierOrderByDescending(String orderBy)
        {
            int aSupplierId = -1;              //  Supplier ID
            string aCompanyName = "n/a";
            string aContactName = "n/a";
            string aContactTitle = "n/a";
            string aAddress = "n/a";
            string aCity = "n/a";
            string aRegion = "n/a";
            string aPostalCode = "n/a";
            string aCountry = "n/a";
            string aPhone = "n/a";
            string aFax = "n/a";
            string aHomePage = "n/a";
            //List<Supplier> aList = new List<Supplier>();

            //  Open Connection
            aConnection.Open();
            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            //  Set the SQL Statement
            aCommand.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, " +
            "Country, Phone, Fax, HomePage FROM Suppliers ORDER BY SupplierID DESC;";
            //  Execute Connection Reader
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                aSupplierId = Convert.ToInt32(aReader["SupplierID"]);
                aCompanyName = (string)aReader["CompanyName"];
                aContactName = (string)aReader["ContactName"];
                aContactTitle = (string)aReader["ContactTitle"];
                aAddress = (string)aReader["Address"];
                aCity = (string)aReader["City"];
                aRegion = Convert.ToString(aReader["Region"]) ?? "n/a";
                aPostalCode = (string)aReader["PostalCode"];
                aCountry = (string)aReader["Country"];
                aPhone = (string)aReader["Phone"];
                aFax = Convert.ToString(aReader["Fax"]) ?? "n/a";
                aHomePage = Convert.ToString(aReader["HomePage"]) ?? "n/a";

                Supplier aSupplier = new Supplier(aSupplierId, aCompanyName, aContactName, aContactTitle, aAddress, aCity,
                    aRegion, aPostalCode, aCountry, aPhone, aFax, aHomePage);
                aSupplierList.Add(aSupplier);
            }
            //  Close Connection
            aConnection.Close();
            return aSupplierList;
        }

        /* SQL Category */
        //  Student SQL                             -       Student          -   1                      -   DONE
        public List<Student> GetStudentsOrder(string answer)
        {
            string aStudentId = "n/a";    //  Student ID
            string aFirstName = "n/a";
            string aLastName = "n/a";
            string aMiddleName = "n/a";
            //List<Student> aList = new List<Student>();

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
        
        //  Category SQL                            -       Category         -   2                      -   DONE
        /*public List<Category> GetCategoryOrder(string answer)
        {
            int anId = -1;          //  Category ID
            string aCategoryName = "n/a";
            string aDescription = "n/a";
            List<Category> aList = new List<Category>();

            IEnumerable<XElement> rows = from row in aCategoryFile.Descendants("Category")
                                         where Convert.ToInt32(row.Attribute("CategoryID").Value) == Convert.ToInt32(answer)
                                         select row;

            foreach(var aRow in rows)
            {
                anId = Convert.ToInt32(aRow.Attribute("CategoryID").Value);
                aCategoryName = aRow.Attribute("CategoryName").Value;
                aDescription = aRow.Attribute("Description").Value;

                Category aCategory = new Category(anId, aCategoryName, aDescription);
                aList.Add(aCategory);
            }
            return aList;
        }*/

        //  Customer SQL                            -       Customer         -   3                      -   DONE
        /*public List<Customer> GetCustomerOrder(string answer)
        {
            string anId = "n/a";                  //CustomerID
            string aCompanyName = "n/a";
            string aContactName = "n/a";
            string aContactTitle = "n/a";
            string aAddress = "n/a";
            string aCity = "n/a";
            string aRegion = "n/a";
            string aPostalCode = "n/a";
            string aCountry = "n/a";
            string aPhone = "n/a";
            string aFax = "n/a";
            List<Customer> aList = new List<Customer>();

            IEnumerable<XElement> rows = from row in aCustomerFile.Descendants("Customer")
                                         where row.Attribute("CustomerID").Value.Equals(answer)
                                         select row;

            foreach(var aRow in rows)
            {
                anId = aRow.Attribute("CustomerID").Value;    //  Customer ID
                aCompanyName = aRow.Attribute("CompanyName").Value;
                aContactName = aRow.Attribute("ContactName").Value;
                aContactTitle = aRow.Attribute("ContactTitle").Value;
                aAddress = aRow.Attribute("Address").Value;
                aCity = aRow.Attribute("City").Value;
                aRegion = (string)aRow.Attribute("Region") ?? "n/a";
                aPostalCode = (string)aRow.Attribute("PostalCode") ?? "n/a";
                aCountry = aRow.Attribute("Country").Value;
                aPhone = aRow.Attribute("Phone").Value;
                aFax = (string)aRow.Attribute("Fax") ?? "n/a";
                
                
                Customer aCustomer = new Customer(anId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, 
                aPostalCode, aCountry, aPhone, aFax);                
                aList.Add(aCustomer);
            }
            return aList;
        }*/

        //  Employee SQL                            -       Employee         -   4                      -   DONE
        /*public List<Employee> GetEmployeeOrder(string answer)
        {
            int anId = -1;         //Employee ID
            string aLastName = "n/a";
            string aFirstName = "n/a";
            string aTitle = "n/a";
            string aTitleOfCourtesy = "n/a";
            string aBirthDate = "n/a";
            string aHireDate = "n/a";
            string aAddress = "n/a";
            string aCity = "n/a";
            string aRegion = "n/a";
            string aPostalCode = "n/a";
            string aCountry = "n/a";
            string aHomePhone = "n/a";
            string aExtension = "n/a";
            string aPhoto = "n/a";
            string aNotes = "n/a";
            int aReportsTo = -1;
            List<Employee> aList = new List<Employee>();

            IEnumerable<XElement> rows = from row in aEmployeesFile.Descendants("Employee")
                                         where Convert.ToInt32(row.Attribute("EmployeeID").Value) == Convert.ToInt32(answer)
                                         select row;

            foreach(var aRow in rows)
            {
                anId = Convert.ToInt32(aRow.Attribute("EmployeeID").Value); //  fix or search?
                aLastName = aRow.Attribute("LastName").Value;
                aFirstName = aRow.Attribute("FirstName").Value;
                aTitle = aRow.Attribute("Title").Value;
                aTitleOfCourtesy = aRow.Attribute("TitleOfCourtesy").Value;
                aBirthDate = aRow.Attribute("BirthDate").Value;
                aHireDate = aRow.Attribute("HireDate").Value;
                aAddress = aRow.Attribute("Address").Value;
                aCity = aRow.Attribute("City").Value;
                aRegion = (string)aRow.Attribute("Region") ?? "n/a";
                aPostalCode = aRow.Attribute("PostalCode").Value;
                aCountry = aRow.Attribute("Country").Value;
                aHomePhone = aRow.Attribute("HomePhone").Value;
                aExtension = aRow.Attribute("Extension").Value;
                aPhoto = aRow.Attribute("Photo").Value;
                aNotes = aRow.Attribute("Notes").Value;
                aReportsTo = (int?)aRow.Attribute("ReportsTo") ?? -1;

                Employee aEmployee = new Employee(anId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate,
                    aHireDate, aAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, aExtension, aPhoto, aNotes, 
                    aReportsTo);                
                aList.Add(aEmployee);
            }
            return aList;
        }*/

        //  Order Detail File                       -       Order Detail     -   5                      -   DONE    -   BREAK IT DOWN EVEN MORE NOW!
        /*public List<Order_Detail> GetOrderDetailOrder(string answer)
        {
            int anId = -1;          //  Order Number
            int aProductId = -1;
            double aUnitPrice = 0;
            int aQuantity = -1;
            string aDiscount = "n/a";
            List<Order_Detail> aList = new List<Order_Detail>();

            IEnumerable<XElement> rows = from row in aOrderDetailsFile.Descendants("OrderDetail")
                                         where Convert.ToInt32(row.Attribute("OrderID").Value)  == Convert.ToInt32(answer)
                                         select row;

            foreach(var aRow in rows)
            {
                anId = Convert.ToInt32(aRow.Attribute("OrderID").Value);
                aProductId = Convert.ToInt32(aRow.Attribute("ProductID").Value);
                aUnitPrice = Convert.ToDouble(aRow.Attribute("UnitPrice").Value);
                aQuantity = Convert.ToInt32(aRow.Attribute("Quantity").Value);
                aDiscount = aRow.Attribute("Discount").Value;

                Order_Detail aOrderDetails = new Order_Detail(anId, aProductId, aUnitPrice, aQuantity, aDiscount);
                aList.Add(aOrderDetails);
            }
            return aList;
        }*/

        //  Order File                              -       Order            -   6                      -   DONE
        /*public List<Order> GetOrderOrder(string answer)
        {
            int anId = -1;              //  Order ID
            string aCustomerId = "n/a";
            int aEmployeeId = -1;
            string aOrderDate = "n/a";
            string aRequiredDate = "n/a";
            string aShippedDate = "n/a";
            int aShipVia = -1;
            double aFreight = 0;
            string aShipName = "n/a";
            string aShipAddress = "n/a";
            string aShipCity = "n/a";
            string aShipRegion = "n/a";
            string aShipPostalCode = "n/a";
            string aShipCountry = "n/a";

            List<Order> aList = new List<Order>();

            IEnumerable<XElement> rows = from row in aOrderFile.Descendants("Order")
                                         where Convert.ToInt32(row.Attribute("OrderID").Value) == Convert.ToInt32(answer)
                                         select row;

            foreach(var aRow in rows)
            {
                anId = Convert.ToInt32(aRow.Attribute("OrderID").Value);
                aCustomerId = aRow.Attribute("CustomerID").Value;
                aEmployeeId = Convert.ToInt32(aRow.Attribute("EmployeeID").Value);
                aOrderDate = aRow.Attribute("OrderDate").Value;
                aRequiredDate = aRow.Attribute("RequiredDate").Value;
                aShippedDate = (string)aRow.Attribute("ShippedDate") ?? "n/a";
                aShipVia = Convert.ToInt32(aRow.Attribute("ShipVia").Value);
                aFreight = Convert.ToDouble(aRow.Attribute("Freight").Value);
                aShipName = aRow.Attribute("ShipName").Value;
                aShipAddress = aRow.Attribute("ShipAddress").Value;
                aShipCity = aRow.Attribute("ShipCity").Value;
                aShipRegion = (string)aRow.Attribute("ShipRegion") ?? "n/a";
                aShipPostalCode = (string)aRow.Attribute("ShipPostalCode") ?? "n/a";
                aShipCountry = aRow.Attribute("ShipCountry").Value;

                Order aOrder = new Order(anId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight,
                    aShipName, aShipAddress, aShipCity, aShipRegion, aShipPostalCode, aShipCountry);
                aList.Add(aOrder);
            }
            return aList;
        }*/

        //  Product File                            -       Product          -   7                      -   DONE
        /*public List<Product> GetProductOrder(string answer)
        {
            int anId = -1;              //  Product ID
            string aProductName = "n/a";
            int aSupplierId = -1;
            int aCategoryId = -1;
            string aQuantityPerUnit = "n/a";
            double aUnitPrice = 1000000000;
            int aUnitsInStock = -1;
            int aUnitsOnOrder = -1;
            int aReorderLevel = -1;
            bool aDiscontinued = false;
            List<Product> aList = new List<Product>();

            IEnumerable<XElement> rows = from row in aProductsFile.Descendants("Product")
                                         where Convert.ToInt32(row.Attribute("ProductID").Value) == Convert.ToInt32(answer)
                                         select row;

            foreach(var aRow in rows)
            {
                anId = Convert.ToInt32(aRow.Attribute("ProductID").Value);
                aProductName = aRow.Attribute("ProductName").Value;
                aSupplierId = Convert.ToInt32(aRow.Attribute("SupplierID").Value);
                aCategoryId = Convert.ToInt32(aRow.Attribute("CategoryID").Value);
                aQuantityPerUnit = aRow.Attribute("QuantityPerUnit").Value;
                aUnitPrice = Convert.ToDouble(aRow.Attribute("UnitPrice").Value);
                aUnitsInStock = Convert.ToInt32(aRow.Attribute("UnitsInStock").Value);
                aUnitsOnOrder = Convert.ToInt32(aRow.Attribute("UnitsOnOrder").Value);
                aReorderLevel = Convert.ToInt32(aRow.Attribute("ReorderLevel").Value);
                aDiscontinued = Convert.ToBoolean(Convert.ToInt32(aRow.Attribute("Discontinued").Value));

                Product aProduct = new Product(anId, aProductName, aSupplierId, aCategoryId, aQuantityPerUnit, aUnitPrice, aUnitsInStock,
                    aUnitsOnOrder, aReorderLevel, aDiscontinued);
                aList.Add(aProduct);
            }
            return aList;
        }*/

        //  Shipper File                            -       Shipper          -   8                      -   DONE
        /*public List<Shipper> GetShipperOrder(string answer)
        {
            int anId = -1;          //  Shipper Number
            string aCompanyName = "n/a";
            string aPhone = "n/a";
            List<Shipper> aList = new List<Shipper>();

            IEnumerable<XElement> rows = from row in aShippersFile.Descendants("Shipper")
                                         where row.Attribute("ShipperID").Value.Equals(answer)
                                         select row;
            foreach(var aRow in rows)
            {
                anId = Convert.ToInt32(aRow.Attribute("ShipperID").Value);
                aCompanyName = aRow.Attribute("CompanyName").Value;
                aPhone = aRow.Attribute("Phone").Value;

                Shipper aShippers = new Shipper(anId, aCompanyName, aPhone);
                aList.Add(aShippers);
            }
            return aList;
        }*/

        //  Supplier File                           -       Supplier         -   9                      -   DONE
        /*public List<Supplier> GetSupplierOrder(string answer)
        {
            int anId = -1;              //  Supplier ID
            string aCompanyName = "n/a";
            string aContactName = "n/a";
            string aContactTitle = "n/a";
            string aAddress = "n/a";
            string aCity = "n/a";
            string aRegion = "n/a";
            string aPostalCode = "n/a";
            string aCountry = "n/a";
            string aPhone = "n/a";
            string aFax = "n/a";
            string aHomePage = "n/a";
            List<Supplier> aList = new List<Supplier>();

            IEnumerable<XElement> rows = from row in aSuppliersFile.Descendants("Supplier")
                                         where row.Attribute("SupplierID").Value.Equals(answer)
                                         select row;
            foreach(var aRow in rows)
            {
                anId = Convert.ToInt32(aRow.Attribute("SupplierID").Value);
                aCompanyName = aRow.Attribute("CompanyName").Value;
                aContactName = aRow.Attribute("ContactName").Value;
                aContactTitle = aRow.Attribute("ContactTitle").Value;
                aAddress = aRow.Attribute("Address").Value;
                aCity = aRow.Attribute("City").Value;
                aRegion = (string)aRow.Attribute("Region") ?? "n/a";
                aPostalCode = aRow.Attribute("PostalCode").Value;
                aCountry = aRow.Attribute("Country").Value;
                aPhone = aRow.Attribute("Phone").Value;
                aFax = (string)aRow.Attribute("Fax") ?? "n/a";
                aHomePage = (string)aRow.Attribute("HomePage") ?? "n/a";

                Supplier aSupplier = new Supplier(anId, aCompanyName, aContactName, aContactTitle, aAddress, aCity,
                    aRegion, aPostalCode, aCountry, aPhone, aFax, aHomePage);
                aList.Add(aSupplier);
            }
            return aList;
        }*/
    }
}
