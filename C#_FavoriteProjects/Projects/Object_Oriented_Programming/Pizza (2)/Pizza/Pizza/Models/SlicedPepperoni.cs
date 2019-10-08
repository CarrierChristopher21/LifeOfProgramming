using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaFactory.Models
{
    public class SlicedPepperoni : IPepperoni
    {
        public string display()
        {

            string aMessage = "";
            aMessage = aMessage + "Sliced Pepperoni \n";
            return aMessage;

        }
    }
}