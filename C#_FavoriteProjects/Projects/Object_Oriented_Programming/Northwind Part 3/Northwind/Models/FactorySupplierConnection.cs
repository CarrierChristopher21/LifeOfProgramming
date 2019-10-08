/*
 *	Author:	Chris Carrier
 *	Date:		5/2/15
 *	Information:	This class pulls the data out of the database for the Factory SupplierConnection and puts it in lists so that 
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
	public class FactorySupplierConnection
	{
		//	Declare Variables
		private Supplier aSupplier = null;

		//	Call List
		List<Supplier> aListOfSuppliers = new List<Supplier>();

		//	Call By Selection
		List<Supplier> aBySuppliers = new List<Supplier>();

		//	Call Connections
		private static OleDbConnection aConnection = new OleDbConnection();
        private static OleDbCommand aCommand = aConnection.CreateCommand();
        private static OleDbDataAdapter anAdapter = new OleDbDataAdapter(aCommand);
		private static DataSet aDataSet = new DataSet();
		private static FactorySupplierConnection anInstance = null;

		public static FactorySupplierConnection GetanInstance
        {
            get
            {
				if(FactorySupplierConnection.anInstance == null)
                {
					FactorySupplierConnection.anInstance = new FactorySupplierConnection();
                }
				return FactorySupplierConnection.anInstance;
            }
        }

		public FactorySupplierConnection()
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

			string aSQL = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, " +
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

	}
}