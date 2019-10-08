using System;
using System.Collections;

namespace PizzaFactory.Models
{

	public class ChicagoStyleVeggiePizza : Pizza
	{

		public ChicagoStyleVeggiePizza()
		{
			name = "Chicago Style Deep Dish Veggie Pizza";
			dough = "Extra Thick Crust Dough";
			sauce = "Plum Tomato Sauce";

			toppings.Add("Shredded Mozzarella Cheese");
            toppings.Add("black olives");
            toppings.Add("red peppers");
            toppings.Add("green peppers");
            toppings.Add("mushrooms");
		}


		public override string cut()
		{
			//base.Cut ();
			return "Cutting the pizza into square slices \n";
		}

	}
}
