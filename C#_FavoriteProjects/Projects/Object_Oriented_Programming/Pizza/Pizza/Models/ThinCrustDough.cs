using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.Models
{
	public class ThinCrustDough : IDough
	{
		public string display()
		{
			return "Thin Crust Dough <br />";
		}
	}
}