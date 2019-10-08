using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaFactory.Models
{
    public interface PizzaIngrediantFactory
    {
        IDough createDough();
        ISauce createSauce();
        ICheese createCheese();
        IPepperoni createPepperoni();
        IClams createClams();
    }
}