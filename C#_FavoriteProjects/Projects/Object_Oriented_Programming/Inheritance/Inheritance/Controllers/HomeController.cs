using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Inheritance.Models;

namespace Inheritance.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
			Person aPerson1 = new Person();
			Person aPerson2 = new Person("3", "Alice", "Mary", "Smith");
			Student aStudent1 = new Student();
			Student aStudent2 = new Student("4", "David", "and", "Goliath", "Theology");

			aPerson1.IDNumber = "1";
			aPerson1.FirstName = "Jane";
			aPerson1.MiddleName = "Victoria";			
			aPerson1.LastName = "Doe";			

			aStudent1.IDNumber = "2";
			aStudent1.FirstName = "John";
			aStudent1.MiddleName = "Samuel";
			aStudent1.LastName = "Doe";
			aStudent1.Major = "English Literature";

			ViewBag.aPerson1 = aPerson1;
			ViewBag.aPerson2 = aPerson2;
			ViewBag.aStudent1 = aStudent1;
			ViewBag.aStudent2 = aStudent2;

            return View();
        }
    }
}