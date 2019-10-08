using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind4.Models;
using System.Data;
using System.Data.OleDb;

namespace Northwind4.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
		    List<Category> aCategories = new List<Category>();
			List<Product> aProducts = new List<Product>();
            DBConnection aConnection = new DBConnection();

			ViewBag.aCategories = aConnection.GetCategories();
			ViewBag.aProducts = aConnection.GetProducts();

            return View();
		}
					//	Category Files
		public ActionResult CategoryFile()
		{
			DBConnection aConnection = new DBConnection();
			List<Category> aFileCategories = aConnection.GetCategories();	//	Change this later

			ViewBag.Categories = aFileCategories;
			return View();
		}

		public ActionResult ProductsFile()
		{
			DBConnection aConnection = new DBConnection();
			List<Product> aProducts = aConnection.GetProducts();	//	Change this later
			ViewBag.Products = aProducts;
			return View();
		}

			/*
			 * Category aCategory1 = new Category();			
			 * Category aCategory2 = new Category();
			 * Category aCategory3 = new Category();
			 * aCategory1.CategoryId = 1;
			 * aCategory1.CategoryName = "Beverages";
			 * aCategory1.Description = "Soft drinks, coffees, teas, beers, and ales";
			 * aCategory2.CategoryId = 2;
			 * aCategory2.CategoryName = "Condiments";
			 * aCategory2.Description = "Sweet and savory sauces, relishes, spreads, and seasonings";
			 * aCategory3.CategoryId = 3;
			 * aCategory3.CategoryName = "Confections";
			 * aCategory3.Description = "Desserts, candies, and sweet breads";
            
			 * aListOfCategories.Add(aCategory1);
			 * aListOfCategories.Add(aCategory2);
			 * aListOfCategories.Add(aCategory3);

			 */
        
	}
}