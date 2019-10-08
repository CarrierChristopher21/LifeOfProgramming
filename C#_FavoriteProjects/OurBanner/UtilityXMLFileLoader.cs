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



namespace OurBanner
{
    public sealed class UtilityXMLFileLoader
    {
        //  Mayflower.xml - aStudentFile
        private XDocument aStudentFile = XDocument.Load(@"C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\OurBanner\Data Loader\Mayflower.xml");
        //  Categories.xml - aCategoryFile
        private XDocument aCategoryFile = XDocument.Load(@"C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\OurBanner\Data Loader\Categories.xml");
        //  Customers.xml - aCustomerFile
        private XDocument aCustomerFile = XDocument.Load(@"C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\OurBanner\Data Loader\Customers.xml");
        //  Employees.xml - aEmployeesFile
        private XDocument aEmployeesFile = XDocument.Load(@"C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\OurBanner\Data Loader\Employees.xml");
        //  OrderDetails.xml - aOrderDetailsFile
        private XDocument aOrderDetailsFile = XDocument.Load(@"C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\OurBanner\Data Loader\OrderDetails.xml");
        //  Orders.xml - aOrderFile
        private XDocument aOrderFile = XDocument.Load(@"C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\OurBanner\Data Loader\Orders.xml");
        //  Products.xml - aProductsFile
        private XDocument aProductsFile = XDocument.Load(@"C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\OurBanner\Data Loader\Products.xml");
        //  Shippers.xml - aShippersFile
        private XDocument aShippersFile = XDocument.Load(@"C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\OurBanner\Data Loader\Shippers.xml");
        //  Suppliers.xml - aSuppliersFile
        private XDocument aSuppliersFile = XDocument.Load(@"C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\OurBanner\Data Loader\Suppliers.xml");

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
            //  This is private which prevents any other code
            //  from creating on.
            //  No code anywhere -- EXCEPT from within
            //  this class -- can create an object
            //  from this class
        }

        /*  Regualr Code ex. Java / C++ */
        //  Student File                            -       Student          -   1 - 1                  -   DONE    -   Java / C / C++
        /*public List<Student> GetStudents(string answer)
        {
            string anId = "n/a";    //  Student ID
            string aFirstName = "n/a";
            string aLastName = "n/a";
            string aMiddleName = "n/a";
            List<Student> aList = new List<Student>();

            IEnumerable<XElement> rows = from row in aStudentFile.Descendants("name")
                                         where row.Attribute("IDNumber").Value.Equals(answer)
                                         select row;

            foreach(var aRow in rows)
            {
                anId = aRow.Attribute("IDNumber").Value;
                aFirstName = aRow.Attribute("FirstName").Value;
                aLastName = aRow.Attribute("LastName").Value;
                aMiddleName = aRow.Attribute("MiddleName").Value;

                Student aStudent = new Student(anId, aFirstName, aLastName, aMiddleName);
                aList.Add(aStudent);
            }
            return aList;
        }*/

        //  Converter Order List    -       In Progress, Not In Use!
        public List<Object> GetStudentsOrderByAscendingTest(string orderBy)
        {
            string anId = "n/a";    //  Student ID
            string aFirstName = "n/a";
            string aLastName = "n/a";
            string aMiddleName = "n/a";
            List<Object> aList = new List<Object>();

            IEnumerable<XElement> rows = from row in aStudentFile.Descendants("name")
                                         orderby Convert.ToInt32(row.Attribute("IDNumber").Value) ascending
                                         select row;

            foreach(var aRow in rows)
            {
                anId = aRow.Attribute("IDNumber").Value;
                aFirstName = aRow.Attribute("FirstName").Value;
                aLastName = aRow.Attribute("LastName").Value;
                aMiddleName = aRow.Attribute("MiddleName").Value;

                Object aStudent = new Student(anId, aFirstName, aLastName, aMiddleName);
                aList.Add(aStudent);
            }
            return aList;
        }

