/*
 * Author:	Chris Carrier
 * Date:	1/15/15
 * Information: This is an interface for the DataSet Factory. It contains information for the factory that will not change.
 * This class would only be updated if all other options where used and there was no other way to update the information. 
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
	public interface INWDataSet
	{
		DataSet aDataSet
		{
			get;
			set;
		}
	}
}
