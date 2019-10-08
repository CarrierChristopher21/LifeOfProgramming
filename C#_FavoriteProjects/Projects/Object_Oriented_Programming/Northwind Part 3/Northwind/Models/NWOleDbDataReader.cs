/*
 * Author:	Chris Carrier
 * Date:	1/15/15
 * Information:	This is the OleDb data for DataReader portion of the Factory. It will implement the INWDataReader 
 * interface.
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
	public class NWOleDbDataReader:INWDataReader
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