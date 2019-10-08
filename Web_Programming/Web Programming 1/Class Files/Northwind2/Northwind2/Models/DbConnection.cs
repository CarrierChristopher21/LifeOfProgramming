using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data.Odbc;

namespace Northwind2.Models
{
    public sealed class DbConnection
    {
        // one connection for every class -- we want to enforce this statement

        private static DbConnection instance = null;

        private DbConnection() {}

         public static DbConnection Instance
        {

             get
            {
                if (instance == null)
                {
                    instance = new DbConnection();
                }

                return instance;
            
            }
        }




        private List<Category> aListOfCategories = new List<Category>();

        public List<Category> GetCategories(){

            OleDbConnection aConnection = new OleDbConnection();

            string aSQL = "SELECT CategoryId, CategoryName, Description FROM Categories;";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\burkejc\Documents\Visual Studio 2013\Projects\Northwind2\Northwind2\Northwind.mdb;";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aCategoryId = (int)aReader["CategoryId"];
                string aCategoryName = (string)aReader["CategoryName"];
                string aDescription = (string)aReader["Description"];

                Category aCategory = new Category(aCategoryId, aCategoryName, aDescription);

                aListOfCategories.Add(aCategory);
            }

            return aListOfCategories;

        }
    }
}