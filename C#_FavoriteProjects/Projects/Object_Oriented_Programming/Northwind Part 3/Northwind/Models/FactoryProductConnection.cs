/*
 *	Author:	Chris Carrier
 *	Date:		5/2/15
 *	Information:	This class pulls the data out of the database for the Factory ProductConnection and puts it in lists so that 
 *	it can be displayed in the output later. The lists are filtered through command strings.
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
	public class FactoryProductConnection
	{
		//	Call Lists
		List<Product> aListOfProduct = new List<Product>();

		//	By Selection
		List<Product> aByProduct = new List<Product>();
		
		//	Call Variables
		private Product aProduct = null;
		string aSQL = "n/a";

		//	Call Connections
		private static OleDbConnection aConnection = new OleDbConnection();
        private static OleDbCommand aCommand = aConnection.CreateCommand();
        private static OleDbDataAdapter anAdapter = new OleDbDataAdapter(aCommand);
		private static DataSet aDataSet = new DataSet();
		private static FactoryProductConnection anInstance = null;
		
		public static FactoryProductConnection GetanInstance
        {
            get
            {
                if(FactoryProductConnection.anInstance == null)
                {
                    FactoryProductConnection.anInstance = new FactoryProductConnection();
                }
                return FactoryProductConnection.anInstance;
            }
        }

		public FactoryProductConnection()
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
		public List<Product> GetProducts()
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

			// Set the SQL statement
			aSQL = "SELECT Products.ProductID, Products.ProductName, Suppliers.CompanyName, Categories.CategoryName, " +
				"Products.QuantityPerUnit, Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, " +
				"Products.Discontinued " +
				"FROM ((Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN Suppliers ON " +
				"Products.SupplierID = Suppliers.SupplierID) " +
				"ORDER BY Products.ProductID ASC;";

			//Implement the factories and create the reader
			NWAbstractFactory aFactory = new NWOleDBFactory();

			//NWAbstractFactory aFactory = new NWOleDbFactory();
			INWDataReader aNWReader = aFactory.CreateReader(aSQL);

			IDataReader aReader = aNWReader.aDataReader;

			//Loop through database information
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


				Product aProduct = new Product(aProductId, aProductName, aSupplierId, aCategoryId, aQuantityPerUnit, aUnitPrice,
						aUnitsInStock, aUnitsOnOrder, aReorderLevel, aDiscontinued);

				aListOfProduct.Add(aProduct);
			}

			//	Return aListOfCategories
			return aListOfProduct;
		}

		//	List Product
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

			// Set the SQL statement
			aSQL = "SELECT Products.ProductID, Products.ProductName, Suppliers.CompanyName, Categories.CategoryName, " +
				"Products.QuantityPerUnit, Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, " +
				"Products.Discontinued " +
				"FROM ((Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN Suppliers ON " +
					"Products.SupplierID = Suppliers.SupplierID) " +
				"WHERE Products.UnitPrice >= " + pricemin + " AND Products.UnitPrice <= " + pricemax + ";";
			

			//Implement the factories and create the reader
			NWAbstractFactory aFactory = new NWOleDBFactory();

			//NWAbstractFactory aFactory = new NWOleDbFactory();
			INWDataReader aNWReader = aFactory.CreateReader(aSQL);

			IDataReader aReader = aNWReader.aDataReader;


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

				aProduct = new Product(aProductId, aProductName, aSupplierId, aCategoryId, aQuantityPerUnit, aUnitPrice,
					aUnitsInStock, aUnitsOnOrder, aReorderLevel, aDiscontinued);

				// this adds the category to this list
				// either way
				aByProduct.Add(aProduct);
			}

			//	Return aListOfCategories
			return aByProduct;
		}

	}
}