using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaFactory.Models
{
    public class NYPizzaIngrediantFactory:PizzaIngrediantFactory
    {

        public IDough createDough(){
            return new ThinCrustDough();
        }
        public ISauce createSauce(){
            return new MarinaraSauce();
        }
        public ICheese createCheese(){
            return new ReggianoCheese();
        }
        public IPepperoni createPepperoni(){
            return new SlicedPepperoni();
        }
        public IClams createClams()
        {
            return new FreshClams();
        }
    }
}