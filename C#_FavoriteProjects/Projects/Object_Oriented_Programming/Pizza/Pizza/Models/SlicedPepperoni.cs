using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.Models
{
	public class SlicedPepperoni : IPepperoni
	{
		public string display()
		{
			return "Sliced Pepperoni <br />";
		}
	}
}