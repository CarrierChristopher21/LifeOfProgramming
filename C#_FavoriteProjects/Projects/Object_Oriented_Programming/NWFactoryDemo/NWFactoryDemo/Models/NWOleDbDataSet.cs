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
	public class NWOleDbDataSet:INWDataSet
	{
		DataSet aSet = new DataSet();

		public DataSet aDataSet
		{
			get
			{
				return this.aSet;
			}
			set
			{
				this.aSet = value;
			}
		}
	}
}