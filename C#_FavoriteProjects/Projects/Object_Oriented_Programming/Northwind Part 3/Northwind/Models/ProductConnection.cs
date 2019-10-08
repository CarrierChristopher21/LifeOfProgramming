/*	Author: Chris Carrier
 *	Date:	1/15/15
 *	Information: This class is to establish a connection to the Northwind database. Also, to be used for the Product Table, as
 *	well as the Product portion of this database program. It uses the OleDbConnection setup to establish the connection.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.Odbc;

namespace Northwind.Models
{
	public class ProductConnection
	{
		//	Call Lists
		List<Product> aListOfProduct = new List<Product>();

		//	By Selection
		List<Product> aByProduct = new List<Product>();

		//	Call Variables
		private Product aProduct = null;

		//	Call Identity Map
		private ProductIdentityMap aProductMap = new ProductIdentityMap();

				//	Call Connections
		private  static OleDbConnection aConnection = new OleDbConnection();
        private  static OleDbCommand aCommand = aConnection.CreateCommand();
        private  static OleDbDataAdapter anAdapter = new OleDbDataAdapter(aCommand);
		private static DataSet aDataSet = new DataSet();
		private static ProductConnection anInstance = null;
		
		public static ProductConnection GetanInstance
        {
            get
            {
                if(ProductConnection.anInstance == null)
                {
                    ProductConnection.anInstance = new ProductConnection();
                }
                return ProductConnection.anInstance;
            }
        }
		
		public ProductConnection()
        {
            // This is private which prevents any other code
            // from creating one.
            // No code anywhere -- EXCEPT from within
            // this class -- can create an object 
            // from this class

			// set the connection string
            aConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
			Data Source=C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\Object_Oriented_Programming\Northwind Part 3\Northwind\Data\Northwind.accdb";
           
        }

		//  Get DataSet
		public static DataSet GetDataSet
		{
			get
			{
				return aDataSet;
			}
		}

		//	Get Price
		public List<Product> GetProduct()
		{
			int aProductId = -1; // only one with a get
			string aProductName = "n/a";
			string aSupplierId = "n/a";
			string aCategoryId = "n/a";
			string aQuantityPerUnit = "n/a";
			double aUnitPrice = 1000000000;
			int aUnitsInStock = -1;
			int aUnitsOnOrder = -1;
			int aReorderLevel = -1;
			bool aDiscontinued = false;

			// open the connection
			aConnection.Open();

			// create a command object
			OleDbCommand aCommand = aConnection.CreateCommand();

			// Set the SQL statement
			string aSQL = "SELECT Products.ProductID, Products.ProductName, Suppliers.CompanyName, Categories.CategoryName, " +
				"Products.QuantityPerUnit, Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, " +
				"Products.Discontinued " +
				"FROM ((Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN Suppliers ON " +
				"Products.SupplierID = Suppliers.SupplierID) " +
				"ORDER BY Products.ProductID ASC;";

			aCommand.CommandText = aSQL;

			// run the SQL statement
			OleDbDataReader aReader = aCommand.ExecuteReader();

			while(aReader.Read())
			{
				aProductId = Convert.ToInt32(aReader["ProductID"]);
				aProductName = (string) aReader["ProductName"];
				aSupplierId = (string) aReader["CompanyName"];
				aCategoryId = (string) aReader["CategoryName"];
				aQuantityPerUnit = (string) aReader["QuantityPerUnit"];
				aUnitPrice = (double) (decimal) aReader["UnitPrice"];
				aUnitsInStock = Convert.ToInt32(aReader["UnitsInStock"]);
				aUnitsOnOrder = Convert.ToInt32(aReader["UnitsOnOrder"]);
				aReorderLevel = Convert.ToInt32(aReader["ReorderLevel"]);
				aDiscontinued = (bool) aReader["Discontinued"];

				// If the item is not in the dictionary
				// make a new item and add it to the map
				if(aProductMap.isInDictionary(aProductId) == false)
				{
					aProduct = new Product(aProductId, aProductName, aSupplierId, aCategoryId, aQuantityPerUnit, aUnitPrice,
						aUnitsInStock, aUnitsOnOrder, aReorderLevel, aDiscontinued);
					aProductMap.AddProduct(aProduct.ProductId, aProduct);
				}
				else
				{
					// the item already exists so get it
					aProductMap.GetProduct(aProductId);
				}

				// this adds the category to this list
				// either way
				aListOfProduct.Add(aProduct);
			}

			// close the connection
			aConnection.Close();
			//	Return aListOfCategories
			return aListOfProduct;
		}

		public void SaveAllProducts()
		{
			Dictionary<int, Product> dictionary = aProductMap.GetDictionary();

			// open the connection
			aConnection.Open();

			// create a command object
			OleDbCommand aCommand = aConnection.CreateCommand();

			// Set the SQL statement
			string aSQL = "";

			foreach(var p in dictionary.Keys)
			{
				int aProductId = dictionary[p].ProductId;              //  Product ID
				string aProductName = dictionary[p].ProductName;
				string aSupplierId = dictionary[p].SupplierId;
				string aCategoryId = dictionary[p].CategoryId;
				string aQuantityPerUnit = dictionary[p].QuantityPerUnit;
				double aUnitPrice = dictionary[p].UnitPrice;
				int aUnitsInStock = dictionary[p].UnitsInStock;
				int aUnitsOnOrder = dictionary[p].UnitsOnOrder;
				int aReorderLevel = dictionary[p].ReorderLevel;
				bool aDiscontinued = dictionary[p].Discontinued;

				// If the item is not in the dictionary
				// make a new item and add it to the map
				if(dictionary[p].IsDirty == true && dictionary[p].IsValid == true)
				{

					aSQL = "Update Products";
					aSQL = aSQL + "SET Product Name = " + aProductName + ", ";
					aSQL = aSQL + "Company Name = " + aSupplierId + ", ";
					aSQL = aSQL + "Category Name = " + aCategoryId + ", ";
					aSQL = aSQL + "Quantity Per Unit = " + aQuantityPerUnit + ", ";
					aSQL = aSQL + "WHERE UnitPrice = " + aUnitPrice + " ";
					aSQL = aSQL + "UnitsInStock = " + aUnitsInStock + " ";
					aSQL = aSQL + "UnitsOnOrder = " + aUnitsOnOrder + " ";
					aSQL = aSQL + "ReorderLevel = " + aReorderLevel + " ";
					aSQL = aSQL + "Discontinued = " + aDiscontinued + " ";

					aCommand.CommandText = aSQL;
					aCommand.ExecuteNonQuery();
				}
			}
			// close the connection
			aConnection.Close();
		}

		public List<Product> GetByProducts(double pricemin, double pricemax)
		{
			int aProductId = -1; // only one with a get
			string aProductName = "n/a";
			string aSupplierId = "n/a";
			string aCategoryId = "n/a";
			string aQuantityPerUnit = "n/a";
			double aUnitPrice = 1000000000;
			int aUnitsInStock = -1;
			int aUnitsOnOrder = -1;
			int aReorderLevel = -1;
			bool aDiscontinued = false;


			// open the connection
			aConnection.Open();

			// create a command object
			OleDbCommand aCommand = aConnection.CreateCommand();

			// Set the SQL statement
			string aSQL = "SELECT Products.ProductID, Products.ProductName, Suppliers.CompanyName, Categories.CategoryName, " +
				"Products.QuantityPerUnit, Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, " +
				"Products.Discontinued " +
				"FROM ((Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN Suppliers ON " +
					"Products.SupplierID = Suppliers.SupplierID) " +
				"WHERE Products.UnitPrice >= " + pricemin + " AND Products.UnitPrice <= " + pricemax + ";";

			aCommand.CommandText = aSQL;

			// run the SQL statement
			OleDbDataReader aReader = aCommand.ExecuteReader();

			while(aReader.Read())
			{
				aProductId = Convert.ToInt32(aReader["ProductID"]);
				aProductName = (string) aReader["ProductName"];
				aSupplierId = (string) aReader["CompanyName"];
				aCategoryId = (string) aReader["CategoryName"];
				aQuantityPerUnit = (string) aReader["QuantityPerUnit"];
				aUnitPrice = (double) (decimal) aReader["UnitPrice"];
				aUnitsInStock = Convert.ToInt32(aReader["UnitsInStock"]);
				aUnitsOnOrder = Convert.ToInt32(aReader["UnitsOnOrder"]);
				aReorderLevel = Convert.ToInt32(aReader["ReorderLevel"]);
				aDiscontinued = (bool) aReader["Discontinued"];

				// If the item is not in the dictionary
				// make a new item and add it to the map
				if(aProductMap.isInDictionary(aProductId) == false)
				{
					aProduct = new Product(aProductId, aProductName, aSupplierId, aCategoryId, aQuantityPerUnit, aUnitPrice,
						aUnitsInStock, aUnitsOnOrder, aReorderLevel, aDiscontinued);
					aProductMap.AddProduct(aProduct.ProductId, aProduct);
				}
				else
				{
					// the item already exists so get it
					aProductMap.GetProduct(aProductId);
				}

				// this adds the category to this list
				// either way
				aByProduct.Add(aProduct);
			}

			// close the connection
			aConnection.Close();
			//	Return aListOfCategories
			return aByProduct;
		}
	}
}