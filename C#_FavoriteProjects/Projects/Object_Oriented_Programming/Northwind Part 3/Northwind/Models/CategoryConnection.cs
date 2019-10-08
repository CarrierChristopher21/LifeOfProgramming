/*	Author: Chris Carrier
 *	Date:	1/15/15
 *	Information: This class is to establish a connection to the Northwind database and to be used for the Category Table, as
 *	well as the Category portion of this database program. It uses the OleDbConnection setup to establish the connection.
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
	public class CategoryConnection
	{
		//	Call Lists
		List<Category> aListOfCategories = new List<Category>();

		//	By Selection
		List<Category> aByCategories = new List<Category>();

		//Call Variables
		private Category aCategory = null;

		//	Call Identity Map
		private CategoryIdentityMap aCategoryMap = new CategoryIdentityMap();

		//	Call Connections
		private static OleDbConnection aConnection = new OleDbConnection();
		private static OleDbCommand aCommand = aConnection.CreateCommand();
		private static OleDbDataAdapter anAdapter = new OleDbDataAdapter(aCommand);
		private static DataSet aDataSet = new DataSet();
		private static CategoryConnection anInstance = null;

		public static CategoryConnection GetanInstance
        {
            get
            {
				if(CategoryConnection.anInstance == null)
                {
					CategoryConnection.anInstance = new CategoryConnection();
                }
				return CategoryConnection.anInstance;
            }
        }
		
		public CategoryConnection()
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

			while(aReader.Read())
			{
				aCategoryId = (int) aReader["CategoryId"];
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
				aListOfCategories.Add(aCategory);
			}

			// close the connection
			aConnection.Close();
			//	Return aListOfCategories
			return aListOfCategories;
		}

		public void SaveAllCategories()
		{
			int aCategoryId = -1;
			string aCategoryName = "n/a";
			string aDescription = "n/a";

			Dictionary<int, Category> dictionary = aCategoryMap.GetDictionary();

			// open the connection
			aConnection.Open();

			// create a command object
			OleDbCommand aCommand = aConnection.CreateCommand();

			// Set the SQL statement
			string aSQL = "";

			foreach(var c in dictionary.Keys)
			{
				aCategoryId = dictionary[c].CategoryId;
				aCategoryName = dictionary[c].CategoryName;
				aDescription = dictionary[c].Description;


				// If the item is not in the dictionary
				// make a new item and add it to the map
				if(dictionary[c].IsDirty == true && dictionary[c].IsValid == true)
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
			//	Return aByCategories
			return aByCategories;
		}

	}
}