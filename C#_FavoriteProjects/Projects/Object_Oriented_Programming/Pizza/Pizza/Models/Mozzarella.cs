using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.Models
{
	public class Mozzarella : ICheese
	{
		public string display()
		{
			return "Mozzarella Cheese <br />";
		}
	}
}