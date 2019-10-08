using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaFactory.Models
{
    public class FrozenClams : IClams
    {
        public string display()
        {

            string aMessage = "";
            aMessage = aMessage + "Frozen Clams \n";
            return aMessage;

        }
    }
}