        //  Student Ascending                       -       Student          -   1 - 0 - 1              -   DONE
        public List<Student> GetStudentsOrderByAscending(string orderBy)
        {
            string anId = "n/a";    //  Student ID
            string aFirstName = "n/a";
            string aLastName = "n/a";
            string aMiddleName = "n/a";
            List<Student> aList = new List<Student>();

            IEnumerable<XElement> rows = from row in aStudentFile.Descendants("name")
                                         orderby Convert.ToInt32(row.Attribute("IDNumber").Value) ascending
                                         select row;

            foreach(var aRow in rows)
            {
                anId = aRow.Attribute("IDNumber").Value;
                aFirstName = aRow.Attribute("FirstName").Value;
                aLastName = aRow.Attribute("LastName").Value;
                aMiddleName = aRow.Attribute("MiddleName").Value;

                Student aStudent = new Student(anId, aFirstName, aLastName, aMiddleName);
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
                aList.Add(aStudent);
            }
            return aList;
        }

        //  Category File                           -       Category         -   2                      -   DONE    -   Java / C / C++
        /*public List<Category> GetCategory(string answer)
        {
            int anId = -1;          //  Category ID
            string aCategoryName = "n/a";
            string aDescription = "n/a";
            List<Category> aList = new List<Category>();

            IEnumerable<XElement> rows = from row in aCategoryFile.Descendants("Category")
                                         where row.Attribute("CategoryID").Value.Equals(answer)
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

        //  Category Ascending                      -       Category         -   2 - 0 - 1              -   DONE
        public List<Category> GetCategoryOrderByAscending(string orderBy)
        {
            int anId = -1;          //  Category ID
            string aCategoryName = "n/a";
            string aDescription = "n/a";
            List<Category> aList = new List<Category>();

            IEnumerable<XElement> rows = from row in aCategoryFile.Descendants("Category")
                                         orderby Convert.ToInt32(row.Attribute("CategoryID").Value) ascending
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
        }

        //  Category Descending                     -       Category         -   2 - 0 - 2              -   DONE
        public List<Category> GetCategoryOrderByDescending(string orderBy)
        {
            int anId = -1;          //  Category ID
            string aCategoryName = "n/a";
            string aDescription = "n/a";
            List<Category> aList = new List<Category>();

            IEnumerable<XElement> rows = from row in aCategoryFile.Descendants("Category")
                                         orderby row.Attribute("CategoryID").Value descending
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
        }

        //  Customer File                           -       Customer         -   3                      -   DONE    -   Java / C / C++
        /*public List<Customer> GetCustomer(string answer)
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

        //  Get CustomerID Name Range               -       Customer         -   3                      -   DONE
        public List<String> GetCustomerIDs()
        {
            string anId = "n/a";                  //CustomerID
            List<String> aList = new List<String>();

            IEnumerable<String> rows = from row in aCustomerFile.Descendants("Customer")
                                         select row.Attribute("CustomerID").Value;

            foreach (var aRow in rows)
            {
                anId = aRow;
                String aCustomer = anId;
                aList.Add(aCustomer);
            }
            return aList;
        }

        //  Customer Ascending                      -       Customer         -   3 - 0 - 1              -   DONE
        public List<Customer> GetCustomerOrderByAscending(string orderBy)
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
                                         orderby row.Attribute("CustomerID").Value ascending
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
        }

        //  Customer Descending                     -       Customer         -   3 - 0 - 2              -   DONE
        public List<Customer> GetCustomerOrderByDescending(string orderBy)
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
                                         orderby row.Attribute("CustomerID").Value descending
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
        }

        //  Employee File                           -       Employee         -   4                      -   DONE    -   Java / C / C++
        /*public List<Employee> GetEmployee(string answer)
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
                                         where row.Attribute("EmployeeID").Value.Equals(answer)
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
                    aHireDate, aAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, aExtension, aPhoto, aNotes, aReportsTo);
                aList.Add(aEmployee);
            }
            return aList;
        }*/

