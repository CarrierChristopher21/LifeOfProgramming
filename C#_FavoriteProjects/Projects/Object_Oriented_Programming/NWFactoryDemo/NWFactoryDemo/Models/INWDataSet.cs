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
	public interface INWDataSet
	{
		INWDataSet aDataSet
		{
			get;
			set;
		}
	}
}