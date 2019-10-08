/*	Author: Chris Carrier
 *	Date:	1/15/15
 *	Information: This class is to establish a connection to the Northwind database and to be used for the Shipper Table, as
 *	well as the Shipper portion of this database program. It uses the OleDbConnection setup to establish the connection.
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
	public class ShipperConnection
	{
		// Call List
		List<Shipper> aListOfShipper = new List<Shipper>();

		//	By Selection
		List<Shipper> aByShipper = new List<Shipper>();

		//	Call Variables
		private Shipper aShipper = null;

		//	Call Identity Map
		private ShipperIdentityMap aShipperMap = new ShipperIdentityMap();

		//	Call Connections
		private static OleDbConnection aConnection = new OleDbConnection();
		private static OleDbCommand aCommand = aConnection.CreateCommand();
		private static OleDbDataAdapter anAdapter = new OleDbDataAdapter(aCommand);
		private static DataSet aDataSet = new DataSet();
		private static ShipperConnection anInstance = null;

		public static ShipperConnection GetanInstance
        {
            get
            {
				if(ShipperConnection.anInstance == null)
                {
					ShipperConnection.anInstance = new ShipperConnection();
                }
				return ShipperConnection.anInstance;
            }
        }
		
		public ShipperConnection()
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
					aSQL = aSQL + "SET Company Name = " + aCompanyName + "', ";
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

	}
}