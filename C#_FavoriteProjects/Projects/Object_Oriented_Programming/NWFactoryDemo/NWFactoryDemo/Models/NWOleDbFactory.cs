using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.Odbc;

namespace NWFactoryDemo.Models
{
	public class NWOleDbFactory:NWAbstractFactory
	{
		private NWOleDbDataReader aNWReader = new NWOleDbDataReader();
		private NWOleDbDataSet aNWDataSet = new NWOleDbDataSet();

		public override INWDataReader CreateReader(string aSQL)
		{
			// create the connection object
			OleDbConnection aConnection = new OleDbConnection();

			// set the connection string
			aConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sarah\Documents\Northwind.accdb";

			// open the connection
			aConnection.Open();

			// create a command object
			OleDbCommand aCommand = aConnection.CreateCommand();

			// run the SQL statement
			aCommand.CommandText = aSQL;
			OleDbDataReader aReader = aCommand.ExecuteReader();


			aNWReader.aDataReader = aReader;

			return aNWReader;
		}



		public override INWDataSet CreatDataSet(string aSQL)
		{
			// create the connection object
			OleDbConnection aConnection = new OleDbConnection();

			// set the connection
			aConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data; 
			Source=C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\Object_Oriented_Programming\NWFactoryDemo\NWFactoryDemo\Data\Northwind.accdb";

			// open the connection
			aConnection.Open();

			// create a command object
			OleDbCommand aCommand = aConnection.CreateCommand();
			aCommand.CommandText = aSQL;

			// run the SQL statement
			OleDbDataAdapter anAdapter = new OleDbDataAdapter(aCommand);
			anAdapter.Fill(aNWDataSet.aDataSet);

			return aNWDataSet;


		}
	}
}