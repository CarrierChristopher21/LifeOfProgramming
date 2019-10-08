using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.Models
{
	public class FrozenClams : IClams
	{
		public string display()
		{
			return "Frozen Clams <br />";
		}
	}
}