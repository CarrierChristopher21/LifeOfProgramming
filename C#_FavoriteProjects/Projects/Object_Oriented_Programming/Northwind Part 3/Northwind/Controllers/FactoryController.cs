/*
 *	Author:	Chris Carrier
 *	Date:	5/2/15
 *	Information:	This class is to run factory version of the ASP.NET MVC setups. Which I believe is the Views 
 *	that are created. This controller runs the regular views. This class links up to the Factory version of 
 *	Category, Product, Shipper, and Supplier Connections.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind.Models;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Data.Sql;
using System.Data;

namespace Northwind.Controllers
{
    public class FactoryController : Controller
    {

		public ActionResult FactoryIndex()
		{
								//	Links
			//	Customer Link
			Customer aCustomer = new Customer();
			//	Shipper Link
			Shipper aShipper = new Shipper();
			//	Supplier Link
			Supplier aSupplier = new Supplier();
			//	Product Link
			Product aProduct = new Product();

								//	Connections
			// Category Connection
			FactoryCategoryConnection aFactoryCategoryConnection = new FactoryCategoryConnection();
			// Shipper Connection
			FactoryShipperConnection aFactoryShipperConnection = new FactoryShipperConnection();
			//	Supplier Connection
			FactorySupplierConnection aFactorySupplierConnection = new FactorySupplierConnection();
			//	Product Connection
			FactoryProductConnection aFactoryProductConnection = new FactoryProductConnection();

								//	Lists
			// Category List
			List<Category> aListOfCategories = aFactoryCategoryConnection.GetCategories();
			// Supplier List
			List<Supplier> aListOfSuppliers = aFactorySupplierConnection.GetSuppliers();
			// Shipper List
			List<Shipper> aListOfShippers = aFactoryShipperConnection.GetShippers();
			// Shipper List
			List<Product> aListOfProducts = aFactoryProductConnection.GetProducts();

								//	ViewBags
			//	Customer ViewBag
			ViewBag.Customer = aCustomer;
			//	Shipper ViewBag
			ViewBag.Shipper = aShipper;
			//	Supplier ViewBag
			ViewBag.Supplier = aSupplier;
			//	Product ViewBag
			ViewBag.Product = aProduct;
			//	Categories ViewBag
			ViewBag.Categories = aListOfCategories;

			return View();
		}

		//	Category Files
		public ActionResult CategoryFactory()
        {
			// DBConnection aConnection = new DBConnection();
			FactoryCategoryConnection aFactoryCategory = new FactoryCategoryConnection();
			List<Category> aFactoryCategoriesFile = aFactoryCategory.GetCategories();

			ViewBag.Categories = aFactoryCategoriesFile;
            return View();
        }

		//	Shipper File
        public ActionResult ShipperFactory()
        {
			//	DBConnection aConnection = new DBConnection();
			FactoryShipperConnection aFactoryShipper = new FactoryShipperConnection();
			List<Shipper> aFactoryShipperFile = aFactoryShipper.GetShippers();
	    
            ViewBag.Shipper = aFactoryShipperFile;
            return View();
        }

		//	Supplier Files
		public ActionResult SupplierFactory()
		{
			//	DBConnection aConnection = new DBConnection();
			FactorySupplierConnection aFactorySupplier = new FactorySupplierConnection();
			List<Supplier> aFactorySupplierFile = aFactorySupplier.GetSuppliers();

			ViewBag.Supplier = aFactorySupplierFile;
			return View();
		}

		//	Product File
		public ActionResult ProductFactory()
		{
			//	DBConnection aConnection = new DBConnection();
			FactoryProductConnection aFactoryProductConnection = new FactoryProductConnection();
			List<Product> aFactoryProductFile = aFactoryProductConnection.GetProducts();

			ViewBag.Product = aFactoryProductFile;
			return View();
		}
    }
}
