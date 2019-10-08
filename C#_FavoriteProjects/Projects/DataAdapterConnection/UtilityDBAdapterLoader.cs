

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
    public class UtilityDBAdapterLoader
    {
        private static OleDbConnection aConnection = new OleDbConnection();
        private static OleDbCommand aCommand = aConnection.CreateCommand();
        private static OleDbDataAdapter anAdapter = new OleDbDataAdapter(aCommand);
        private static  DataSet aDataSet = new DataSet();

        private static UtilityDBAdapterLoader anInstance = null;

        public static UtilityDBAdapterLoader GetanInstance
        {
            get
            {
                if(UtilityDBAdapterLoader.anInstance == null)
                {
                    UtilityDBAdapterLoader.anInstance = new UtilityDBAdapterLoader();
                }
                return UtilityDBAdapterLoader.anInstance;
            }
        }

        private UtilityDBAdapterLoader()
        {
            // This is private which prevents any other code
            // from creating one.
            // No code anywhere -- EXCEPT from within
            // this class -- can create an object 
            // from this class

            // set the connection string
            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\Connection\Connection\Data\Northwind.accdb";

            //  Open the Connection
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
            Console.ReadLine();
        }

        public void GetProducts()
        {
            Console.BufferHeight = 1000;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

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
        }
        /*while(aDataSet.)
        {
            anId = (int)aReader["ProductID"];
            aProductName = (string)aReader["ProductName"];
            aSupplierId = (int)aReader["SupplierID"];
            aCategoryId = (int)aReader["CategoryID"];
            aQuantityPerUnit = (string)aReader["QuantityPerUnit"];
            aUnitPrice = (double)(decimal)aReader["UnitPrice"];
            aUnitsInStock = (short)aReader["UnitsInStock"];
            aUnitsOnOrder = (short)aReader["UnitsOnOrder"];
            aReorderLevel = (short)aReader["ReorderLevel"];
            bool isDiscontinued = (bool)aReader["DisContinued"];

            Product aProduct = new Product(anId, aProductName, aSupplierId, aCategoryId, aQuantityPerUnit, aUnitPrice, aUnitsInStock,
                aUnitsOnOrder, aReorderLevel, aDiscontinued);

            aList.Add(aProduct);
        }*/
    }
}
