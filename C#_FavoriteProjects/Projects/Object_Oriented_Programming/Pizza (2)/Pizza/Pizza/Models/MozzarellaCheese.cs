using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaFactory.Models
{
    public class MozzarellaCheese : ICheese
    {
        public string display()
        {

            string aMessage = "";
            aMessage = aMessage + "Mozzarella Cheese \n";
            return aMessage;

        }
    }
}