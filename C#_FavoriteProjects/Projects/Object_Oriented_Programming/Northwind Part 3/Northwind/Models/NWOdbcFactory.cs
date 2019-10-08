/*
 * Author:	Chris Carrier
 * Date:	1/15/15
 * Information:	This factory will take the information from the NWDataSet and the NWReader which will implement the 
 * interfaces. As well as overrides the methods in the abstract factory. The functioning code and the code that   
 * is most often updated would go in this class. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.Odbc;


namespace Northwind.Models
{
	public class NWOdbcFactory
	{
		private NWOdbcDataReader aNWReader = new NWOdbcDataReader();
		private NWOdbcDataSet aNWDataSet = new NWOdbcDataSet();

		public INWDataReader CreateReader(string aSQL)
		{
			// create the connection object
			OleDbConnection aConnection = new OleDbConnection();

			// set the connection string
			aConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data; 
			Source=C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\Object_Oriented_Programming\Northwind Part 3\Northwind\Data\Northwind.accdb";

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

		public INWDataSet CreatDataSet(string aSQL)
		{
			// create the connection object
			OleDbConnection aConnection = new OleDbConnection();

			// set the connection
			aConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data; 
			Source=C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\Object_Oriented_Programming\Northwind Part 3\Northwind\Data\Northwind.accdb";

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