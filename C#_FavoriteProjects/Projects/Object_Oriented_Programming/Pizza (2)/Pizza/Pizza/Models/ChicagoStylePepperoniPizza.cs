using System;
using System.Collections;

namespace PizzaFactory.Models
{

    public class ChicagoStylePepperoniPizza : Pizza
    {

        public ChicagoStylePepperoniPizza()
        {
            /*name = "Chicago Style Deep Dish Pepperoni Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
            toppings.Add("Pepperoni");
             * */
        }
        public override void prepare()
        { }

        public override string cut()
        {
            //base.Cut ();
            return "Cutting the pizza into square slices \n";
        }

    }

}