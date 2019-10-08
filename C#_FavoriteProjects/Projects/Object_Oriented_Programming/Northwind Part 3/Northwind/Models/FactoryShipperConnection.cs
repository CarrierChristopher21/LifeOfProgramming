/*
 *	Author:	Chris Carrier
 *	Date:		5/2/15
 *	Information:	This class pulls the data out of the database for the Factory ShipperConnection and puts it in lists so that 
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
	public class FactoryShipperConnection
	{
		//	Call Lists
		List<Shipper> aListOfShipper = new List<Shipper>();

		//	Call Variables
		private Shipper aShipper = null;

		//	Call Connections
		private static OleDbConnection aConnection = new OleDbConnection();
        private static OleDbCommand aCommand = aConnection.CreateCommand();
        private static OleDbDataAdapter anAdapter = new OleDbDataAdapter(aCommand);
		private static DataSet aDataSet = new DataSet();
		private static FactoryShipperConnection anInstance = null;
		
		public static FactoryShipperConnection GetanInstance
        {
            get
            {
                if(FactoryShipperConnection.anInstance == null)
                {
                    FactoryShipperConnection.anInstance = new FactoryShipperConnection();
                }
                return FactoryShipperConnection.anInstance;
            }
        }

		public FactoryShipperConnection()
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

			// Set the SQL statement
			string aSQL = "SELECT ShipperID, CompanyName, Phone FROM Shippers" + ";";

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
	}
}