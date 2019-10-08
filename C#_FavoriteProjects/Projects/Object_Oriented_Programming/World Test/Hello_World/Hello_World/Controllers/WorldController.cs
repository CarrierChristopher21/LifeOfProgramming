using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hello_World.Controllers
{
    public class WorldController : Controller
    {
        // GET: World
        public ActionResult Index()
        {
            return View();
        }
    }
}