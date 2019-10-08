using System;

namespace PizzaFactory.Models
{

	public class ChicagoPizzaStore : PizzaStore
	{
        public override Pizza createPizza(string aTypeOfPizza)
        {
            if (aTypeOfPizza.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (aTypeOfPizza.Equals("veggie"))
            {
                return new NYStyleVeggiePizza();
            }
            else if (aTypeOfPizza.Equals("clam"))
            {
                return new NYStyleClamPizza();
            }
            else if (aTypeOfPizza.Equals("pepperoni"))
            {
                return new NYStylePepperoniPizza();
            }
            else
            {
                return null;
            }
        }
	}
}
