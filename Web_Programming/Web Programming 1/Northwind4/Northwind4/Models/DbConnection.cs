using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.Odbc;
using Northwind4;

namespace Northwind4.Models
{
    public sealed class DBConnection
    {

		//OleDbConnection aConnection = new OleDbConnection();
        // one connection for every class -- we want to enforce this statement
		private List<Product> aListOfProducts = new List<Product>();
		private List<Category> aListOfCategories = new List<Category>();
		//	Call Connections
		private static OleDbConnection aConnection = new OleDbConnection();
		private static OleDbCommand aCommand = aConnection.CreateCommand();
		private static OleDbDataAdapter anAdapter = new OleDbDataAdapter(aCommand);
		private static DataSet aDataSet = new DataSet();
		private static DBConnection anInstance = null;


        public DBConnection() 
		{
			aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
											Data Source=C:\Users\Chris\Desktop\Web Programming 1\Northwind4\Northwind4\Data\Northwind.mdb";
		}

		public static DBConnection GetanInstance
		{
			get
			{
				if(DBConnection.anInstance == null)
				{
					DBConnection.anInstance = new DBConnection();
				}
				return DBConnection.anInstance;
			}
		}
		 //  Get DataSet
		 public static DataSet GetDataSet
		 {
			 get
			 {
				 return aDataSet;
			 }
		 }

		string aCategorySQL = "SELECT CategoryID, CategoryName, Description FROM Categories ";

		//  Product SQL Call
		string aProductsSQL = "SELECT Products.ProductID, Products.ProductName, Suppliers.CompanyName, Categories.CategoryName, " +
				"Products.QuantityPerUnit, Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, " +
				"Products.Discontinued " +
				"FROM ((Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN Suppliers ON " +
				"Products.SupplierID = Suppliers.SupplierID) ";

		public List<Product> GetProducts()
		{

			int aProductID = -1; // only one with a get
			string aProductName = "n/a";
			string aSupplierID = "n/a";
			string aCategoryID = "n/a";        
			string aQuantityPerUnit = "n/a";
			double aUnitPrice = 1000000000;
			int aUnitsInStock = -1;
			int aUnitsOnOrder = -1;
			int aReorderLevel = -1;
			bool aDiscontinued = false;

			aConnection.Open();

			aCommand.CommandText = aProductsSQL + "ORDER BY Products.ProductID ASC;";

			OleDbDataReader aReader = aCommand.ExecuteReader();

			// Read the data and store it in a list
			while(aReader.Read())
			{

				aProductID = Convert.ToInt32(aReader["ProductID"]);
				aProductName = (string) aReader["ProductName"];
				aSupplierID = (string) aReader["CompanyName"];
				aCategoryID = (string) aReader["CategoryName"];
				aQuantityPerUnit = (string) aReader["QuantityPerUnit"];
				aUnitPrice = (double) (decimal) aReader["UnitPrice"];
				aUnitsInStock = Convert.ToInt32(aReader["UnitsInStock"]);
				aUnitsOnOrder = Convert.ToInt32(aReader["UnitsOnOrder"]);
				aReorderLevel = Convert.ToInt32(aReader["ReorderLevel"]);
				aDiscontinued = (bool) aReader["Discontinued"];
				
				Product aProduct = new Product();

				aProduct.ProductId = aProductID;
				aProduct.ProductName = aProductName;
				aProduct.SupplierId = aSupplierID;
				aProduct.CategoryId = aCategoryID;
				aProduct.QuantityPerUnit = aQuantityPerUnit;
				aProduct.UnitPrice = aUnitPrice;
				aProduct.UnitsInStock = aUnitsInStock;
				aProduct.UnitsOnOrder = aUnitsOnOrder;
				aProduct.ReorderLevel = aReorderLevel;
				aProduct.Discontinued = aDiscontinued;

				aListOfProducts.Add(aProduct);
			}
			// close the connection
			aConnection.Close();
			return aListOfProducts;

		}

        public List<Category> GetCategories(){

			int aCategoryId = -1;
			string aCategoryName = "n/a";
			string aDescription = "n/a";

            aConnection.Open();

			aCommand.CommandText = aCategorySQL + "ORDER BY Categories.CategoryID ASC;"; 

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                aCategoryId = (int)aReader["CategoryID"];
                aCategoryName = (string)aReader["CategoryName"];
                aDescription = (string)aReader["Description"];

                Category aCategory = new Category();

                aCategory.CategoryId = aCategoryId;
                aCategory.CategoryName = aCategoryName;
                aCategory.Description = aDescription;


                aListOfCategories.Add(aCategory);
            }
			// close the connection
			aConnection.Close();
            return aListOfCategories;

        }
    }
}