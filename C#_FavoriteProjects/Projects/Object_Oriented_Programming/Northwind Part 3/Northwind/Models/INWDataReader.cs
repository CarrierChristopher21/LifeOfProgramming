/*
 * Author:	Chris Carrier
 * Date:	1/15/15
 * Information:	This class is to get and assign the data for the datareader for an interface.
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
	public interface INWDataReader
	{
		IDataReader aDataReader
		{
			get;
			set;
		}
	}
}
