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
        /*  Informaton About DBPrintOut Class
            This class is mainly just the set up for how output will look after all the process are done and then all that is left
            would be to print the data out acccordingly.
        */
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

        //  Student List            -       1
        public void PrintStudent(List<Student> aList)
        {
            Console.WriteLine();
            foreach(Student aStudent in aList)
            {
                Console.WriteLine(aStudent.ToString());
            }
        }

        //  Category List           -       2
        public void PrintCategory(DataTable CategoryTable)
        {
            Console.WriteLine();
            foreach(DataRow aRow in aDataSet.Tables["CategoryTable"].Rows)
            {
                Console.WriteLine("Category ID = " + aRow["CategoryID"].ToString());
                Console.WriteLine("Category Name = " + aRow["CategoryName"].ToString());
                Console.WriteLine("Description = " + aRow["Description"].ToString());
                //  Console.WriteLine("Number Of Categories = " + aDataSet.Tables["CategoryTable"].Rows.Count);
                Console.WriteLine();
            }
        }

        //  Customer List           -       3
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
                //  Console.WriteLine("Number Of Customer's = " + aDataSet.Tables["CustomerTable"].Rows.Count);
                Console.WriteLine();
            }
        }

        //  Employee List           -       4
        public void PrintEmployee(DataTable EmployeeTable)
        {
            Console.WriteLine();

            foreach(DataRow aRow in aDataSet.Tables["EmployeeTable"].Rows)
            {
                string fullname = aRow["Employees Name"].ToString();
                Console.WriteLine("Employee ID = " + aRow["EmployeeID"].ToString());
                Console.WriteLine("Employee's Name = " + aRow["Employees Name"].ToString());
                Console.WriteLine("Title = " + aRow["Title"].ToString());
                Console.WriteLine("Title Of Courtesy = " + aRow["TitleOfCourtesy"].ToString());
                Console.WriteLine("Birth Date = " + aRow["BirthDate"].ToString());
                Console.WriteLine("Hire Date = " + aRow["HireDate"].ToString());
                Console.WriteLine("Address = " + aRow["Address"].ToString());
                Console.WriteLine("City = " + aRow["City"].ToString());
                Console.WriteLine("Region = " + aRow["Region"].ToString());
                Console.WriteLine("Postal Code = " + aRow["PostalCode"].ToString());
                Console.WriteLine("Country = " + aRow["Country"].ToString());
                Console.WriteLine("Home Phone = " + aRow["HomePhone"].ToString());
                Console.WriteLine("Extension = " + aRow["Extension"].ToString());
                Console.WriteLine("Photo = " + aRow["Photo"].ToString());
                Console.WriteLine("Notes = " + aRow["PostalCode"].ToString());
                Console.WriteLine("ReportsTo = " + aRow["Country"].ToString());
                //  Console.WriteLine("Number Of Employee's = " + aDataSet.Tables["EmployeeTable"].Rows.Count);
                Console.WriteLine();
            }
        }

        //  Order_Detail List       -       5                                -       BREAK IT DOWN EVEN MORE NOW!
        public void PrintOrderDetail(DataTable OrderDetailTable)
        {
            Console.WriteLine();
            foreach(DataRow aRow in aDataSet.Tables["OrderDetailsTable"].Rows)
            {
                Console.WriteLine("Order Number = " + aRow["OrderID"].ToString());
                Console.WriteLine("Product Name = " + aRow["ProductName"].ToString());
                Console.WriteLine("Customer's Contact Name = " + aRow["ContactName"].ToString());
                Console.WriteLine("Customer's Contact Title = " + aRow["ContactTitle"].ToString());
                Console.WriteLine("Employee's Title Of Courtesy = " + aRow["TitleOfCourtesy"].ToString());
                Console.WriteLine("Employee's Name = " + aRow["Employees Name"].ToString());
                Console.WriteLine("Employee's Title = " + aRow["Title"].ToString());
                Console.WriteLine("Unit Price = " + aRow["UnitPrice"].ToString());
                Console.WriteLine("Quantity = " + aRow["Quantity"].ToString());
                Console.WriteLine("Discount = " + aRow["Discount"].ToString());
                //  Console.WriteLine("Number Of Order Details = " + aDataSet.Tables["OrderDetailsTable"].Rows.Count);
                Console.WriteLine();
            }
        }

        //  Order List              -       6
        public void PrintOrder(DataTable OrderTable)
        {
            Console.WriteLine();
            foreach(DataRow aRow in aDataSet.Tables["OrdersTable"].Rows)
            {
                Console.WriteLine("Order Number = " + aRow["OrderID"].ToString());
                Console.WriteLine("Customer's Contact Title = " + aRow["ContactTitle"].ToString());
                Console.WriteLine("Customer's Contact Name = " + aRow["ContactName"].ToString());
                Console.WriteLine("Employee's Title Of Courtesy = " + aRow["TitleOfCourtesy"].ToString());
                Console.WriteLine("Employee's Name = " + aRow["Employees Name"].ToString());
                Console.WriteLine("Employee's Title = " + aRow["Title"].ToString());
                Console.WriteLine("Order Date = " + aRow["OrderDate"].ToString());
                Console.WriteLine("Required Date = " + aRow["RequiredDate"].ToString());
                Console.WriteLine("Shipped Date = " + aRow["ShippedDate"].ToString());
                Console.WriteLine("Ship Via = " + aRow["ShipVia"].ToString());
                Console.WriteLine("Freight = " + aRow["Freight"].ToString());
                Console.WriteLine("Ship Name = " + aRow["ShipName"].ToString());
                Console.WriteLine("Ship Address = " + aRow["ShipAddress"].ToString());
                Console.WriteLine("Ship City = " + aRow["ShipCity"].ToString());
                Console.WriteLine("Ship Region = " + aRow["ShipRegion"].ToString());
                Console.WriteLine("Ship Postal Code = " + aRow["ShipPostalCode"].ToString());
                Console.WriteLine("Ship Country = " + aRow["ShipCountry"].ToString());
                //  Console.WriteLine("Number Of Order = " + aDataSet.Tables["OrdersTable"].Rows.Count);
                Console.WriteLine();
            }
        }

        //  Product List            -       7
        public void PrintProduct(DataTable ProductTable)
        {
            Console.WriteLine();
            foreach(DataRow aRow in aDataSet.Tables["ProductsTable"].Rows)
            {
                Console.WriteLine("Product Number = " + aRow["ProductID"].ToString());
                Console.WriteLine("Product Name = " + aRow["ProductName"].ToString());
                Console.WriteLine("Company Name = " + aRow["CompanyName"].ToString());
                Console.WriteLine("Category Name = " + aRow["CategoryName"].ToString());
                Console.WriteLine("Quantity Per Unit = " + aRow["QuantityPerUnit"].ToString());
                Console.WriteLine("Unit Price = " + aRow["UnitPrice"].ToString());
                Console.WriteLine("Units In Stock = " + aRow["UnitsInStock"].ToString());
                Console.WriteLine("Units On Order = " + aRow["UnitsOnOrder"].ToString());
                Console.WriteLine("Reorder Level = " + aRow["ReorderLevel"].ToString());
                Console.WriteLine("Discontinued = " + aRow["Discontinued"].ToString());
                //  Console.WriteLine("Number Of Products = " + aDataSet.Tables["ProductsTable"].Rows.Count);
                Console.WriteLine();
            }
        }

        //  Shipper List            -       8
        public void PrintShipper(DataTable ShipperTable)
        {
            Console.WriteLine();
            foreach(DataRow aRow in aDataSet.Tables["ShipperTable"].Rows)
            {
                Console.WriteLine("Shippers ID = " + aRow["ShipperID"].ToString());
                Console.WriteLine("Company Name = " + aRow["CompanyName"].ToString());
                Console.WriteLine("Phone = " + aRow["Phone"].ToString());
                //  Console.WriteLine("Number Of Shipper = " + aDataSet.Tables["ShipperTable"].Rows.Count);
                Console.WriteLine();
            }
        }

        //  Supplier List           -       9
        public void PrintSupplier(DataTable SupplierTable)
        {
            Console.WriteLine();
            foreach(DataRow aRow in aDataSet.Tables["SuppliersTable"].Rows)
            {
                Console.WriteLine("Supplier ID = " + aRow["SupplierID"].ToString());
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
                Console.WriteLine("Home Page = " + aRow["HomePage"].ToString());
                //  Console.WriteLine("Number Of Suppliers = " + aDataSet.Tables["SuppliersTable"].Rows.Count);
                Console.WriteLine();
            }
        }
    }
}