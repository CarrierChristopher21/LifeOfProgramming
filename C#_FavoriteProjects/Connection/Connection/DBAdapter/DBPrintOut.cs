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
    public class DBPrintOut
    {
        DBUtilityAdapterLoader aDBLoader = new DBUtilityAdapterLoader();
        DataSet aDataSet = DBUtilityAdapterLoader.GetDataSet;
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
        public void PrintStudent(List<Student> aList)
        {
            Console.WriteLine();
            foreach(Student aStudent in aList)
            {
                Console.WriteLine(aStudent.ToString());
            }
        }

        //  Category List
        public void PrintCategory(DataTable CategoryTable)
        {

            Console.WriteLine();
            foreach(DataRow aRow in aDataSet.Tables["CategoryTable"].Rows)
            {
                Console.WriteLine("Category ID = " + aRow["CategoryID"].ToString());
                Console.WriteLine("Category Name = " + aRow["CategoryName"].ToString());
                Console.WriteLine("Description = " + aRow["Description"].ToString());
                Console.WriteLine("Number Of Categories = " + aDataSet.Tables["CategoryTable"].Rows.Count);
                Console.WriteLine();
            }
        }

        //  Customer List
        public void PrintCustomer(DataTable CustomerTable)
        {
            Console.WriteLine();
            foreach(DataRow aRow in aDataSet.Tables["CustomerTable"].Rows)
            {
                Console.WriteLine("Customer ID = " + aRow["CustomerID"].ToString());
                Console.WriteLine("Company Name = " + aRow["CompanyName"].ToString());
                Console.WriteLine("Contact Name = " + aRow["ContactName"].ToString());
                Console.WriteLine("Contact Title = " + aRow["ContactTitle"].ToString());
                Console.WriteLine("Address = " + aRow["Address"].ToString());
                Console.WriteLine("City = " + aRow["City"].ToString());
                Console.WriteLine("Region = " + aRow["Region"].ToString());
                Console.WriteLine("Postal Code = " + aRow["PostalCode"].ToString());
                Console.WriteLine("Country = " + aRow["Country"].ToString());
                Console.WriteLine("Phone = " + aRow["Phone"].ToString());
                Console.WriteLine("Fax = " + aRow["Fax"].ToString());
                Console.WriteLine("Number Of Customers = " + aDataSet.Tables["CustomerTable"].Rows.Count);
                Console.WriteLine();
            }
        }

        //  Employee List
        public void PrintEmployee(DataTable EmployeeTable)
        {
            Console.WriteLine();
            /*foreach(Employee aEmployee in EmployeeTable)
            {
                Console.WriteLine(aEmployee.ToString());
            }*/
            foreach(DataRow aRow in aDataSet.Tables["EmployeeTable"].Rows)
            {
                Console.WriteLine("Employee ID = " + aRow["Employees.EmployeeID"].ToString());
                //Console.WriteLine("Last Name = " + aRow["Employees.LastName"].ToString());
                Console.WriteLine("Employee's Name = " + aRow["(Employees.FirstName + " + " " + "Employees.LastName) AS [Employees Name]"].ToString());
                Console.WriteLine("Title = " + aRow["Employees.Title"].ToString());
                Console.WriteLine("Title Of Courtesy = " + aRow["Employees.TitleOfCourtesy"].ToString());
                Console.WriteLine("Birth Date = " + aRow["Employees.BirthDate"].ToString());
                Console.WriteLine("Hire Date = " + aRow["Employees.HireDate"].ToString());
                Console.WriteLine("Address = " + aRow["Employees.Address"].ToString());
                Console.WriteLine("City = " + aRow["Employees.City"].ToString());
                Console.WriteLine("Region = " + aRow["Employees.Region"].ToString());
                Console.WriteLine("Postal Code = " + aRow["Employees.PostalCode"].ToString());
                Console.WriteLine("Country = " + aRow["Employees.Country"].ToString());
                Console.WriteLine("Home Phone = " + aRow["Employees.HomePhone"].ToString());
                Console.WriteLine("Extension = " + aRow["Employees.Extension"].ToString());
                Console.WriteLine("Photo = " + aRow["Employees.Photo"].ToString());
                Console.WriteLine("Notes = " + aRow["Employees.PostalCode"].ToString());
                Console.WriteLine("ReportsTo = " + aRow["Employees.Country"].ToString());
                Console.WriteLine("Number Of Employee's = " + aDataSet.Tables["EmployeesTable"].Rows.Count);
            }
        }

        //  Order_Detail List                                -       BREAK IT DOWN EVEN MORE NOW!
        public void PrintOrderDetail(DataTable OrderDetailTable)
        {
            Console.WriteLine();
            foreach(DataRow aRow in aDataSet.Tables["OrderDetailsTable"].Rows)
            {
                Console.WriteLine("Order Number = " + aRow["[Order Details].OrderID"].ToString());
                //Console.WriteLine("Last Name = " + aRow["Employees.LastName"].ToString());
                Console.WriteLine("Employee's Name = " + aRow["(Employees.FirstName + " + " " + "Employees.LastName) AS [Employees Name]"].ToString());
                Console.WriteLine("Title = " + aRow["Employees.Title"].ToString());
                Console.WriteLine("Title Of Courtesy = " + aRow["Employees.TitleOfCourtesy"].ToString());
                Console.WriteLine("Birth Date = " + aRow["[Order Details].BirthDate"].ToString());
                Console.WriteLine("Hire Date = " + aRow["[Order Details].HireDate"].ToString());
                Console.WriteLine("Address = " + aRow["[Order Details].Address"].ToString());
                Console.WriteLine("City = " + aRow["[Order Details].City"].ToString());
                Console.WriteLine("Region = " + aRow["[Order Details].Region"].ToString());
                Console.WriteLine("Postal Code = " + aRow["[Order Details].PostalCode"].ToString());
                Console.WriteLine("Country = " + aRow["[Order Details].Country"].ToString());
                Console.WriteLine("Number Of Order Details = " + aDataSet.Tables["OrderDetailsTable"].Rows.Count);
            }
        }

        //  Order List
        public void PrintOrder(DataTable OrderTable)
        {
            Console.WriteLine();
            foreach(DataRow aRow in aDataSet.Tables["OrdersTable"].Rows)
            {
                Console.WriteLine("Order Number = " + aRow["Orders.OrderID"].ToString());
                Console.WriteLine("Contact Title = " + aRow["Customers.ContactTitle"].ToString());
                Console.WriteLine("Contact Name = " + aRow["Customers.ContactName"].ToString());
                Console.WriteLine("Employee's Name = " + aRow["(Employees.FirstName" + " " + "Employees.LastName) AS [Employees Name]"].ToString());
                Console.WriteLine("Order Date = " + aRow["Orders.OrderDate"].ToString());
                Console.WriteLine("Required Date = " + aRow["Orders.RequiredDate"].ToString());
                Console.WriteLine("Shipped Date = " + aRow["Orders.ShippedDate"].ToString());
                Console.WriteLine("Ship Via = " + aRow["Orders.ShipVia"].ToString());
                Console.WriteLine("Freight = " + aRow["Orders.Freight"].ToString());
                Console.WriteLine("Ship Name = " + aRow["Orders.ShipName"].ToString());
                Console.WriteLine("Ship Address = " + aRow["Orders.ShipAddress"].ToString());
                Console.WriteLine("Ship City = " + aRow["Orders.ShipCity"].ToString());
                Console.WriteLine("Ship Region = " + aRow["Orders.ShipRegion"].ToString());
                Console.WriteLine("Ship Postal Code = " + aRow["Orders.ShipPostalCode"].ToString());
                Console.WriteLine("Ship Country = " + aRow["Orders.ShipCountry"].ToString());
                Console.WriteLine("Number Of Order = " + aDataSet.Tables["OrdersTable"].Rows.Count);
            }
        }

        //  Product List
        public void PrintProduct(DataTable ProductTable)
        {
            Console.WriteLine();
            foreach(DataRow aRow in aDataSet.Tables["ProductTable"].Rows)
            {
                Console.WriteLine("Product Number = " + aRow["Products.ProductID"].ToString());
                Console.WriteLine("Product Name = " + aRow["Products.ProdctName"].ToString());
                Console.WriteLine("Company Name = " + aRow["Suppliers.CompanyName"].ToString());
                Console.WriteLine("Category Name = " + aRow["Categories.CategoryName"].ToString());
                Console.WriteLine("Quantity Per Unit = " + aRow["Products.QuantityPerUnit"].ToString());
                Console.WriteLine("Unit Price = " + aRow["Products.UnitPrice"].ToString());
                Console.WriteLine("Units In Stock = " + aRow["Products.UnitsInStock"].ToString());
                Console.WriteLine("Units On Order = " + aRow["Products.UnitsOnOrder"].ToString());
                Console.WriteLine("Reorder Level = " + aRow["Products.ReorderLevel"].ToString());
                Console.WriteLine("Discontinued = " + aRow["Products.Discontinued"].ToString());
                Console.WriteLine("Number Of Products = " + aDataSet.Tables["ProductsTable"].Rows.Count);
            }
        }

        //  Shipper
        public void PrintShipper(DataTable ShipperTable)
        {
            Console.WriteLine();
            foreach(DataRow aRow in aDataSet.Tables["ShipperTable"].Rows)
            {
                Console.WriteLine("Shippers ID = " + aRow["Shippers.ShipperID"].ToString());
                Console.WriteLine("Company Name = " + aRow["Shippers.CompanyName"].ToString());
                Console.WriteLine("Phone = " + aRow["Shippers.Phone"].ToString());
                Console.WriteLine("Number Of Shipper = " + aDataSet.Tables["ShipperTable"].Rows.Count);
            }
        }

        //  Supplier List
        public void PrintSupplier(DataTable SupplierTable)
        {
            Console.WriteLine();
            foreach(DataRow aRow in aDataSet.Tables["SuppliersTable"].Rows)
            {
                Console.WriteLine("Supplier ID = " + aRow["Suppliers.SupplierID"].ToString());
                Console.WriteLine("Company Name = " + aRow["Suppliers.CompanyName"].ToString());
                Console.WriteLine("Contact Name = " + aRow["Suppliers.ContactName"].ToString());
                Console.WriteLine("Contact Title = " + aRow["Suppliers.ContactTitle"].ToString());
                Console.WriteLine("Address = " + aRow["Suppliers.Address"].ToString());
                Console.WriteLine("City = " + aRow["Suppliers.City"].ToString());
                Console.WriteLine("Region = " + aRow["Suppliers.Region"].ToString());
                Console.WriteLine("Postal Code = " + aRow["Suppliers.PostalCode"].ToString());
                Console.WriteLine("Country = " + aRow["Suppliers.Country"].ToString());
                Console.WriteLine("Phone = " + aRow["Suppliers.Phone"].ToString());
                Console.WriteLine("Fax = " + aRow["Suppliers.Fax"].ToString());
                Console.WriteLine("Home Page = " + aRow["Suppliers.HomePage"].ToString());
                Console.WriteLine("Number Of Suppliers = " + aDataSet.Tables["SuppliersTable"].Rows.Count);
            }
        }
    }
}