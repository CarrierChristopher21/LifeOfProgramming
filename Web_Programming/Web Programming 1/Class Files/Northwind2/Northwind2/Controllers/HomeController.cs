﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind2.Models;

namespace Northwind2.Controllers
{
    public class HomeController : Controller
    {
        // Create DB Connection and get our data
        //private DbConnection aDbConnection = new DbConnection();
        private DbConnection aDbConnection = DbConnection.Instance;

        // We want to avoid this with the Singleton
        //private DbConnection aDbConnection1 = new DbConnection();
        //private DbConnection aDbConnection2 = new DbConnection();
        //private DbConnection aDbConnection3 = new DbConnection();
        //private DbConnection aDbConnection4 = new DbConnection();
        //private DbConnection aDbConnection5 = new DbConnection();
        // private DbConnection aDbConnection6 = new DbConnection();

        // GET: /Home/
        public ActionResult Index()
        {

            Person aPerson1 = new Person();
            Person aPerson2 = new Student();
            Person aPerson3 = new Person();
            Student aStudent1 = new Student();

            // Every poodle is a dog
            Student aStudent2 = (Student)aPerson2;
            
            // Every Dog is not a poodle
            //Student aStudent3 = (Student)aPerson3;


            aPerson1.FirstName = "Anne";
            aPerson1.LastName = "Smith";
            //aPerson1.StudentId = "800722558";

            aPerson2.FirstName = "Jane";
            aPerson2.LastName = "Doe";
            //aPerson2.StudentId = "00099";
            aStudent2.StudentId = "00099";



            aStudent1.FirstName = "Bob";
            aStudent1.LastName = "Smith";
            aStudent1.StudentId = "800722558";


            ViewBag.person = aPerson1;
            ViewBag.student = aStudent1;


            return View();
        }

        public ActionResult ListByCategory()
        {
            
            List<Category> aCategoryList = new List<Category>();
            
            aCategoryList.Add(new Category(1, "Beverages", "Soft drinks, coffees, teas, beers, and ales"));
            aCategoryList.Add(new Category(2, "Condiments", "Sweet and savory sauces, relishes, spreads, and seasonings"));
            aCategoryList.Add(new Category(3, "Confections", "Desserts, candies, and sweet breads"));
            aCategoryList.Add(new Category(4, "Dairy Products", "Cheeses"));
            aCategoryList.Add(new Category(5, "Grains/Cereals", "Breads, crackers, pasta, and cereal"));
            aCategoryList.Add(new Category(6, "Meat/Poultry", "Prepared meats"));
            aCategoryList.Add(new Category(7, "Produce", "Dried fruit and bean curd"));
            aCategoryList.Add(new Category(8, "Seafood", "Seaweed and fish"));
            

            //List<Category>  aCategoryList = aDbConnection.GetCategories();

            // this is a linq statement
            //var detailList = from c in aCategoryList 
            //                 where c.CategoryId > 5 
             //                select c;

            //ViewBag.ListOfCategories = detailList.ToList<Category>();
            ViewBag.ListOfCategories = aCategoryList;
            return View();
        }

