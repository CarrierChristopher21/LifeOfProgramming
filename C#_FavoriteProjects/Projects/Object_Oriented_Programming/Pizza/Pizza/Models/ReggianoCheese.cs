using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.Models
{
	public class ReggianoCheese : ICheese
	{
		public string display()
		{
			return "Reggiano Cheese <br />";
		}
	}
}