using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaFactory.Models
{
    public class PlumTomatoSauce: ISauce
    {
        public string display()
        {

            string aMessage = "";
            aMessage = aMessage + "Plum Tomato Sauce \n";
            return aMessage;

        }
    }
}