using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaFactory.Models
{
    public class MarinaraSauce : ISauce
    {
        public string display()
        {

            string aMessage = "";
            aMessage = aMessage + "Marinara Sauce \n";
            return aMessage;

        }
    }
}