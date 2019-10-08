/*
 *	Author:	Chris Carrier
 *	Date:		5/2/15
 *	Information:	This class isn't in use anymore. This class pulls the data out of the database for the Connection and puts 
 *	it in lists so that it can be displayed in the output later. The lists are filtered through command strings.
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
    public class DBConnection
    {
		/* create a List */

		//	Call Lists
		List<Category> aListOfCategories = new List<Category>();
		List<Supplier> aListOfSuppliers = new List<Supplier>();
		List<Shipper> aListOfShipper = new List<Shipper>();
		List<Product> aListOfProduct = new List<Product>();

		//	By Selection
		List<Category> aByCategories = new List<Category>();
		List<Supplier> aBySuppliers = new List<Supplier>();
		List<Shipper> aByShipper = new List<Shipper>();
		List<Product> aByProduct = new List<Product>();

		//	Call Variables
		private Category aCategory = null;	
		private Supplier aSupplier = null;
		private Shipper aShipper = null;
		private Product aProduct = null;

		//	Call Identity Map
        private CategoryIdentityMap aCategoryMap = new CategoryIdentityMap();
		private SupplierIdentityMap aSupplierMap = new SupplierIdentityMap();
		private ShipperIdentityMap aShipperMap = new ShipperIdentityMap();
		private ProductIdentityMap aProductMap = new ProductIdentityMap();

		//	Call Connections
		private  static OleDbConnection aConnection = new OleDbConnection();
        private  static OleDbCommand aCommand = aConnection.CreateCommand();
        private  static OleDbDataAdapter anAdapter = new OleDbDataAdapter(aCommand);
		private static DataSet aDataSet = new DataSet();
		private static DBConnection anInstance = null;
		
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
		
		public DBConnection()
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

        public List<Category> GetCategories()
		{
			int aCategoryId = -1;
			string aCategoryName = "n/a";
			string aDescription = "n/a";

			// open the connection
            aConnection.Open();

            // create a command object
            OleDbCommand aCommand = aConnection.CreateCommand();

            // Set the SQL statement
            string aSQL = "SELECT CategoryId, CategoryName, Description FROM Categories" + ";";

            aCommand.CommandText = aSQL;

            // run the SQL statement
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                aCategoryId = (int)aReader["CategoryId"];
                aCategoryName = (string)aReader["CategoryName"];
                aDescription = (string)aReader["Description"];

                // If the item is not in the dictionary
                // make a new item and add it to the map
                if (aCategoryMap.isInDictionary(aCategoryId) == false) 
				{ 
                    aCategory = new Category(aCategoryId, aCategoryName, aDescription);
                    aCategoryMap.AddCategory(aCategory.CategoryId, aCategory);
                }
                else
                {
                    // the item already exists so get it
                    aCategoryMap.GetCategory(aCategoryId);
                }

                // this adds the category to this list
                // either way
                 aByCategories.Add(aCategory);                
            }

            // close the connection
            aConnection.Close();
			//	Return aListOfCategories
            return aByCategories;
        }		

        public void SaveAllCategories()
        {
            Dictionary<int, Category> dictionary = aCategoryMap.GetDictionary();

            // open the connection
            aConnection.Open();

            // create a command object
            OleDbCommand aCommand = aConnection.CreateCommand();

            // Set the SQL statement
            string aSQL = "";

            foreach (var c in dictionary.Keys)
            {
                int aCategoryId = dictionary[c].CategoryId;
                string aCategoryName = dictionary[c].CategoryName;
                string aDescription = dictionary[c].Description;


                // If the item is not in the dictionary
                // make a new item and add it to the map
                if (dictionary[c].IsDirty == true && dictionary[c].IsValid == true)
                {

                    aSQL = "Update Categories";
                    aSQL = aSQL + "SET CategoryName = " + aCategoryName + ", ";
                    aSQL = aSQL + "Description = " + aDescription + " ";
                    aSQL = aSQL + "WHERE CategoryId = " + aCategoryId;

                    aCommand.CommandText = aSQL;
                    aCommand.ExecuteNonQuery();
                }

            }

            // close the connection
            aConnection.Close();
        }

		public List<Category> GetByCategories(int Id)
		{
			int aCategoryId = -1;
			string aCategoryName = "n/a";
			string aDescription = "n/a";

			// open the connection
			aConnection.Open();

			// create a command object
			OleDbCommand aCommand = aConnection.CreateCommand();

			// Set the SQL statement
			string aSQL = "SELECT CategoryId, CategoryName, Description FROM Categories WHERE CategoryID = " + Id + ";";

			aCommand.CommandText = aSQL;

			// run the SQL statement
			OleDbDataReader aReader = aCommand.ExecuteReader();

			while(aReader.Read())
			{
				aCategoryId = (int) aReader["CategoryID"];
				aCategoryName = (string) aReader["CategoryName"];
				aDescription = (string) aReader["Description"];

				// If the item is not in the dictionary
				// make a new item and add it to the map
				if(aCategoryMap.isInDictionary(aCategoryId) == false)
				{
					aCategory = new Category(aCategoryId, aCategoryName, aDescription);
					aCategoryMap.AddCategory(aCategory.CategoryId, aCategory);
				}
				else
				{
					// the item already exists so get it
					aCategoryMap.GetCategory(aCategoryId);
				}

				// this adds the category to this list
				// either way
				aByCategories.Add(aCategory);
			}

			// close the connection
			aConnection.Close();
			//	Return aListOfCategories
			return aByCategories;
		}

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

			// open the connection
			aConnection.Open();

			// create a command object
			OleDbCommand aCommand = aConnection.CreateCommand();

			// Set the SQL statement
			string aSQL = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, " +
				"Country, Phone, Fax, HomePage FROM Suppliers" + ";";

			aCommand.CommandText = aSQL;

			// run the SQL statement
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

				// If the item is not in the dictionary
				// make a new item and add it to the map
				if(aSupplierMap.isInDictionary(aSupplierId) == false)
				{
					aSupplier = new Supplier(aSupplierId, aCompanyName, aContactName,aContactTitle, aAddress, aCity, 
						aRegion, aPostalCode, aCountry, aPhone, aFax, aHomePage);
					aSupplierMap.AddSupplier(aSupplier.SupplierId, aSupplier);
				}
				else
				{
					// the item already exists so get it
					aSupplierMap.GetSupplier(aSupplierId);
				}

				// this adds the category to this list
				// either way
				aListOfSuppliers.Add(aSupplier);
			}

			// close the connection
			aConnection.Close();
			//	Return aListOfCategories
			return aListOfSuppliers;
		}

		public void SaveAllSuppliers()
		{
			Dictionary<int, Supplier> dictionary = aSupplierMap.GetDictionary();

			// open the connection
			aConnection.Open();

			// create a command object
			OleDbCommand aCommand = aConnection.CreateCommand();

			// Set the SQL statement
			string aSQL = "";

			foreach(var s in dictionary.Keys)
			{
				int aSupplierId = dictionary[s].SupplierId;              //  Supplier ID
				string aCompanyName = dictionary[s].CompanyName;
				string aContactName = dictionary[s].ContactName;
				string aContactTitle = dictionary[s].ContactTitle;
				string aAddress = dictionary[s].Address;
				string aCity = dictionary[s].City;
				string aRegion = dictionary[s].Region;
				string aPostalCode = dictionary[s].PostalCode;
				string aCountry = dictionary[s].Country;
				string aPhone = dictionary[s].Phone;
				string aFax = dictionary[s].Fax;
				string aHomePage =dictionary[s].HomePage;

				// If the item is not in the dictionary
				// make a new item and add it to the map
				if(dictionary[s].IsDirty == true && dictionary[s].IsValid == true)
				{

					aSQL = "Update Suppliers";
					aSQL = aSQL + "SET Company Name = " + aCompanyName + ", ";
					aSQL = aSQL + "Contact Title = " + aContactTitle + " ";
					aSQL = aSQL + "Address = " + aAddress + " ";
					aSQL = aSQL + "City = " + aCity + " ";
					aSQL = aSQL + "Region = " + aRegion + " ";
					aSQL = aSQL + "Postal Code = " + aPostalCode + " ";
					aSQL = aSQL + "Country = " + aCountry + " ";
					aSQL = aSQL + "Phone = " + aPhone + " ";
					aSQL = aSQL + "Fax = " + aFax + " ";
					aSQL = aSQL + "Home Page = " + aHomePage + " ";
					aSQL = aSQL + "WHERE SupplierId = " + aSupplierId;

					aCommand.CommandText = aSQL;
					aCommand.ExecuteNonQuery();
				}
			}
			// close the connection
			aConnection.Close();
		}

		public List<Supplier> GetBySuppliers(int Id)
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

			// open the connection
			aConnection.Open();

			// create a command object
			OleDbCommand aCommand = aConnection.CreateCommand();

			// Set the SQL statement
			string aSQL = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, " +
				"Country, Phone, Fax, HomePage FROM Suppliers WHERE SupplierID = " + Id + ";";

			aCommand.CommandText = aSQL;

			// run the SQL statement
			OleDbDataReader aReader = aCommand.ExecuteReader();

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

				// If the item is not in the dictionary
				// make a new item and add it to the map
				if(aSupplierMap.isInDictionary(aSupplierId) == false)
				{
					aSupplier = new Supplier(aSupplierId, aCompanyName, aContactName, aContactTitle, aAddress, aCity,
						aRegion, aPostalCode, aCountry, aPhone, aFax, aHomePage);
					aSupplierMap.AddSupplier(aSupplier.SupplierId, aSupplier);
				}
				else
				{
					// the item already exists so get it
					aSupplierMap.GetSupplier(aSupplierId);
				}

				// this adds the category to this list
				// either way
				aBySuppliers.Add(aSupplier);
			}

			// close the connection
			aConnection.Close();
			//	Return aListOfCategories
			return aBySuppliers;
		}

		//	Get Shippers
		public List<Shipper> GetShippers()
		{
			int aShipperId = -1;          //  Shipper Number
			string aCompanyName = "n/a";
			string aPhone = "n/a";


			// open the connection
			aConnection.Open();

			// create a command object
			OleDbCommand aCommand = aConnection.CreateCommand();

			// Set the SQL statement
			string aSQL = "SELECT ShipperID, CompanyName, Phone FROM Shippers" + ";";

			aCommand.CommandText = aSQL;

			// run the SQL statement
			OleDbDataReader aReader = aCommand.ExecuteReader();

			while(aReader.Read())
			{
				aShipperId = Convert.ToInt32(aReader["ShipperID"]);
				aCompanyName = (string) aReader["CompanyName"];
				aPhone = (string) aReader["Phone"];

				// If the item is not in the dictionary
				// make a new item and add it to the map
				if(aShipperMap.isInDictionary(aShipperId) == false)
				{
					aShipper = new Shipper(aShipperId, aCompanyName, aPhone);
					aShipperMap.AddShipper(aShipper.ShipperId, aShipper);
				}
				else
				{
					// the item already exists so get it
					aShipperMap.GetShipper(aShipperId);
				}

				// this adds the category to this list
				// either way
				aListOfShipper.Add(aShipper);
			}

			// close the connection
			aConnection.Close();
			//	Return aListOfCategories
			return aListOfShipper;
		}

		public void SaveAllShippers()
		{
			Dictionary<int, Shipper> dictionary = aShipperMap.GetDictionary();

			// open the connection
			aConnection.Open();

			// create a command object
			OleDbCommand aCommand = aConnection.CreateCommand();

			// Set the SQL statement
			string aSQL = "";

			foreach(var s in dictionary.Keys)
			{
				int aShipperId = dictionary[s].ShipperId;              //  Supplier ID
				string aCompanyName = dictionary[s].CompanyName;
				string aPhone = dictionary[s].Phone;

				// If the item is not in the dictionary
				// make a new item and add it to the map
				if(dictionary[s].IsDirty == true && dictionary[s].IsValid == true)
				{

					aSQL = "Update Shippers";
					aSQL = aSQL + "SET Company Name = " + aCompanyName + ", ";
					aSQL = aSQL + "Phone = " + aPhone + " ";
					aSQL = aSQL + "WHERE ShipperId = " + aShipperId;

					aCommand.CommandText = aSQL;
					aCommand.ExecuteNonQuery();
				}
			}
			// close the connection
			aConnection.Close();
		}

		public List<Shipper> GetByShippers(int id)
		{
			int aShipperId = -1;          //  Shipper Number
			string aCompanyName = "n/a";
			string aPhone = "n/a";


			// open the connection
			aConnection.Open();

			// create a command object
			OleDbCommand aCommand = aConnection.CreateCommand();

			// Set the SQL statement
			string aSQL = "SELECT ShipperID, CompanyName, Phone FROM Shippers WHERE ShipperID = " + id + ";";

			aCommand.CommandText = aSQL;

			// run the SQL statement
			OleDbDataReader aReader = aCommand.ExecuteReader();

			while(aReader.Read())
			{
				aShipperId = Convert.ToInt32(aReader["ShipperID"]);
				aCompanyName = (string) aReader["CompanyName"];
				aPhone = (string) aReader["Phone"];

				// If the item is not in the dictionary
				// make a new item and add it to the map
				if(aShipperMap.isInDictionary(aShipperId) == false)
				{
					aShipper = new Shipper(aShipperId, aCompanyName, aPhone);
					aShipperMap.AddShipper(aShipper.ShipperId, aShipper);
				}
				else
				{
					// the item already exists so get it
					aShipperMap.GetShipper(aShipperId);
				}

				// this adds the category to this list
				// either way
				aByShipper.Add(aShipper);
			}

			// close the connection
			aConnection.Close();
			//	Return aListOfCategories
			return aByShipper;
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
                aProductName = (string)aReader["ProductName"];
                aSupplierId = (string) aReader["CompanyName"];
                aCategoryId = (string) aReader["CategoryName"];
                aQuantityPerUnit = (string)aReader["QuantityPerUnit"];
                aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                aUnitsInStock = Convert.ToInt32(aReader["UnitsInStock"]);
                aUnitsOnOrder = Convert.ToInt32(aReader["UnitsOnOrder"]);
                aReorderLevel = Convert.ToInt32(aReader["ReorderLevel"]);
                aDiscontinued = (bool)aReader["Discontinued"];

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
				"WHERE Products.UnitPrice >= "  + pricemin + " AND Products.UnitPrice <= " + pricemax + ";";

			aCommand.CommandText = aSQL;

			// run the SQL statement
			OleDbDataReader aReader = aCommand.ExecuteReader();

			while(aReader.Read())
			{
				aProductId = Convert.ToInt32(aReader["ProductID"]);
				aProductName = (string) aReader["ProductName"];
				aSupplierId = (string)aReader["CompanyName"];
				aCategoryId = (string)aReader["CategoryName"];
				aQuantityPerUnit = (string) aReader["QuantityPerUnit"];
				aUnitPrice = (double)(decimal) aReader["UnitPrice"];
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


		/*	Single File Filter Needs Work
		public List<Category> GetCategoryFile()
		{
			// open the connection
			aConnection.Open();

			// create a command object
			OleDbCommand aCommand = aConnection.CreateCommand();

			// Set the SQL statement
			string aSQL = "SELECT CategoryId, CategoryName, Description FROM Categories";

			aCommand.CommandText = aSQL;

			// run the SQL statement
			OleDbDataReader aReader = aCommand.ExecuteReader();

			while(aReader.Read())
			{
				int aCategoryId = (int) aReader["CategoryId"];
				string aCategoryName = (string) aReader["CategoryName"];
				string aDescription = (string) aReader["Description"];

				// If the item is not in the dictionary
				// make a new item and add it to the map
				if(aMap.isInDictionary(aCategoryId) == false)
				{
					aCategory = new Category(aCategoryId, aCategoryName, aDescription);
					aMap.AddCategory(aCategory.CategoryId, aCategory);
				}
				else
				{
					// the item already exists so get it
					aMap.GetCategory(aCategoryId);
				}

				// this adds the category to this list
				// either way
				aListOfCategories.Add(aCategory);
			}

			// close the connection
			aConnection.Close();
			//	Return aListOfCategories
			return aListOfCategories;
		}*/