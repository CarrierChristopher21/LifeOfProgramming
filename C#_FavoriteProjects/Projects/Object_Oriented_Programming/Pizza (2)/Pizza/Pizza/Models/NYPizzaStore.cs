using System;

namespace PizzaFactory.Models
{

	public class NYPizzaStore : PizzaStore
	{

        Pizza aPizza = null;
        PizzaIngrediantFactory anIngrediantFactory = new NYPizzaIngrediantFactory();

        public override Pizza createPizza(string aTypeOfPizza)
        {
            if (aTypeOfPizza.Equals("cheese"))
            {
                aPizza = new CheesePizza(anIngrediantFactory);
                aPizza.setName("NY Cheese Pizza");
                return aPizza;
            }
            else if (aTypeOfPizza.Equals("veggie"))
            {
                aPizza = new VeggiePizza(anIngrediantFactory);
                aPizza.setName("NY Veggie Pizza");
                return aPizza;
            }
            else if (aTypeOfPizza.Equals("clam"))
            {
                aPizza = new ClamPizza(anIngrediantFactory);
                aPizza.setName("NY Clam Pizza");
                return aPizza;
            }
            else if (aTypeOfPizza.Equals("pepperoni"))
            {
                aPizza = new PepperoniPizza(anIngrediantFactory);
                aPizza.setName("NY Pepperoni Pizza");
                return aPizza;
            }
            else
            {
                return null;
            }
        }
    }
}
