/*
 *	Author:	Chris Carrier
 *	Date:	1/15/15
 *	Information:	This class is to run the ASP.NET MVC setups. Which I believe is the Views that are created. This controller
 *	runs the regular views. This class links up to the Category, Product, Shipper, and Supplier Connections.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind.Models;
using System.Data;
using System.Data.OleDb;

namespace Northwind.Controllers
{
    public class HomeController : Controller
    {
		//					Home
        // GET: Home
        public ActionResult Index()
        {
            //Company aCompany = new Company();
            Customer aCustomer = new Customer();
            Shipper aShipper = new Shipper();
            Supplier aSupplier = new Supplier();
            DBConnection aConnection = new DBConnection();

			// Category Connection
			CategoryConnection aCategoryConnection = new CategoryConnection();
			// Shipper Connection
			ShipperConnection aShipperConnection = new ShipperConnection();
			//	Supplier Connection
			SupplierConnection aSupplierConnection = new SupplierConnection();
			//	Product Connection
			ProductConnection aProductConnection = new ProductConnection();
			// Category List
            List<Category> aListOfCategories = aCategoryConnection.GetCategories();
			// Supplier List
			List<Supplier> aListOfSuppliers = aConnection.GetSuppliers();
			// Shipper List
			List<Shipper> aListOfShippers = aConnection.GetShippers();

            //ViewBag.Company = aCompany;
            ViewBag.Customer = aCustomer;
            ViewBag.Shipper = aShipper;
            ViewBag.Supplier = aSupplier;
            ViewBag.Categories = aListOfCategories;

            return View();
        }

		//					Category
		//	Category Index
		public ActionResult CategoryIndex()
		{			
			// DBConnection aConnection = new DBConnection();
			CategoryConnection aCategoryConnection = new CategoryConnection();
			List<Category> aCategories = aCategoryConnection.GetCategories();

			ViewBag.Categories = aCategories;
			return View();
		}

		//	Category Files
		public ActionResult CategoryFile()
		{
			// DBConnection aConnection = new DBConnection();
			CategoryConnection aCategoryConnection = new CategoryConnection();
			List<Category> aFileCategories = aCategoryConnection.GetCategories();	//	Change this later

			ViewBag.Categories = aFileCategories;
			return View();
		}

		//	Category Filter
		public ActionResult CategoryFilter()
		{
			// DBConnection aConnection = new DBConnection();
			CategoryConnection aCategoryConnection = new CategoryConnection();
			List<Category> aListOfCategories = aCategoryConnection.GetCategories();

			ViewBag.Categories = aListOfCategories;
			return View();
		}

		//	By Category
		public ActionResult ByCategory(int Id)
		{
			// DBConnection aConnection = new DBConnection();
			CategoryConnection aCategoryConnection = new CategoryConnection();
			List<Category> aByCategories = aCategoryConnection.GetByCategories(Id);

			ViewBag.Categories = aByCategories;
			return View();
		}

		//					Supplier
		//	Supplier Index
		public ActionResult SupplierIndex()
		{
			//	DBConnection aConnection = new DBConnection();
			SupplierConnection aSupplierConnection = new SupplierConnection();
			List<Supplier> aSupplier = aSupplierConnection.GetSuppliers();

			ViewBag.Supplier = aSupplier;
			return View();
		}

		//	Supplier Files
		public ActionResult SupplierFile()
		{
			//	DBConnection aConnection = new DBConnection();
			SupplierConnection aSupplierConnection = new SupplierConnection();
			List<Supplier> aSupplierFile = aSupplierConnection.GetSuppliers();

			ViewBag.Supplier = aSupplierFile;
			return View();
		}

		//	Supplier Filter
		public ActionResult SupplierFilter()
		{
			//	DBConnection aSupplierConnection = new DBConnection();
			SupplierConnection aSupplierConnection = new SupplierConnection();
			List<Supplier> aSupplierFilter = aSupplierConnection.GetSuppliers();

			ViewBag.Supplier = aSupplierFilter;
			return View();
		}

		//	Supplier Filter
		public ActionResult BySupplier(int Id)
		{
			//	DBConnection aSupplierConnection = new DBConnection();
			SupplierConnection aSupplierConnection = new SupplierConnection();
			List<Supplier> aBySupplier = aSupplierConnection.GetBySuppliers(Id);

			ViewBag.Supplier = aBySupplier;
			return View();
		}

		//					Shipper
		//	Shipper Index
		public ActionResult ShipperIndex()
		{
			//	DBConnection aConnection = new DBConnection();
			ShipperConnection aShipperConnection = new ShipperConnection();
			List<Shipper> aShipperFile = aShipperConnection.GetShippers();

			ViewBag.Shipper = aShipperFile;
			return View();
		}

		//	Shipper File
		public ActionResult ShipperFile()
		{
			//	DBConnection aConnection = new DBConnection();
			ShipperConnection aShipperConnection = new ShipperConnection();
			List<Shipper> aShipperFile = aShipperConnection.GetShippers();

			ViewBag.Shipper = aShipperFile;
			return View();
		}

		//	Shipper Filter
		public ActionResult ShipperFilter()
		{
			//	DBConnection aConnection = new DBConnection();
			ShipperConnection aShipperConnection = new ShipperConnection();
			List<Shipper> aShipperFile = aShipperConnection.GetShippers();

			ViewBag.Shipper = aShipperFile;
			return View();
		}

		//	Get By Shipper Filter Files
		public ActionResult ByShipper(int id)
		{
			//	DBConnection aConnection = new DBConnection();
			ShipperConnection aShipperConnection = new ShipperConnection();
			List<Shipper> aByShipper = aShipperConnection.GetByShippers(id);

			ViewBag.Shipper = aByShipper;
			return View();
		}
		
		//					Product
		//	Price Index
		public ActionResult ProductIndex()
		{
			//	DBConnection aConnection = new DBConnection();
			ProductConnection aProductConnection = new ProductConnection();
			List<Product> aProductFile = aProductConnection.GetProduct();

			ViewBag.Product = aProductFile;
			return View();
		}

		//	Product File
		public ActionResult ProductFile()
		{
			//	DBConnection aConnection = new DBConnection();
			ProductConnection aProductConnection = new ProductConnection();
			List<Product> aProductFile = aProductConnection.GetProduct();

			ViewBag.Product = aProductFile;
			return View();
		}

		//	Product Filter
		public ActionResult ProductFilter()
		{
			//	DBConnection aConnection = new Connection();
			ProductConnection aProductConnection = new ProductConnection();
			List<Product> aProductFile = aProductConnection.GetProduct();

			ViewBag.Product = aProductFile;
			return View();
		}

		//	Get Price ByProduct Filter Files
		public ActionResult ByProduct(double pricemin, double pricemax)
		{
			//	DBConnection aConnection = new DBConnection();
			ProductConnection aProductConnection = new ProductConnection();
			List<Product> aByProduct = aProductConnection.GetByProducts(pricemin, pricemax);

			ViewBag.Product = aByProduct;
			return View();
		}
    }
}  






/*
// Dog aDod = new Dog();
BaseClass isDefinitelyBase = new BaseClass();

// Dog aDod = new Poodle();
BaseClass isReallyChild = new DerivedClass();

// poodle aDod = new Poodle();
DerivedClass isDefinitelyChild = new DerivedClass();

String aMessage = isReallyChild.Method1() + "<br />";
aMessage = aMessage + isReallyChild.Method2() + "<br />";

return View();
*/