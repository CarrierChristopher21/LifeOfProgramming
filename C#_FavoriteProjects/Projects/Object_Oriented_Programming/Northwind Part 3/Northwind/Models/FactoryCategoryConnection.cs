/*
 *	Author:	Chris Carrier
 *	Date:		5/2/15
 *	Information:	This class pulls the data out of the database for the Factory CategoryConnection and puts it in lists so that 
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
	public class FactoryCategoryConnection
	{
		//	Call Variables
		private Category aCategory = null;	

		//	Call Lists
		List<Category> aListOfCategories = new List<Category>();

		//	By Selection
		List<Category> aByCategories = new List<Category>();
		
		//	Call Connections
		private static OleDbConnection aConnection = new OleDbConnection();
        private static OleDbCommand aCommand = aConnection.CreateCommand();
        private static OleDbDataAdapter anAdapter = new OleDbDataAdapter(aCommand);
		private static DataSet aDataSet = new DataSet();
		private static FactoryCategoryConnection anInstance = null;
		
		public static FactoryCategoryConnection GetanInstance
        {
            get
            {
                if(FactoryCategoryConnection.anInstance == null)
                {
                    FactoryCategoryConnection.anInstance = new FactoryCategoryConnection();
                }
                return FactoryCategoryConnection.anInstance;
            }
        }

		public FactoryCategoryConnection()
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
			string aSQL = "SELECT CategoryId, CategoryName, Description FROM Categories" + ";";


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
	}
}