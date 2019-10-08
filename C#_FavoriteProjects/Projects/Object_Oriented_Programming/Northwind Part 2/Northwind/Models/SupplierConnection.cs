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
	public class SupplierConnection
	{

		//	Call Lists
		List<Supplier> aListOfSuppliers = new List<Supplier>();

		//	By Selection
		List<Supplier> aBySuppliers = new List<Supplier>();

		//	Call Variables
		private Supplier aSupplier = null;

		//	Call Identity Map
		private SupplierIdentityMap aSupplierMap = new SupplierIdentityMap();

		//	Call Connections
		private  static OleDbConnection aConnection = new OleDbConnection();
        private  static OleDbCommand aCommand = aConnection.CreateCommand();
        private  static OleDbDataAdapter anAdapter = new OleDbDataAdapter(aCommand);
		private static DataSet aDataSet = new DataSet();
		private static SupplierConnection anInstance = null;
		
		public static SupplierConnection GetanInstance
        {
            get
            {
                if(SupplierConnection.anInstance == null)
                {
                    SupplierConnection.anInstance = new SupplierConnection();
                }
                return SupplierConnection.anInstance;
            }
        }
		
		public SupplierConnection()
        {
            // This is private which prevents any other code
            // from creating one.
            // No code anywhere -- EXCEPT from within
            // this class -- can create an object 
            // from this class

			// set the connection string
            aConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
			Data Source=C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\Object_Oriented_Programming\Northwind Part 2\Northwind\Data\Northwind.accdb";
           
        }

		//  Get DataSet
		public static DataSet GetDataSet
		{
			get
			{
				return aDataSet;
			}
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
				string aHomePage = dictionary[s].HomePage;

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
	}
}