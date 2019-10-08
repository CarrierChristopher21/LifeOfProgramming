using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Beverages.Controllers
{
    public class StoreController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: /Store/
        public ActionResult Browse(int aCategoryID)
        {         
            
            return View();
        }

        // GET: /Store/
        public string Details()
        {
            return "<b><i>Hello From Details</i></b>";
        }
    }
} 

            /*  Code if statements for beverages
            if(aCategoryID == 1) 
            {
                aMessage = aMessage + "You chose Beverages";
            }
            else if(aCategoryID == 2)
            {
                aMessage = aMessage + "You chose Condiments";
            }
            else if(aCategoryID == 3)
            {
                aMessage = aMessage + "You chose Confections";
            }
            else if(aCategoryID == 4)
            {
                aMessage = aMessage + "You chose Dairy Products";
            }
            else if(aCategoryID == 5)
            {
                aMessage = aMessage + "You chose Grains / Cereals";
            }
            else if(aCategoryID == 6)
            {
                aMessage = aMessage + "You chose Meat / Poultry";
            }
            else if(aCategoryID == 7)
            {
                aMessage = aMessage + "You chose Produce";
            }
            else if(aCategoryID == 8)
            {
                aMessage = aMessage + "You chose Seafood";
            }*/