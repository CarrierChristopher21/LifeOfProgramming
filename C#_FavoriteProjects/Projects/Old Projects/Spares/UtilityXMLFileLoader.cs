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
        private XDocument aStudentFile = XDocument.Load(@"C:\Users\user\Desktop\Visual Studio Programming\Visual Studio 2010\Projects\OurBanner\Data Loader\Mayflower.xml");
        //  Categories.xml - aCategoryFile
        private XDocument aCategoryFile = XDocument.Load(@"C:\Users\user\Desktop\Visual Studio Programming\Visual Studio 2010\Projects\OurBanner\Data Loader\Categories.xml");
        //  Customers.xml - aCustomerFile
        private XDocument aCustomerFile = XDocument.Load(@"C:\Users\user\Desktop\Visual Studio Programming\Visual Studio 2010\Projects\OurBanner\Data Loader\Customers.xml");
        //  Employees.xml - aEmployeesFile
        private XDocument aEmployeesFile = XDocument.Load(@"C:\Users\user\Desktop\Visual Studio Programming\Visual Studio 2010\Projects\OurBanner\Data Loader\Employees.xml");
        //  OrderDetails.xml - aOrderDetailsFile
        private XDocument aOrderDetailsFile = XDocument.Load(@"C:\Users\user\Desktop\Visual Studio Programming\Visual Studio 2010\Projects\OurBanner\Data Loader\OrderDetails.xml");
        //  Orders.xml - aOrderFile
        private XDocument aOrderFile = XDocument.Load(@"C:\Users\user\Desktop\Visual Studio Programming\Visual Studio 2010\Projects\OurBanner\Data Loader\Orders.xml");
        //  Products.xml - aProductsFile
        private XDocument aProductsFile = XDocument.Load(@"C:\Users\user\Desktop\Visual Studio Programming\Visual Studio 2010\Projects\OurBanner\Data Loader\Products.xml");
        //  Shippers.xml - aShippersFile
        private XDocument aShippersFile = XDocument.Load(@"C:\Users\user\Desktop\Visual Studio Programming\Visual Studio 2010\Projects\OurBanner\Data Loader\Shippers.xml");
        //  Suppliers.xml - aSuppliersFile
        private XDocument aSuppliersFile = XDocument.Load(@"C:\Users\user\Desktop\Visual Studio Programming\Visual Studio 2010\Projects\OurBanner\Data Loader\Suppliers.xml");
		
		private static UtilityXMLFileLoader anInstance = null;

        public static UtilityXMLFileLoader GetanInstance
        {
            get
            {
                if (UtilityXMLFileLoader.anInstance == null)
                {
                    UtilityXMLFileLoader.anInstance = new UtilityXMLFileLoader();
                }

                return UtilityXMLFileLoader.anInstance;
            }
        }



        private UtilityXMLFileLoader()
        {
            // This is private which prevents any other code
            // from creating one.
            // No code anywhere -- EXCEPT from within
            // this class -- can create an object 
            // from this class

        }


        public List<Student> GetStudents()
        {
            string anId = "n/a";
            string aFirstName = "n/a";
            string aLastName = "n/a";
            string aMiddleName = "n/a";
            List<Student> aList = new List<Student>();
            

            IEnumerable<XElement> rows = from row in aStudentFile.Descendants("name")
                                         select row;

            foreach (var aRow in rows)
            {

                anId = aRow.Attribute("IDNumber").Value;
                aFirstName = aRow.Attribute("FirstName").Value;
                aLastName = aRow.Attribute("LastName").Value;
                aMiddleName = aRow.Attribute("MiddleName").Value;

                Student1 aStudent = new Student1(anId, aFirstName, aLastName, aMiddleName);
                aList.Add(aStudent);
				
            }

            return aList;
        }

        /*private static UtilityXMLFileLoader anInstance = null;
        
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
        
        //  Student File
        public List<Student> GetStudents(string answer)
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
        // All Files of Student      
        public List<Student> GetStudents()
        {
            string anId = "n/a";    //  Student ID
            string aFirstName = "n/a";
            string aLastName = "n/a";
            string aMiddleName = "n/a";
            List<Student> aList = new List<Student>();

            IEnumerable<XElement> rows = from row in aStudentFile.Descendants("name")
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
        //  Category File
        public List<Category> GetCategory()
        {
            int anId = -1;          //  Category ID
            string aCategoryName = "n/a";
            string aDescription = "n/a";
            List<Category> aList = new List<Category>();

            IEnumerable<XElement> rows = from row in aCategoryFile.Descendants("name")
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

        //  Customer File
        public List<Customer> GetCustomer()
        {
            int anId = -1;                  //CustomerID
            string aCompanyName = "n/a";
            string aContactName = "n/a";
            string aContactTitle = "n/a";
            string aAddressCity = "n/a";
            string aRegion = "n/a";
            string aPostalCode = "n/a";
            string aCountry = "n/a";
            string aPhone = "n/a";
            string aFax = "n/a";
            List<Customer> aList = new List<Customer>();

            IEnumerable<XElement> rows = from row in aCustomerFile.Descendants("name")
                                         select row;

            foreach(var aRow in rows)
            {
                anId = Convert.ToInt32(aRow.Attribute("CustomerID").Value);     //  Customer ID
                aCompanyName = aRow.Attribute("CompanyName").Value;
                aContactName = aRow.Attribute("ContactName").Value;
                aContactTitle = aRow.Attribute("ContactTitle").Value;
                aAddressCity = aRow.Attribute("AddressCity").Value;
                aRegion = aRow.Attribute("Region").Value;
                aPostalCode = aRow.Attribute("PostalCode").Value;
                aCountry = aRow.Attribute("Country").Value;
                aPhone = aRow.Attribute("Phone").Value;
                aFax = aRow.Attribute("Fax").Value;
                
                Customer aCustomer = new Customer(anId, aCompanyName, aContactName, aContactTitle, aAddressCity, aRegion, aPostalCode, 
                    aCountry, aPhone, aFax);
                aList.Add(aCustomer);

            }

            return aList;
        }

        //  Employee File
        public List<Employee> GetEmployee()
        {
            int anId = -1;         //Employee ID
            int aReportsTo = -1;
            string aLastName = "n/a";
            string aFirstName = "n/a";
            string aTitle = "n/a";
            string aTitleOfCourtesy = "n/a";
            string aBirthDate = "n/a";
            string aHireDate = "n/a";
            string aAddressCity = "n/a";
            string aRegion = "n/a";
            string aPostalCode = "n/a";
            string aCountry = "n/a";
            string aHomePhone = "n/a";
            string aExtension = "n/a";
            string aNotes = "n/a";
            List<Employee> aList = new List<Employee>();

            IEnumerable<XElement> rows = from row in aEmployeesFile.Descendants("name")
                                         select row;

            foreach(var aRow in rows)
            {
                anId = Convert.ToInt32(aRow.Attribute("EmployeeID").Value);
                aReportsTo = Convert.ToInt32(aRow.Attribute("ReportsTo").Value);
                aLastName = aRow.Attribute("LastName").Value;
                aFirstName = aRow.Attribute("FirstName").Value;
                aTitle = aRow.Attribute("Title").Value;
                aTitleOfCourtesy = aRow.Attribute("TitleOfCourtesy").Value;
                aBirthDate = aRow.Attribute("BirthDate").Value;
                aHireDate = aRow.Attribute("HireDate").Value;
                aAddressCity = aRow.Attribute("AddressCity").Value;
                aRegion = aRow.Attribute("Region").Value;
                aPostalCode = aRow.Attribute("PostalCode").Value;
                aCountry = aRow.Attribute("Country").Value;
                aHomePhone = aRow.Attribute("HomePhone").Value;
                aExtension = aRow.Attribute("Extension").Value;
                aNotes = aRow.Attribute("Notes").Value;

                Employee aCustomer = new Employee(anId, aReportsTo, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, 
                    aHireDate, aAddressCity, aRegion, aPostalCode, aCountry, aHomePhone, aExtension, aNotes);
                aList.Add(aCustomer);

            }

            return aList;
        }

        //  Order Details File
        public List<Order_Detail> GetOrderDetails()
        {
            int anId = -1;          //  Order Number
            int aProductId = -1;
            int aQuantity = -1;
            double aUnitPrice = 0;
            double aDiscount = 0;
            List<Order_Detail> aList = new List<Order_Detail>();

            IEnumerable<XElement> rows = from row in aOrderDetailsFile.Descendants("name")
                                         select row;

            foreach(var aRow in rows)
            {
                anId = Convert.ToInt32(aRow.Attribute("OrderID").Value);
                aProductId = Convert.ToInt32(aRow.Attribute("ProductID").Value);
                aQuantity = Convert.ToInt32(aRow.Attribute("Quantity").Value);
                aUnitPrice = Convert.ToInt32(aRow.Attribute("UnitPrice").Value);
                aDiscount = Convert.ToInt32(aRow.Attribute("Discount").Value);
                
                Order_Detail aOrderDetails = new Order_Detail(anId, aProductId, aQuantity, aUnitPrice, aDiscount);
                aList.Add(aOrderDetails);

            }

            return aList;
        }

        // Order File
        public List<Order> GetOrder()
        {
            int anId = -1;              //  Order ID
            int aCustomerId = -1;
            int aEmployeeId = -1;
            int aShipVia = -1;
            string aOrderDate = "n/a";
            string aRequiredDate = "n/a";
            string aShippedDate = "n/a";
            string aShipName = "n/a";
            string aShipAddress = "n/a";
            string aShipCity = "n/a";
            string aShipRegion = "n/a";
            string aShipPostalCode = "n/a";
            string aShipCountry = "n/a";
            double aFreight = 0;
            List<Order> aList = new List<Order>();

            IEnumerable<XElement> rows = from row in aOrderFile.Descendants("name")
                                         select row;

            foreach(var aRow in rows)
            {
                anId = Convert.ToInt32(aRow.Attribute("OrderID").Value);
                aCustomerId = Convert.ToInt32(aRow.Attribute("CustomerID").Value);
                aEmployeeId = Convert.ToInt32(aRow.Attribute("FirstName").Value);
                aShipVia = Convert.ToInt32(aRow.Attribute("Title").Value);
                aOrderDate = aRow.Attribute("TitleOfCourtesy").Value;
                aRequiredDate = aRow.Attribute("BirthDate").Value;
                aShippedDate = aRow.Attribute("HireDate").Value;
                aShipName = aRow.Attribute("AddressCity").Value;
                aShipAddress = aRow.Attribute("Region").Value;
                aShipCity = aRow.Attribute("PostalCode").Value;
                aShipRegion = aRow.Attribute("Country").Value;
                aShipPostalCode = aRow.Attribute("HomePhone").Value;
                aShipCountry = aRow.Attribute("Extension").Value;
                aFreight = Convert.ToInt32(aRow.Attribute("Freight").Value);

                Order aOrder = new Order(anId, aCustomerId, aEmployeeId, aShipVia, aOrderDate, aRequiredDate,
                    aShippedDate, aShipName, aShipAddress, aShipCity, aShipRegion, aShipPostalCode, aShipCountry, aFreight);
                aList.Add(aOrder);

            }

            return aList;
        }

        // Products File
        public List<Product> GetProduct()
        {
            int anId = -1;              //  Product ID
            int aSupplierId = -1;
            int aCategoryId = -1;
            int aUnitsInStock = -1;
            int aUnitsOnOrder = -1;
            int aReorderLevel = -1;
            double aUnitPrice = 1000000000;
            bool aDiscontinued = false;
            string aProductName = "n/a";
            string aQuantityPerUnit = "n/a";
            List<Product> aList = new List<Product>();

            IEnumerable<XElement> rows = from row in aProductsFile.Descendants("name")
                                         select row;

            foreach(var aRow in rows)
            {
                anId = Convert.ToInt32(aRow.Attribute("ProductID").Value);
                aSupplierId = Convert.ToInt32(aRow.Attribute("SupplierID").Value);
                aCategoryId = Convert.ToInt32(aRow.Attribute("CategoryID").Value);
                aUnitsInStock = Convert.ToInt32(aRow.Attribute("UnitsInStock").Value);
                aUnitsOnOrder = Convert.ToInt32(aRow.Attribute("UnitsOnOrder").Value);
                aReorderLevel = Convert.ToInt32(aRow.Attribute("ReOrderLevel").Value);
                aProductName = aRow.Attribute("ProductName").Value;
                aQuantityPerUnit = aRow.Attribute("QuantityPerUnit").Value;
                aUnitPrice = Convert.ToInt32(aRow.Attribute("UnitPrice").Value);
                aDiscontinued = Convert.ToBoolean(aRow.Attribute("Discontinued").Value);
                
                Product aProduct = new Product(anId, aSupplierId, aCategoryId, aUnitsInStock, aUnitsOnOrder, aReorderLevel,
                    aQuantityPerUnit, aProductName, aUnitPrice,aDiscontinued);
                aList.Add(aProduct);

            }

            return aList;
        }

        //  Shippers File
        public List<Shipper> GetShipper()
        {
            int anId = -1;          //  Shipper Number
            string aCompanyName = "n/a";
            string aPhone = "n/a";
            List<Shipper> aList = new List<Shipper>();

            IEnumerable<XElement> rows = from row in aShippersFile.Descendants("name")
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

        //  Suppliers File
        public List<Supplier> GetSupplier()
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

            IEnumerable<XElement> rows = from row in aSuppliersFile.Descendants("name")
                                         select row;
            foreach(var aRow in rows)
            {
                anId = Convert.ToInt32(aRow.Attribute("SupplierID").Value);
                aCompanyName = aRow.Attribute("CompanyName").Value;
                aContactName = aRow.Attribute("ContactName").Value;
                aContactTitle = aRow.Attribute("ContactTitle").Value;
                aAddress = aRow.Attribute("Address").Value;
                aCity = aRow.Attribute("City").Value;
                aRegion = aRow.Attribute("Region").Value;
                aCountry = aRow.Attribute("Country").Value;
                aPhone = aRow.Attribute("Phone").Value;
                aFax = aRow.Attribute("Fax").Value;
                aHomePage = aRow.Attribute("HomePage").Value;
                
                Supplier aSupplier = new Supplier(anId, aCompanyName, aContactName, aContactTitle, aAddress, aCity,
                    aRegion, aCountry, aPhone, aFax, aHomePage);
                aList.Add(aSupplier);

            }

            return aList;
        }

    }
}