        public ActionResult ListBySupplier()
        {
            List<Supplier> aSupplierList = new List<Supplier>();

            aSupplierList.Add(new Supplier(1, "Exotic Liquids", "Charlotte Cooper", "Purchasing Manager", "49 Gilbert St.", "London", "na", "EC1 4SD", "UK", "(171) 555-2222", "na", "na"));
            aSupplierList.Add(new Supplier(2, "New Orleans Cajun Delights", "Shelley Burke", "Order Administrator", "P.O. Box 78934", "New Orleans", "LA", "70117", "USA", "(100) 555-4822", "na", "na"));
            aSupplierList.Add(new Supplier(3, "Grandma Kelly's Homestead", "Regina Murphy", "Sales Representative", "707 Oxford Rd.", "Ann Arbor", "MI", "48104", "USA", "(313) 555-5735", "(313) 555-3349", "na"));
            aSupplierList.Add(new Supplier(4, "Tokyo Traders", "Yoshi Nagase", "Marketing Manager", "9-8 SekimaiMusashino-shi", "Tokyo", "na", "100", "Japan", "(03) 3555-5011", "na", "na"));
            aSupplierList.Add(new Supplier(5, "Cooperativa de Quesos 'Las Cabras'", "Antonio del Valle Saavedra ", "Export Administrator", "Calle del Rosal 4", "Oviedo", "Asturias", "33007", "Spain", "(98) 598 76 54", "na", "na"));
            aSupplierList.Add(new Supplier(6, "Mayumi's", "Mayumi Ohno", "Marketing Representative", "92 SetsukoChuo-ku", "Osaka", "na", "545", "Japan", "(06) 431-7877", "na", "Mayumi's (on the World Wide Web)#http://www.microsoft.com/accessdev/sampleapps/mayumi.htm#"));
            aSupplierList.Add(new Supplier(7, "Pavlova, Ltd.", "Ian Devling", "Marketing Manager", "74 Rose St.Moonie Ponds", "Melbourne", "Victoria", "3058", "Australia", "(03) 444-2343", "(03) 444-6588", "na"));
            aSupplierList.Add(new Supplier(8, "Specialty Biscuits, Ltd.", "Peter Wilson", "Sales Representative", "29 King's Way", "Manchester", "na", "M14 GSD", "UK", "(161) 555-4448", "na", "na"));
            aSupplierList.Add(new Supplier(9, "PB Knäckebröd AB", "Lars Peterson", "Sales Agent", "Kaloadagatan 13", "Göteborg", "na", "S-345 67", "Sweden ", "031-987 65 43", "031-987 65 91", "na"));
            aSupplierList.Add(new Supplier(10, "Refrescos Americanas LTDA", "Carlos Diaz", "Marketing Manager", "Av. das Americanas 12.890", "São Paulo", "na", "5442", "Brazil", "(11) 555 4640", "na", "na"));
            aSupplierList.Add(new Supplier(11, "Heli Süßwaren GmbH & Co. KG", "Petra Winkler", "Sales Manager", "Tiergartenstraße 5", "Berlin", "na", "10785", "Germany", "(010) 9984510", "na", "na"));
            aSupplierList.Add(new Supplier(12, "Plutzer Lebensmittelgroßmärkte AG", "Martin Bein", "International Marketing Mgr.", "Bogenallee 51", "Frankfurt", "na", "60439", "Germany", "(069) 992755", "na", "Plutzer (on the World Wide Web)#http://www.microsoft.com/accessdev/sampleapps/plutzer.htm#"));
            aSupplierList.Add(new Supplier(13, "Nord-Ost-Fisch Handelsgesellschaft mbH", "Sven Petersen", "Coordinator Foreign Markets", "Frahmredder 112a", "Cuxhaven", "na", "27478", "Germany", "(04721) 8713", "(04721) 8714", "na"));
            aSupplierList.Add(new Supplier(14, "Formaggi Fortini s.r.l.", "Elio Rossi", "Sales Representative", "Viale Dante, 75", "Ravenna", "na", "48100", "Italy", "(0544) 60323", "(0544) 60603", "na"));
            aSupplierList.Add(new Supplier(15, "Norske Meierier", "Beate Vileid", "Marketing Manager", "Hatlevegen 5", "Sandvika", "na", "1320", "Norway", "(0)2-953010", "na", "na"));
            aSupplierList.Add(new Supplier(16, "Bigfoot Breweries", "Cheryl Saylor", "Regional Account Rep.", "3400 - 8th AvenueSuite 210", "Bend", "OR", "97101", "USA", "(503) 555-9931", "na", "na"));
            aSupplierList.Add(new Supplier(17, "Svensk Sjöföda AB", "Michael Björn", "Sales Representative", "Brovallavägen 231", "Stockholm", "na", "S-123 45", "Sweden", "08-123 45 67", "na", "na"));
            aSupplierList.Add(new Supplier(18, "Aux joyeux ecclésiastiques", "Guylène Nodier", "Sales Manager", "203, Rue des Francs-Bourgeois", "Paris", "na", "75004", "France", "(1) 03.83.00.68", "(1) 03.83.00.62", "na"));
            aSupplierList.Add(new Supplier(19, "New England Seafood Cannery", "Robb Merchant", "Wholesale Account Agent", "Order Processing Dept.2100 Paul Revere Blvd.", "Boston", "MA", "02134", "USA", "(617) 555-3267", "(617) 555-3389", "na"));
            aSupplierList.Add(new Supplier(20, "Leka Trading", "Chandra Leka", "Owner", "471 Serangoon Loop, Suite #402", "Singapore", "na", "0512", "Singapore", "555-8787", "na", "na"));
            aSupplierList.Add(new Supplier(21, "Lyngbysild", "Niels Petersen", "Sales Manager", "Lyngbysild Fiskebakken 10", "Lyngby", "na", "2800", "Denmark", "43844108", "43844115", "na"));
            aSupplierList.Add(new Supplier(22, "Zaanse Snoepfabriek", "Dirk Luchte", "Accounting Manager", "Verkoop Rijnweg 22", "Zaandam", "na", "9999 ZZ", "Netherlands", "(12345) 1212", "(12345) 1210", "na"));
            aSupplierList.Add(new Supplier(23, "Karkki Oy", "Anne Heikkonen", "Product Manager", "Valtakatu 12", "Lappeenranta", "na", "53120", "Finland", "(953) 10956", "na", "na"));
            aSupplierList.Add(new Supplier(24, "G'day, Mate", "Wendy Mackenzie", "Sales Representative", "170 Prince Edward Parade Hunter's Hill", "Sydney", "NSW", "2042", "Australia", "(02) 555-5914", "(02) 555-4873", "G'day Mate (on the World Wide Web)#http://www.microsoft.com/accessdev/sampleapps/gdaymate.htm#"));
            aSupplierList.Add(new Supplier(25, "Ma Maison", "Jean-Guy Lauzon", "Marketing Manager", "2960 Rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada", "(514) 555-9022", "na", "na"));
            aSupplierList.Add(new Supplier(26, "Pasta Buttini s.r.l.", "Giovanni Giudici", "Order Administrator", "Via dei Gelsomini, 153", "Salerno", "na", "84100", "Italy", "(089) 6547665", "(089) 6547667", "na"));
            aSupplierList.Add(new Supplier(27, "Escargots Nouveaux", "Marie Delamare", "Sales Manager", "22, rue H. Voiron", "Montceau", "na", "71300", "France", "85.57.00.07", "na", "na"));
            aSupplierList.Add(new Supplier(28, "Gai pâturage", "Eliane Noz", "Sales Representative", "Bat. B3, rue des Alpes", "Annecy", "na", "74000", "France", "38.76.98.06", "38.76.98.58", "na"));
            aSupplierList.Add(new Supplier(29, "Forêts d'érables", "Chantal Goulet", "Accounting Manager", "148 rue Chasseur", "Ste-Hyacinthe", "Québec", "J2S 7S8", "Canada", "(514) 555-2955", "(514) 555-2921", "na"));

            ViewBag.SupplierList = aSupplierList;

            return View();
        }

