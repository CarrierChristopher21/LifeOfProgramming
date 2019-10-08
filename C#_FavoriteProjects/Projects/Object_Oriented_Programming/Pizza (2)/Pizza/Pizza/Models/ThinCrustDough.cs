using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaFactory.Models
{
    public class ThinCrustDough: IDough
    {
        public string display()
        {

            string aMessage = "";
            aMessage = aMessage + "Thin Crust Dough \n";
            return aMessage;

        }
    }
}