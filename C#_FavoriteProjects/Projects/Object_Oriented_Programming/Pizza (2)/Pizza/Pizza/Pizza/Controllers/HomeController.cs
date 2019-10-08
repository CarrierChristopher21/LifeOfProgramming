using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaFactory.Models;

namespace PizzaFactory.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            PizzaFactory.Models.Pizza pizza1 = nyStore.orderPizza("cheese");
            PizzaFactory.Models.Pizza pizza2 = nyStore.orderPizza("veggie");
            PizzaFactory.Models.Pizza pizza3 = nyStore.orderPizza("clam");
            PizzaFactory.Models.Pizza pizza4 = nyStore.orderPizza("pepperoni");
            PizzaFactory.Models.Pizza pizza5 = chicagoStore.orderPizza("cheese");
            PizzaFactory.Models.Pizza pizza6 = chicagoStore.orderPizza("veggie");
            PizzaFactory.Models.Pizza pizza7 = chicagoStore.orderPizza("clam");
            PizzaFactory.Models.Pizza pizza8 = chicagoStore.orderPizza("pepperoni");

  
            ViewBag.pizza1 = pizza1.prepare();
            ViewBag.pizza2 = pizza2.prepare();
            ViewBag.pizza3 = pizza3.prepare();
            ViewBag.pizza4 = pizza4.prepare();
            ViewBag.pizza5 = pizza5.prepare();
            ViewBag.pizza6 = pizza6.prepare();
            ViewBag.pizza7 = pizza7.prepare();
            ViewBag.pizza8 = pizza8.prepare();




            return View();
        }
    }
}