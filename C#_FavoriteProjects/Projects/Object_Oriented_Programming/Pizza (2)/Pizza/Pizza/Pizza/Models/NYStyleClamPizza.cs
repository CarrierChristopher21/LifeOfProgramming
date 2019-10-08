using System;
using System.Collections;

namespace PizzaFactory.Models
{
	/// <summary>
	/// Summary description for NYStyleCheesePizza.
	/// </summary>
	public class NYStyleClamPizza : Pizza
	{

        public NYStyleClamPizza()
		{
			name = "NY Style Sauce and Clam Pizza";
			dough = "Thin Crust Dough";
			sauce = "Martinara Sauce";

			toppings.Add("Greated Reggiano Cheese");
            toppings.Add("Clams");
		}

	}
}
