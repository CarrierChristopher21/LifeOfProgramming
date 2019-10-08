using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaFactory.Models
{
    public class PepperoniPizza: Pizza
    {
       PizzaIngrediantFactory ingredientFactory;

       public PepperoniPizza(PizzaIngrediantFactory aIngredientFactory)
        {
            this.ingredientFactory = aIngredientFactory;

        }

        public override void prepare()
        {
           base.dough = ingredientFactory.createDough();
           base.cheese = ingredientFactory.createCheese();
           base.clams = ingredientFactory.createClams();
           base.pepperoni = ingredientFactory.createPepperoni();
           base.sauce = ingredientFactory.createSauce();

        }
    }
}