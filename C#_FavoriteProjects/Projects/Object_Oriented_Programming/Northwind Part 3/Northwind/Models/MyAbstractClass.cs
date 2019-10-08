using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
	public class MyAbstractClass
	{
		public override string ToString()
		{
			return "";
		}

		public int GetAge()
		{
			return 0;
		}
		public virtual String GetName()
		{
			return "";
		}
	}
}