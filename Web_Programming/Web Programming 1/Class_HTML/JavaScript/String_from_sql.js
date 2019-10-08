

// this is what we want
var category1 = new Category(1, "Beverages", "Soft drinks, coffees, teas, beers, and ales");


// step one: just get the data
SELECT CategoryId, CategoryName, Description
FROM Categories

1	Beverages	Soft drinks, coffees, teas, beers, and ales

// step Two: start building the string
SELECT "var category" & " = new Category(" , CategoryId, CategoryName, Description
FROM Categories

var category = new Category(	1	Beverages	Soft drinks, coffees, teas, beers, and ales

// step Three: Add the number to var category#
SELECT "var category" & CategoryId &  " = new Category(" , CategoryId, CategoryName, Description
FROM Categories

var category1 = new Category(	1	Beverages	Soft drinks, coffees, teas, beers, and ales

// step Three: Add the number to var category#
SELECT "var category" & CategoryId &  " = new Category(" , CategoryId, CategoryName, Description
FROM Categories

var category1 = new Category(	1	Beverages	Soft drinks, coffees, teas, beers, and ales

// step Four: Add the parenthesis at the end
SELECT "var category" & CategoryId &  
		" = new Category(" , 
		CategoryId, 
		CategoryName, 
		Description & ");"
FROM Categories

var category1 = new Category(	1	Beverages	Soft drinks, coffees, teas, beers, and ales);


// step Five: Add the Commas
SELECT "var category" & CategoryId &  
		" = new Category(" , 
		CategoryId & ", " &
		CategoryName & ", " & 
		Description & ");"
FROM Categories

var category1 = new Category(	1, Beverages, Soft drinks, coffees, teas, beers, and ales);


// step Five: Add the quotes
SELECT "var category" & CategoryId &  
		" = new Category(" & 
		CategoryId & ", """ &
		CategoryName & """, """ & 
		Description & """);"
FROM Categories


Expr1000
"var category1 = new Category(1, ""Beverages"", ""Soft drinks, coffees, teas, beers, and ales"");"
"var category2 = new Category(2, ""Condiments"", ""Sweet and savory sauces, relishes, spreads, and seasonings"");"
"var category3 = new Category(3, ""Confections"", ""Desserts, candies, and sweet breads"");"
"var category4 = new Category(4, ""Dairy Products"", ""Cheeses"");"
"var category5 = new Category(5, ""Grains/Cereals"", ""Breads, crackers, pasta, and cereal"");"
"var category6 = new Category(6, ""Meat/Poultry"", ""Prepared meats"");"
"var category7 = new Category(7, ""Produce"", ""Dried fruit and bean curd"");"
"var category8 = new Category(8, ""Seafood"", ""Seaweed and fish"");"

// then replace the "" using find/replace "






SELECT "var category" & CategoryId &  
		" = new Category(" & 
		CategoryId & ", """ &
		CategoryName & """, """ & 
		Description & """);"
FROM Categories

//	Just SupplierID and CategoryID
SELECT "var product" & ProductId &  
		" = new Product(" & 
		ProductId & ", """ &
		ProductName & """, """ & 
		Suppliers.SupplierId & """, """ &
		Categories.CategoryId & """, """ &
		QuantityPerUnit & """, """ &
		UnitPrice & """, """ &
		UnitsInStock & """, """ &
		UnitsOnOrder & """, """ &
		ReorderLevel & """, """ &
		Discontinued & """);"
FROM Products;


//	With ID and Name seperately 
SELECT "var product" & ProductId &  
		" = new Product(" & 
		ProductID & ", """ &
		ProductName & """, """ & 
		Suppliers.SupplierID & """, """ &
		Suppliers.CompanyName & """, """ &
		Categories.CategoryID  & """, """ &
		Categories.CategoryName & """, """ &
		QuantityPerUnit & """, """ &
		UnitPrice & """, """ &
		UnitsInStock & """, """ &
		UnitsOnOrder & """, """ &
		ReorderLevel & """, """ &
		Discontinued & """);" AS Products
FROM Suppliers INNER JOIN (Products INNER JOIN Categories ON Products.[CategoryID] = Categories.[CategoryID]) ON Suppliers.[SupplierID] = Products.[SupplierID];


//	Just CategoryName and CompanyName
SELECT "var product" & ProductId &  
		" = new Product(" & 
		ProductID & ", """ &
		ProductName & """, """ & 
		Suppliers.CompanyName & """, """ &
		Categories.CategoryName & """, """ &
		QuantityPerUnit & """, """ &
		UnitPrice & """, """ &
		UnitsInStock & """, """ &
		UnitsOnOrder & """, """ &
		ReorderLevel & """, """ &
		Discontinued & """);" AS Products
FROM Suppliers INNER JOIN (Products INNER JOIN Categories ON Products.[CategoryID] = Categories.[CategoryID]) ON Suppliers.[SupplierID] = Products.[SupplierID];

//	Just CategoryName and CompanyName with ascending 1-77
SELECT "var product" & ProductId &  
		" = new Product(" & 
		ProductID & ", """ &
		ProductName & """, """ & 
		Suppliers.CompanyName & """, """ &
		Categories.CategoryName & """, """ &
		QuantityPerUnit & """, """ &
		UnitPrice & """, """ &
		UnitsInStock & """, """ &
		UnitsOnOrder & """, """ &
		ReorderLevel & """, """ &
		Discontinued & """);" AS Products
FROM Suppliers INNER JOIN (Products INNER JOIN Categories ON Products.[CategoryID] = Categories.[CategoryID]) ON Suppliers.[SupplierID] = Products.[SupplierID]
ORDER BY Products.ProductID ASC;

//	CategoryName and CompanyName with descending 77-1
SELECT "var product" & ProductId &  
		" = new Product(" & 
		ProductID & ", """ &
		ProductName & """, """ & 
		Suppliers.CompanyName & """, """ &
		Categories.CategoryName & """, """ &
		QuantityPerUnit & """, """ &
		UnitPrice & """, """ &
		UnitsInStock & """, """ &
		UnitsOnOrder & """, """ &
		ReorderLevel & """, """ &
		Discontinued & """);" AS Products
FROM Suppliers INNER JOIN (Products INNER JOIN Categories ON Products.[CategoryID] = Categories.[CategoryID]) ON Suppliers.[SupplierID] = Products.[SupplierID]
ORDER BY Products.ProductID DESC;












