        //  Employee Ascending                      -       Employee         -   4 - 0 - 1              -   DONE
        public List<Employee> GetEmployeeOrderByAscending(string orderBy)
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
                                         orderby Convert.ToInt32(row.Attribute("EmployeeID").Value) ascending
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
        }

        //  Employee Descending                     -       Employee         -   4 - 0 - 2              -   DONE
        public List<Employee> GetEmployeeOrderByDescending(string orderBy)
        {                       //GetEmployeeOrderByDescending
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
                                         orderby Convert.ToInt32(row.Attribute("EmployeeID").Value) descending
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
        }

        //  Order Detail File                       -       Order Detail     -   5                      -   DONE    -   Java / C / C++    -   Break it down even more
        /*public List<Order_Detail> GetOrderDetails(string answer)
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

        //  Order Detail Ascending                  -       Order Detail     -   5 - 0 - 1              -   DONE
        public List<Order_Detail> GetOrderDetailsOrderByAscending(string orderBy)
        {
            int anId = -1;          //  Order Number
            int aProductId = -1;
            double aUnitPrice = 0;
            int aQuantity = -1;
            string aDiscount = "n/a";
            List<Order_Detail> aList = new List<Order_Detail>();

            IEnumerable<XElement> rows = from row in aOrderDetailsFile.Descendants("OrderDetail")
                                         orderby Convert.ToInt32(row.Attribute("OrderID").Value) ascending
                                         select row;

            foreach(var aRow in rows)
            {
                anId = Convert.ToInt32(aRow.Attribute("OrderID").Value);
                aProductId = Convert.ToInt32(aRow.Attribute("ProductID").Value);
                aUnitPrice = Convert.ToDouble(aRow.Attribute("UnitPrice").Value);
                aQuantity = Convert.ToInt32(aRow.Attribute("Quantity").Value);
                aDiscount = aRow.Attribute("Discount").Value;

                Order_Detail aOrderDetails = new Order_Detail(anId, aProductId, aUnitPrice,  aQuantity,aDiscount);
                aList.Add(aOrderDetails);
            }
            return aList;
        }

        //  Order Detail Descending                 -       Order Detail     -   5 - 0 - 2              -   DONE
        public List<Order_Detail> GetOrderDetailsOrderByDescending(string orderBy)
        {
            int anId = -1;          //  Order Number
            int aProductId = -1;
            double aUnitPrice = 0;
            int aQuantity = -1;
            string aDiscount = "n/a";
            List<Order_Detail> aList = new List<Order_Detail>();

            IEnumerable<XElement> rows = from row in aOrderDetailsFile.Descendants("OrderDetail")
                                         orderby Convert.ToInt32(row.Attribute("OrderID").Value) descending
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
        }

        //  Order File                              -       Order            -   6                      -   DONE    -   Java / C / C++
        /*public List<Order> GetOrder(string answer)
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
                                         where row.Attribute("OrderID").Value.Equals(answer)
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
                
                Order aOrder = new Order(anId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, 
                aFreight, aShipName, aShipAddress, aShipCity, aShipRegion, aShipPostalCode, aShipCountry);
                aList.Add(aOrder);
            }
            return aList;
        }*/

        //  Order File Ascending                    -       Order            -   6 - 0 - 1              -   DONE
        public List<Order> GetOrderOrderByAscending(string orderBy)
        {
            int anId = -1;              //  Order ID
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
            List<Order> aList = new List<Order>();

            IEnumerable<XElement> rows = from row in aOrderFile.Descendants("Order")
                                         orderby Convert.ToInt32(row.Attribute("OrderID").Value) ascending
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

                Order aOrder = new Order(anId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, 
                aFreight, aShipName, aShipAddress, aShipCity, aShipRegion, aShipPostalCode, aShipCountry);
                aList.Add(aOrder);
            }
            return aList;
        }

        //  Order File Descending                   -       Order            -   6 - 0 - 2              -   DONE
        public List<Order> GetOrderOrderByDescending(string orderBy)
        {
            int anId = -1;              //  Order ID
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
            List<Order> aList = new List<Order>();

            IEnumerable<XElement> rows = from row in aOrderFile.Descendants("Order")
                                         orderby Convert.ToInt32(row.Attribute("OrderID").Value) descending
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

                Order aOrder = new Order(anId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, 
                aFreight, aShipName, aShipAddress, aShipCity, aShipRegion, aShipPostalCode, aShipCountry);
                aList.Add(aOrder);
            }
            return aList;
        }

        //  Product File                            -       Product          -   7 - 1                  -   DONE    -   Java / C / C++
        /*public List<Product> GetProduct(string answer)
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
                                         where row.Attribute("ProductID").Value.Equals(answer)
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

                Product aProduct = new Product(anId, aProductName, aSupplierId, aCategoryId, aQuantityPerUnit, aUnitPrice, 
                aUnitsInStock, aUnitsOnOrder, aReorderLevel, aDiscontinued);
                aList.Add(aProduct);
            }
            return aList;
        }*/

        //  Product Ascending                       -       Product          -   7 - 1 - 0 - 1          -   DONE
        public List<Product> GetProductOrderByAscending(string orderBy)
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
                                         orderby Convert.ToInt32(row.Attribute("ProductID").Value) ascending
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

                Product aProduct = new Product(anId, aProductName, aSupplierId, aCategoryId, aQuantityPerUnit, aUnitPrice, 
                aUnitsInStock, aUnitsOnOrder, aReorderLevel, aDiscontinued);
                aList.Add(aProduct);
            }
            return aList;
        }

        //  Product Descending                      -       Product          -   7 - 1 - 0 - 2          -   DONE
        public List<Product> GetProductOrderByDescending(string orderBy)
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
                                         orderby Convert.ToInt32(row.Attribute("ProductID").Value) descending
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

                Product aProduct = new Product(anId, aProductName, aSupplierId, aCategoryId, aQuantityPerUnit, aUnitPrice, 
                aUnitsInStock, aUnitsOnOrder, aReorderLevel, aDiscontinued);
                aList.Add(aProduct);
            }
            return aList;
        }

        //  Product Category                        -       Product          -   7 - 2                  -   DONE
        public List<Product> GetProductCategory(string answer)
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
                                         where row.Attribute("CategoryID").Value.Equals(answer)
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
        }

        //  Product Range                           -       Product          -   7 - 3                  -   DONE
        public List<Product> GetProductRange(string answerMin, string answerMax)
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
                                         where Convert.ToDouble(row.Attribute("UnitPrice").Value) >= 
                                            Convert.ToDouble(answerMin) && Convert.ToDouble(row.Attribute("UnitPrice").Value) 
                                            <= Convert.ToDouble(answerMax)
                                         orderby Convert.ToDouble(row.Attribute("UnitPrice").Value)
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
        }

        //  Shipper File                            -       Shipper          -   8                      -   DONE    -   Java / C / C++
        /*public List<Shipper> GetShipper(string answer)
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

        //  Shipper Ascending                       -       Shipper          -   8 - 0 - 1              -   DONE
        public List<Shipper> GetShipperOrderByAscending(string orderBy)
        {
            int anId = -1;          //  Shipper Number
            string aCompanyName = "n/a";
            string aPhone = "n/a";
            List<Shipper> aList = new List<Shipper>();

            IEnumerable<XElement> rows = from row in aShippersFile.Descendants("Shipper")
                                         orderby Convert.ToInt32(row.Attribute("ShipperID").Value) ascending
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
        }

        //  Shipper Descending                      -       Shipper          -   8 - 0 - 2              -   DONE
        public List<Shipper> GetShipperOrderByDescending(string orderBy)
        {
            int anId = -1;          //  Shipper Number
            string aCompanyName = "n/a";
            string aPhone = "n/a";
            List<Shipper> aList = new List<Shipper>();

            IEnumerable<XElement> rows = from row in aShippersFile.Descendants("Shipper")
                                         orderby Convert.ToInt32(row.Attribute("ShipperID").Value) descending
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
        }

        //  Supplier File                           -       Supplier         -   9                      -   DONE    -   Java / C / C++
        /*public List<Supplier> GetSupplier(string answer)
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
                aList.Add(aSupplier)
            }
            return aList;
        }*/

        //  Supplier Ascending                      -       Supplier         -   9 - 0 - 1              -   DONE
        public List<Supplier> GetSupplierOrderByAscending(string orderBY)
        {
            int anId = -1;              //  Supplier ID
            string aCompanyName = "n/a";
            string aContactName = "n/a";
            string aContactTitle = "n/a";
            string aAddress = "n/a";
            string aCity = "n/a";
            string aRegion = "n/a";
            string aCountry = "n/a";
            string aPhone = "n/a";
            string aFax = "n/a";
            string aHomePage = "n/a";
            List<Supplier> aList = new List<Supplier>();

            IEnumerable<XElement> rows = from row in aSuppliersFile.Descendants("Supplier")
                                         orderby Convert.ToInt32(row.Attribute("SupplierID").Value) ascending
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
                aCountry = aRow.Attribute("Country").Value;
                aPhone = aRow.Attribute("Phone").Value;
                aFax = (string)aRow.Attribute("Fax") ?? "n/a";
                aHomePage = (string)aRow.Attribute("HomePage") ?? "n/a";

                Supplier aSupplier = new Supplier(anId, aCompanyName, aContactName, aContactTitle, aAddress, aCity,
                    aRegion, aCountry, aPhone, aFax, aHomePage);
                aList.Add(aSupplier);
            }
            return aList;
        }

        //  Supplier Descending                     -       Supplier         -   9 - 0 - 2              -   DONE
        public List<Supplier> GetSupplierOrderByDescending(String orderBy)
        {
            int anId = -1;              //  Supplier ID
            string aCompanyName = "n/a";
            string aContactName = "n/a";
            string aContactTitle = "n/a";
            string aAddress = "n/a";
            string aCity = "n/a";
            string aRegion = "n/a";
            string aCountry = "n/a";
            string aPhone = "n/a";
            string aFax = "n/a";
            string aHomePage = "n/a";
            List<Supplier> aList = new List<Supplier>();

            IEnumerable<XElement> rows = from row in aSuppliersFile.Descendants("Supplier")
                                         orderby Convert.ToInt32(row.Attribute("SupplierID").Value) descending
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
                aCountry = aRow.Attribute("Country").Value;
                aPhone = aRow.Attribute("Phone").Value;
                aFax = (string)aRow.Attribute("Fax") ?? "n/a";
                aHomePage = (string)aRow.Attribute("HomePage") ?? "n/a";

                Supplier aSupplier = new Supplier(anId, aCompanyName, aContactName, aContactTitle, aAddress, aCity,
                    aRegion, aCountry, aPhone, aFax, aHomePage);
                aList.Add(aSupplier);
            }
            return aList;
        }

        /* SQL Category */
        //  Student SQL                             -       Student          -   1                      -   DONE
        public List<Student> GetStudentsOrder(string answer)
        {
            string anId = "n/a";    //  Student ID
            string aFirstName = "n/a";
            string aLastName = "n/a";
            string aMiddleName = "n/a";
            List<Student> aList = new List<Student>();

            IEnumerable<XElement> rows = from row in aStudentFile.Descendants("name")
                                         where row.Attribute("IDNumber").Value.Equals(answer)
                                         select row;

            foreach(var aRow in rows)
            {
                anId = aRow.Attribute("IDNumber").Value;
                aFirstName = aRow.Attribute("FirstName").Value;
                aLastName = aRow.Attribute("LastName").Value;
                aMiddleName = aRow.Attribute("MiddleName").Value;

                Student aStudent = new Student(anId, aFirstName, aLastName, aMiddleName);
                aList.Add(aStudent);
            }
            return aList;
        }
        
        //  Category SQL                            -       Category         -   2                      -   DONE
        public List<Category> GetCategoryOrder(string answer)
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
        }

        //  Customer SQL                            -       Customer         -   3                      -   DONE
        public List<Customer> GetCustomerOrder(string answer)
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
        }

        //  Employee SQL                            -       Employee         -   4                      -   DONE
        public List<Employee> GetEmployeeOrder(string answer)
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
        }

        //  Order Detail File                       -       Order Detail     -   5                      -   DONE    -   BREAK IT DOWN EVEN MORE NOW!
        public List<Order_Detail> GetOrderDetailOrder(string answer)
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
        }

        //  Order File                              -       Order            -   6                      -   DONE
        public List<Order> GetOrderOrder(string answer)
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
        }

        //  Product File                            -       Product          -   7                      -   DONE
        public List<Product> GetProductOrder(string answer)
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
        }

        //  Shipper File                            -       Shipper          -   8                      -   DONE
        public List<Shipper> GetShipperOrder(string answer)
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
        }

        //  Supplier File                           -       Supplier         -   9                      -   DONE
        public List<Supplier> GetSupplierOrder(string answer)
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
        }
    }
}
