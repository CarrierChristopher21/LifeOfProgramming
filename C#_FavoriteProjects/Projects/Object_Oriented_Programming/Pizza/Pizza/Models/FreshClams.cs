using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.Models
{
	public class FreshClams : IClams
	{
		public string display()
		{
			return "Fresh Clams <br />";
		}
	}
}