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