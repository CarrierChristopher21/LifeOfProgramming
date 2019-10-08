using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.Models
{
	public class MarinaraSauce : ISauce
	{
		public string display()
		{
			return "Marinara Sauce <br />";
		}
	}
}