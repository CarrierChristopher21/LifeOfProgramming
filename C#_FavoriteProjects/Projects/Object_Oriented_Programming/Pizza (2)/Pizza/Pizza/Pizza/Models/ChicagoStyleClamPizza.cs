using System;
using System.Collections;

namespace PizzaFactory.Models
{

	public class ChicagoStyleClamPizza : Pizza
	{

		public ChicagoStyleClamPizza()
		{
			name = "Chicago Style Deep Dish Clam Pizza";
			dough = "Extra Thick Crust Dough";
			sauce = "Plum Tomato Sauce";

			toppings.Add("Shredded Mozzarella Cheese");
            toppings.Add("Clams");
		}


		public override string cut()
		{
			//base.Cut ();
			return "Cutting the pizza into square slices \n";
		}

	}
}
