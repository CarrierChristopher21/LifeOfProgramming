using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaFactory.Models
{
    public class ChicagoIngrediantsFactory:PizzaIngrediantFactory
    {

        public IDough createDough()
        {
            return new ThickCrustDough();
        }
        public ISauce createSauce()
        {
            return new PlumTomatoSauce();
        }
        public ICheese createCheese()
        {
            return new MozzarellaCheese();
        }

        public IPepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }
        public IClams createClams()
        {
            return new FrozenClams();
        }



    }
}