using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.Models
{
	public class ThickCrustDough : IDough
	{
		public string display()
		{
			return "Thick Crust Dough <br />";
		}



	}

}