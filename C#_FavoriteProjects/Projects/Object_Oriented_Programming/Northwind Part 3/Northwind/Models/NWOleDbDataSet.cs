/*
 * Author:	Chris Carrier
 * Date:	1/15/15
 * Information:	This is the OleDb data that runs the DataSet portion of the Factory. It also implements the INWDataSet
 * interface into the program.
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
	public class NWOleDbDataSet : INWDataSet
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