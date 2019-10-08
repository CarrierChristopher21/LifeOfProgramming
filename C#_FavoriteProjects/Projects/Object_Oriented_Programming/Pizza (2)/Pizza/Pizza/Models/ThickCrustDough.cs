using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaFactory.Models
{
    public class ThickCrustDough: IDough
    {
        public string display()
        {

            string aMessage = "";
            aMessage = aMessage + "Thick Crust Dough \n";
            return aMessage;

        }
    }
    
}