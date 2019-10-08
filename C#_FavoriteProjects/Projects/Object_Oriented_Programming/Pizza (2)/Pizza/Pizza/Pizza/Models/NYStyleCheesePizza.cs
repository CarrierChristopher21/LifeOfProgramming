using System;
using System.Collections;

namespace PizzaFactory.Models
{
	/// <summary>
	/// Summary description for NYStyleCheesePizza.
	/// </summary>
	public class NYStyleCheesePizza : Pizza
	{

		public NYStyleCheesePizza()
		{
			name = "NY Style Sauce and Cheese Pizza";
			dough = "Thin Crust Dough";
			sauce = "Martinara Sauce";

			toppings.Add("Greated Reggiano Cheese");
		}

	}
}
