/*
 *	Author:	Chris Carrier
 *	Date:		1/15/15
 *	Information:	This class pulls the data out of the database and puts it in lists so that it can be displayed in the
 *	output later. The lists are filtered through command strings. This class isn't in use anymore.
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
	public class OleDbUtilityLoader
	{
		//	Call Lists
		List<Category> aListOfCategories = new List<Category>();
		List<Supplier> aListOfSuppliers = new List<Supplier>();
		List<Shipper> aListOfShipper = new List<Shipper>();
		List<Product> aListOfProduct = new List<Product>();

		//	By Selection
		List<Product> aByProduct = new List<Product>();

		//	Call Variables
		private Category aCategory = null;	
		private Supplier aSupplier = null;
		private Shipper aShipper = null;
		private Product aProduct = null;
		string aSQL = "n/a";


		//	Call Connections
		private static OleDbConnection aConnection = new OleDbConnection();
        private static OleDbCommand aCommand = aConnection.CreateCommand();
        private static OleDbDataAdapter anAdapter = new OleDbDataAdapter(aCommand);
		private static DataSet aDataSet = new DataSet();
		private static OleDbUtilityLoader anInstance = null;
		
		public static OleDbUtilityLoader GetanInstance
        {
            get
            {
                if(OleDbUtilityLoader.anInstance == null)
                {
                    OleDbUtilityLoader.anInstance = new OleDbUtilityLoader();
                }
                return OleDbUtilityLoader.anInstance;
            }
        }

		public OleDbUtilityLoader()
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

		//	Get Category
		public List<Category> GetCategories()
		{
			int aCategoryId = -1;
			string aCategoryName = "n/a";
			string aDescription = "n/a";

			// Set the SQL statement
			aSQL = "SELECT CategoryId, CategoryName, Description FROM Categories" + ";";


			//Implement the factories and create the reader
			NWAbstractFactory aFactory = new NWOleDBFactory();

			//NWAbstractFactory aFactory = new NWOleDbFactory();
			INWDataReader aNWReader = aFactory.CreateReader(aSQL);

			IDataReader aReader = aNWReader.aDataReader;

			//Loops through information from the database
			while(aReader.Read())
			{

				aCategoryId = (int) aReader["CategoryId"];
				aCategoryName = (string) aReader["CategoryName"];
				aDescription = (string) aReader["Description"];

				aCategory = new Category(aCategoryId, aCategoryName, aDescription);

				aListOfCategories.Add(aCategory);
			}
			//	Return aListOfCategories
			return aListOfCategories;
		}		

		//	Get Supplier
		public List<Supplier> GetSuppliers()
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

			// Set the SQL statement
			aSQL = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, " +
				"Country, Phone, Fax, HomePage FROM Suppliers" + ";";


				//Implement the factories and create the reader
				NWAbstractFactory aFactory = new NWOleDBFactory();

				//NWAbstractFactory aFactory = new NWOleDbFactory();
				INWDataReader aNWReader = aFactory.CreateReader(aSQL);
				
				IDataReader aReader = aNWReader.aDataReader;

				//Loop through database information
				while(aReader.Read())
				{

					aSupplierId = Convert.ToInt32(aReader["SupplierID"]);
					aCompanyName = (string) aReader["CompanyName"];
					aContactName = (string) aReader["ContactName"];
					aContactTitle = (string) aReader["ContactTitle"];
					aAddress = (string) aReader["Address"];
					aCity = (string) aReader["City"];
					aRegion = Convert.ToString(aReader["Region"]) ?? "n/a";
					aPostalCode = (string) aReader["PostalCode"];
					aCountry = (string) aReader["Country"];
					aPhone = (string) aReader["Phone"];
					aFax = Convert.ToString(aReader["Fax"]) ?? "n/a";
					aHomePage = Convert.ToString(aReader["HomePage"]) ?? "n/a";

					aSupplier = new Supplier(aSupplierId, aCompanyName, aContactName, aContactTitle, aAddress, aCity,
						aRegion, aPostalCode, aCountry, aPhone, aFax, aHomePage);

					// this adds the category to this list
					// either way
					aListOfSuppliers.Add(aSupplier);
				}
				
			//	Return aListOfCategories
			return aListOfSuppliers;
		}
		
		//	Get Shippers
		public List<Shipper> GetShippers()
		{
			int aShipperId = -1;          //  Shipper Number
			string aCompanyName = "n/a";
			string aPhone = "n/a";

			// Set the SQL statement
			aSQL = "SELECT ShipperID, CompanyName, Phone FROM Shippers" + ";";

			//Implement the factories and create the reader
            NWAbstractFactory aFactory = new NWOleDBFactory();

            //NWAbstractFactory aFactory = new NWOleDbFactory();
            INWDataReader aNWReader = aFactory.CreateReader(aSQL);
            IDataReader aReader = aNWReader.aDataReader;

			while(aReader.Read())
			{
				aShipperId = Convert.ToInt32(aReader["ShipperID"]);
				aCompanyName = (string) aReader["CompanyName"];
				aPhone = (string) aReader["Phone"];

				aShipper = new Shipper(aShipperId, aCompanyName, aPhone);


				// this adds the category to this list
				// either way
				aListOfShipper.Add(aShipper);
			}

			//	Return aListOfCategories
			return aListOfShipper;
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