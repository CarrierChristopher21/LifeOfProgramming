using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaFactory.Models
{
    public class ReggianoCheese : ICheese
    {
        public string display()
        {

            string aMessage = "";
            aMessage = aMessage + "Reggiano Cheese \n";
            return aMessage;

        }
    }
}