        public ActionResult ListByProduct()
        {

            List<Product> aProductList = new List<Product>();


            aProductList.Add(new Product(1, "Chai", 1, 1, "10 boxes x 20 bags", 18, 39, 0, 10, false));
            aProductList.Add(new Product(2, "Chang", 1, 1, "24 - 12 oz bottles", 19, 17, 40, 25, false));
            aProductList.Add(new Product(3, "Aniseed Syrup", 1, 2, "12 - 550 ml bottles", 10, 13, 70, 25, false));
            aProductList.Add(new Product(4, "Chef Anton's Cajun Seasoning", 2, 2, "48 - 6 oz jars", 22, 53, 0, 0, false));
            aProductList.Add(new Product(5, "Chef Anton's Gumbo Mix", 2, 2, "36 boxes", 21.35, 0, 0, 0, true));
            aProductList.Add(new Product(6, "Grandma's Boysenberry Spread", 3, 2, "12 - 8 oz jars", 25, 120, 0, 25, false));
            aProductList.Add(new Product(7, "Uncle Bob's Organic Dried Pears", 3, 7, "12 - 1 lb pkgs.", 30, 15, 0, 10, false));
            aProductList.Add(new Product(8, "Northwoods Cranberry Sauce", 3, 2, "12 - 12 oz jars", 40, 6, 0, 0, false));
            aProductList.Add(new Product(9, "Mishi Kobe Niku", 4, 6, "18 - 500 g pkgs.", 97, 29, 0, 0, true));
            aProductList.Add(new Product(10, "Ikura", 4, 8, "12 - 200 ml jars", 31, 31, 0, 0, false));
            aProductList.Add(new Product(11, "Queso Cabrales", 5, 4, "1 kg pkg.", 21, 22, 30, 30, false));
            aProductList.Add(new Product(12, "Queso Manchego La Pastora", 5, 4, "10 - 500 g pkgs.", 38, 86, 0, 0, false));
            aProductList.Add(new Product(13, "Konbu", 6, 8, "2 kg box", 6, 24, 0, 5, false));
            aProductList.Add(new Product(14, "Tofu", 6, 7, "40 - 100 g pkgs.", 23.25, 35, 0, 0, false));
            aProductList.Add(new Product(15, "Genen Shouyu", 6, 2, "24 - 250 ml bottles", 15.5, 39, 0, 5, false));
            aProductList.Add(new Product(16, "Pavlova", 7, 3, "32 - 500 g boxes", 17.45, 29, 0, 10, false));
            aProductList.Add(new Product(17, "Alice Mutton", 7, 6, "20 - 1 kg tins", 39, 0, 0, 0, true));
            aProductList.Add(new Product(18, "Carnarvon Tigers", 7, 8, "16 kg pkg.", 62.5, 42, 0, 0, false));
            aProductList.Add(new Product(19, "Teatime Chocolate Biscuits", 8, 3, "10 boxes x 12 pieces", 9.2, 25, 0, 5, false));
            aProductList.Add(new Product(20, "Sir Rodney's Marmalade", 8, 3, "30 gift boxes", 81, 40, 0, 0, false));
            aProductList.Add(new Product(21, "Sir Rodney's Scones", 8, 3, "24 pkgs. x 4 pieces", 10, 3, 40, 5, false));
            aProductList.Add(new Product(22, "Gustaf's Knäckebröd", 9, 5, "24 - 500 g pkgs.", 21, 104, 0, 25, false));
            aProductList.Add(new Product(23, "Tunnbröd", 9, 5, "12 - 250 g pkgs.", 9, 61, 0, 25, false));
            aProductList.Add(new Product(24, "Guaraná Fantástica", 10, 1, "12 - 355 ml cans", 4.5, 20, 0, 0, true));
            aProductList.Add(new Product(25, "NuNuCa Nuß-Nougat-Creme", 11, 3, "20 - 450 g glasses", 14, 76, 0, 30, false));
            aProductList.Add(new Product(26, "Gumbär Gummibärchen", 11, 3, "100 - 250 g bags", 31.23, 15, 0, 0, false));
            aProductList.Add(new Product(27, "Schoggi Schokolade", 11, 3, "100 - 100 g pieces", 43.9, 49, 0, 30, false));
            aProductList.Add(new Product(28, "Rössle Sauerkraut", 12, 7, "25 - 825 g cans", 45.6, 26, 0, 0, true));
            aProductList.Add(new Product(29, "Thüringer Rostbratwurst", 12, 6, "50 bags x 30 sausgs.", 123.79, 0, 0, 0, true));
            aProductList.Add(new Product(30, "Nord-Ost Matjeshering", 13, 8, "10 - 200 g glasses", 25.89, 10, 0, 15, false));
            aProductList.Add(new Product(31, "Gorgonzola Telino", 14, 4, "12 - 100 g pkgs", 12.5, 0, 70, 20, false));
            aProductList.Add(new Product(32, "Mascarpone Fabioli", 14, 4, "24 - 200 g pkgs.", 32, 9, 40, 25, false));
            aProductList.Add(new Product(33, "Geitost", 15, 4, "500 g", 2.5, 112, 0, 20, false));
            aProductList.Add(new Product(34, "Sasquatch Ale", 16, 1, "24 - 12 oz bottles", 14, 111, 0, 15, false));
            aProductList.Add(new Product(35, "Steeleye Stout", 16, 1, "24 - 12 oz bottles", 18, 20, 0, 15, false));
            aProductList.Add(new Product(36, "Inlagd Sill", 17, 8, "24 - 250 g  jars", 19, 112, 0, 20, false));
            aProductList.Add(new Product(37, "Gravad lax", 17, 8, "12 - 500 g pkgs.", 26, 11, 50, 25, false));
            aProductList.Add(new Product(38, "Côte de Blaye", 18, 1, "12 - 75 cl bottles", 263.5, 17, 0, 15, false));
            aProductList.Add(new Product(39, "Chartreuse verte", 18, 1, "750 cc per bottle", 18, 69, 0, 5, false));
            aProductList.Add(new Product(40, "Boston Crab Meat", 19, 8, "24 - 4 oz tins", 18.4, 123, 0, 30, false));
            aProductList.Add(new Product(41, "Jack's New England Clam Chowder", 19, 8, "12 - 12 oz cans", 9.65, 85, 0, 10, false));
            aProductList.Add(new Product(42, "Singaporean Hokkien Fried Mee", 20, 5, "32 - 1 kg pkgs.", 14, 26, 0, 0, true));
            aProductList.Add(new Product(43, "Ipoh Coffee", 20, 1, "16 - 500 g tins", 46, 17, 10, 25, false));
            aProductList.Add(new Product(44, "Gula Malacca", 20, 2, "20 - 2 kg bags", 19.45, 27, 0, 15, false));
            aProductList.Add(new Product(45, "Røgede sild", 21, 8, "1k pkg.", 9.5, 5, 70, 15, false));
            aProductList.Add(new Product(46, "Spegesild", 21, 8, "4 - 450 g glasses", 12, 95, 0, 0, false));
            aProductList.Add(new Product(47, "Zaanse koeken", 22, 3, "10 - 4 oz boxes", 9.5, 36, 0, 0, false));
            aProductList.Add(new Product(48, "Chocolade", 22, 3, "10 pkgs.", 12.75, 15, 70, 25, false));
            aProductList.Add(new Product(49, "Maxilaku", 23, 3, "24 - 50 g pkgs.", 20, 10, 60, 15, false));
            aProductList.Add(new Product(50, "Valkoinen suklaa", 23, 3, "12 - 100 g bars", 16.25, 65, 0, 30, false));
            aProductList.Add(new Product(51, "Manjimup Dried Apples", 24, 7, "50 - 300 g pkgs.", 53, 20, 0, 10, false));
            aProductList.Add(new Product(52, "Filo Mix", 24, 5, "16 - 2 kg boxes", 7, 38, 0, 25, false));
            aProductList.Add(new Product(53, "Perth Pasties", 24, 6, "48 pieces", 32.8, 0, 0, 0, true));
            aProductList.Add(new Product(54, "Tourtière", 25, 6, "16 pies", 7.45, 21, 0, 10, false));
            aProductList.Add(new Product(55, "Pâté chinois", 25, 6, "24 boxes x 2 pies", 24, 115, 0, 20, false));
            aProductList.Add(new Product(56, "Gnocchi di nonna Alice", 26, 5, "24 - 250 g pkgs.", 38, 21, 10, 30, false));
            aProductList.Add(new Product(57, "Ravioli Angelo", 26, 5, "24 - 250 g pkgs.", 19.5, 36, 0, 20, false));
            aProductList.Add(new Product(58, "Escargots de Bourgogne", 27, 8, "24 pieces", 13.25, 62, 0, 20, false));
            aProductList.Add(new Product(59, "Raclette Courdavault", 28, 4, "5 kg pkg.", 55, 79, 0, 0, false));
            aProductList.Add(new Product(60, "Camembert Pierrot", 28, 4, "15 - 300 g rounds", 34, 19, 0, 0, false));
            aProductList.Add(new Product(61, "Sirop d'érable", 29, 2, "24 - 500 ml bottles", 28.5, 113, 0, 25, false));
            aProductList.Add(new Product(62, "Tarte au sucre", 29, 3, "48 pies", 49.3, 17, 0, 0, false));
            aProductList.Add(new Product(63, "Vegie-spread", 7, 2, "15 - 625 g jars", 43.9, 24, 0, 5, false));
            aProductList.Add(new Product(64, "Wimmers gute Semmelknödel", 12, 5, "20 bags x 4 pieces", 33.25, 22, 80, 30, false));
            aProductList.Add(new Product(65, "Louisiana Fiery Hot Pepper Sauce", 2, 2, "32 - 8 oz bottles", 21.05, 76, 0, 0, false));
            aProductList.Add(new Product(66, "Louisiana Hot Spiced Okra", 2, 2, "24 - 8 oz jars", 17, 4, 100, 20, false));
            aProductList.Add(new Product(67, "Laughing Lumberjack Lager", 16, 1, "24 - 12 oz bottles", 14, 52, 0, 10, false));
            aProductList.Add(new Product(68, "Scottish Longbreads", 8, 3, "10 boxes x 8 pieces", 12.5, 6, 10, 15, false));
            aProductList.Add(new Product(69, "Gudbrandsdalsost", 15, 4, "10 kg pkg.", 36, 26, 0, 15, false));
            aProductList.Add(new Product(70, "Outback Lager", 7, 1, "24 - 355 ml bottles", 15, 15, 10, 30, false));
            aProductList.Add(new Product(71, "Fløtemysost", 15, 4, "10 - 500 g pkgs.", 21.5, 26, 0, 0, false));
            aProductList.Add(new Product(72, "Mozzarella di Giovanni", 14, 4, "24 - 200 g pkgs.", 34.8, 14, 0, 0, false));
            aProductList.Add(new Product(73, "Röd Kaviar", 17, 8, "24 - 150 g jars", 15, 101, 0, 5, false));
            aProductList.Add(new Product(74, "Longlife Tofu", 4, 7, "5 kg pkg.", 10, 4, 20, 5, false));
            aProductList.Add(new Product(75, "Rhönbräu Klosterbier", 12, 1, "24 - 0.5 l bottles", 7.75, 125, 0, 25, false));
            aProductList.Add(new Product(76, "Lakkalikööri", 23, 1, "500 ml ", 18, 57, 0, 20, false));
            aProductList.Add(new Product(77, "Original Frankfurter grüne Soße", 12, 2, "12 boxes", 13, 32, 0, 15, false));

            ViewBag.ProductList = aProductList;

            return View();
        }
	}
}