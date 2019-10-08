using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.Models
{
	public class PlumTomatoSauce : ISauce
	{
		public string display()
		{
			return "Plum Tomato Sauce <br />";
		}
	}
}