/*
 * Author:	Chris Carrier
 * Date:	1/15/15
 * Information:	This class implements the data from the INWDataSet class. 
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
	public class NWOdbcDataSet : INWDataSet
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