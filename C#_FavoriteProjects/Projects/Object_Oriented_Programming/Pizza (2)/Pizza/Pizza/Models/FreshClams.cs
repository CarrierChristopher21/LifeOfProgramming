using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaFactory.Models
{
    public class FreshClams : IClams
    {
        public string display()
        {

            string aMessage = "";
            aMessage = aMessage + "TFresh Clams \n";
            return aMessage;

        }
    }
}