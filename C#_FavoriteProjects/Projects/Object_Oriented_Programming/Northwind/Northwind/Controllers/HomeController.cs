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
            List<Category> aListOfCategories = aConnection.GetCategories();
			List<Supplier> aListOfSuppliers = aConnection.GetSuppliers();
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
			DBConnection aConnection = new DBConnection();
			List<Category> aCategories = aConnection.GetCategories();

			ViewBag.Categories = aCategories;
			return View();
		}

		//	Category Files
		public ActionResult CategoryFile()
		{
			DBConnection aConnection = DBConnection.GetanInstance;
			List<Category> aFileCategories = aConnection.GetCategories();	//	Change this later

			ViewBag.Categories = aFileCategories;
			return View();
		}

		//	Category Filter
		public ActionResult CategoryFilter()
		{
			DBConnection aConnection = new DBConnection();
			List<Category> aListOfCategories = aConnection.GetCategories();

			ViewBag.Categories = aListOfCategories;
			return View();
		}
		//	By Category
		public ActionResult ByCategory(int Id)
		{
			DBConnection aConnection = new DBConnection();
			List<Category> aByCategory = aConnection.GetByCategories(Id);

			ViewBag.Categories = aByCategory;
			return View();
		}

		//					Supplier
		//	Supplier Index
		public ActionResult SupplierIndex()
		{
			DBConnection aConnection = new DBConnection();
			List<Supplier> aSupplier = aConnection.GetSuppliers();

			ViewBag.Supplier = aSupplier;
			return View();
		}

		//	Supplier Files
		public ActionResult SupplierFile()
		{
			DBConnection aConnection = new DBConnection();
			List<Supplier> aSupplierFile = aConnection.GetSuppliers();

			ViewBag.Supplier = aSupplierFile;
			return View();
		}

		//	Supplier Filter
		public ActionResult SupplierFilter()
		{
			DBConnection aConnection = new DBConnection();
			List<Supplier> aSupplierFilter = aConnection.GetSuppliers();

			ViewBag.Supplier = aSupplierFilter;
			return View();
		}

		//	Supplier Filter
		public ActionResult BySupplier(int Id)
		{
			DBConnection aConnection = new DBConnection();
			List<Supplier> aBySupplier = aConnection.GetBySuppliers(Id);

			ViewBag.Supplier = aBySupplier;
			return View();
		}
		//					Shipper
		//	Shipper Index
		public ActionResult ShipperIndex()
		{
			DBConnection aConnection = new DBConnection();
			List<Shipper> aShipperFile = aConnection.GetShippers();

			ViewBag.Shipper = aShipperFile;
			return View();
		}

		//	Shipper File
		public ActionResult ShipperFile()
		{
			DBConnection aConnection = new DBConnection();
			List<Shipper> aShipperFile = aConnection.GetShippers();

			ViewBag.Shipper = aShipperFile;
			return View();
		}

		//	Shipper Filter
		public ActionResult ShipperFilter()
		{
			DBConnection aConnection = new DBConnection();
			List<Shipper> aShipperFile = aConnection.GetShippers();

			ViewBag.Shipper = aShipperFile;
			return View();
		}

		//	Get By Shipper Filter Files
		public ActionResult ByShipper(int id)
		{
			DBConnection aConnection = new DBConnection();
			List<Shipper> aByShipper = aConnection.GetByShippers(id);

			ViewBag.Shipper = aByShipper;
			return View();
		}
		//					Product
		//	Price Index
		public ActionResult ProductIndex()
		{
			DBConnection aConnection = new DBConnection();
			List<Product> aProductFile = aConnection.GetProduct();

			ViewBag.Product = aProductFile;
			return View();
		}

		//	Price File
		public ActionResult ProductFile()
		{
			DBConnection aConnection = new DBConnection();
			List<Product> aProductFile = aConnection.GetProduct();

			ViewBag.Product = aProductFile;
			return View();
		}

		//	Product Filter
		public ActionResult ProductFilter()
		{
			DBConnection aConnection = new DBConnection();
			List<Product> aProductFile = aConnection.GetProduct();

			ViewBag.Product = aProductFile;
			return View();
		}

		//	Get By Product Filter Files
		public ActionResult ByProduct(double pricemin, double pricemax)
		{
			DBConnection aConnection = new DBConnection();
			List<Product> aByProduct = aConnection.GetByProducts(pricemin, pricemax);

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