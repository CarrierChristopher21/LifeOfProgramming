using System;

namespace PizzaFactory.Models
{

	public class ChicagoPizzaStore : PizzaStore
	{

        Pizza aPizza = null;
        PizzaIngrediantFactory anIngrediantFactory = new ChicagoIngrediantsFactory();

        public override Pizza createPizza(string aTypeOfPizza)
        {
            if (aTypeOfPizza.Equals("cheese"))
            {
                aPizza = new CheesePizza(anIngrediantFactory);
                aPizza.setName("Chicago Cheese Pizza");
                return aPizza;
            }
            else if (aTypeOfPizza.Equals("veggie"))
            {
                aPizza = new VeggiePizza(anIngrediantFactory);
                aPizza.setName("Chicago Veggie Pizza");
                return aPizza;
            }
            else if (aTypeOfPizza.Equals("clam"))
            {
                aPizza = new ClamPizza(anIngrediantFactory);
                aPizza.setName("Chicago Clam Pizza");
                return aPizza;
            }
            else if (aTypeOfPizza.Equals("pepperoni"))
            {
                aPizza = new PepperoniPizza(anIngrediantFactory);
                aPizza.setName("Chicago Pepperoni Pizza");
                return aPizza;
            }
            else
            {
                return null;
            }
        }
	}
}
