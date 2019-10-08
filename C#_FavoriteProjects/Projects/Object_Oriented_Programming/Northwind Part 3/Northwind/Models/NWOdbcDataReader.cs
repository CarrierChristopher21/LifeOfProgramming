/*
 * Author:	Chris Carrier
 * Date:	1/15/15
 * Information: This class implements the data from DataReader so it doesn't damage the whole application. Sort of like the middle 
 * man of the operation. 
 * 
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
	public class NWOdbcDataReader:INWDataReader
	{
		private IDataReader aReader;
		public IDataReader aDataReader
		{
			get
			{
				return this.aReader;
			}
			set
			{
				this.aReader = value;
			}
		}
	}
}