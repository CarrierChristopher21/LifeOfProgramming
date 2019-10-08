


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



//	Output 1 function
function Output1()
{	
	var output = "ProductId: " + sortedArray[0].ProductId + "<br>ProductName: " + sortedArray[0].ProductName + "<br>SupplierId: " + sortedArray[0].SupplierId + "<br>CategtoryId: " + sortedArray[0].CategoryId + "<br>QuantityPerUnit: " + sortedArray[0].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[0].UnitPrice + "<br>UnitsInStock: " + sortedArray[0].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[0].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[0].ReorderLevel + "<br>Discontinued: " + sortedArray[0].Discontinued + "<br><br>";
	
	output += "ProductId: " + sortedArray[1].ProductId + "<br>ProductName: " + sortedArray[1].ProductName + "<br>SupplierId: " + sortedArray[1].SupplierId + "<br>CategtoryId: " + sortedArray[1].CategoryId + "<br>QuantityPerUnit: " + sortedArray[1].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[1].UnitPrice + "<br>UnitsInStock: " + sortedArray[1].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[1].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[1].ReorderLevel + "<br>Discontinued: " + sortedArray[1].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[2].ProductId + "<br>ProductName: " + sortedArray[2].ProductName + "<br>SupplierId: " + sortedArray[2].SupplierId + "<br>CategtoryId: " + sortedArray[2].CategoryId + "<br>QuantityPerUnit: " + sortedArray[2].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[2].UnitPrice + "<br>UnitsInStock: " + sortedArray[2].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[2].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[2].ReorderLevel + "<br>Discontinued: " + sortedArray[2].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[3].ProductId + "<br>ProductName: " + sortedArray[3].ProductName + "<br>SupplierId: " + sortedArray[3].SupplierId + "<br>CategtoryId: " + sortedArray[3].CategoryId + "<br>QuantityPerUnit: " + sortedArray[3].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[3].UnitPrice + "<br>UnitsInStock: " + sortedArray[3].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[3].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[3].ReorderLevel + "<br>Discontinued: " + sortedArray[3].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[4].ProductId + "<br>ProductName: " + sortedArray[4].ProductName + "<br>SupplierId: " + sortedArray[4].SupplierId + "<br>CategtoryId: " + sortedArray[4].CategoryId + "<br>QuantityPerUnit: " + sortedArray[4].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[4].UnitPrice + "<br>UnitsInStock: " + sortedArray[4].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[4].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[4].ReorderLevel + "<br>Discontinued: " + sortedArray[4].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[5].ProductId + "<br>ProductName: " + sortedArray[5].ProductName + "<br>SupplierId: " + sortedArray[5].SupplierId + "<br>CategtoryId: " + sortedArray[5].CategoryId + "<br>QuantityPerUnit: " + sortedArray[5].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[5].UnitPrice + "<br>UnitsInStock: " + sortedArray[5].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[5].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[5].ReorderLevel + "<br>Discontinued: " + sortedArray[5].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[6].ProductId + "<br>ProductName: " + sortedArray[6].ProductName + "<br>SupplierId: " + sortedArray[6].SupplierId + "<br>CategtoryId: " + sortedArray[6].CategoryId + "<br>QuantityPerUnit: " + sortedArray[6].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[6].UnitPrice + "<br>UnitsInStock: " + sortedArray[6].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[6].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[6].ReorderLevel + "<br>Discontinued: " + sortedArray[6].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[7].ProductId + "<br>ProductName: " + sortedArray[7].ProductName + "<br>SupplierId: " + sortedArray[7].SupplierId + "<br>CategtoryId: " + sortedArray[7].CategoryId + "<br>QuantityPerUnit: " + sortedArray[7].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[7].UnitPrice + "<br>UnitsInStock: " + sortedArray[7].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[7].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[7].ReorderLevel + "<br>Discontinued: " + sortedArray[7].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[8].ProductId + "<br>ProductName: " + sortedArray[8].ProductName + "<br>SupplierId: " + sortedArray[8].SupplierId + "<br>CategtoryId: " + sortedArray[8].CategoryId + "<br>QuantityPerUnit: " + sortedArray[8].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[8].UnitPrice + "<br>UnitsInStock: " + sortedArray[8].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[8].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[8].ReorderLevel + "<br>Discontinued: " + sortedArray[8].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[9].ProductId + "<br>ProductName: " + sortedArray[9].ProductName + "<br>SupplierId: " + sortedArray[9].SupplierId + "<br>CategtoryId: " + sortedArray[9].CategoryId + "<br>QuantityPerUnit: " + sortedArray[9].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[9].UnitPrice + "<br>UnitsInStock: " + sortedArray[9].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[9].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[9].ReorderLevel + "<br>Discontinued: " + sortedArray[9].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[10].ProductId + "<br>ProductName: " + sortedArray[10].ProductName + "<br>SupplierId: " + sortedArray[10].SupplierId + "<br>CategtoryId: " + sortedArray[10].CategoryId + "<br>QuantityPerUnit: " + sortedArray[10].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[10].UnitPrice + "<br>UnitsInStock: " + sortedArray[10].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[10].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[10].ReorderLevel + "<br>Discontinued: " + sortedArray[10].Discontinued + "<br><br>";
	
	output += "ProductId: " + sortedArray[11].ProductId + "<br>ProductName: " + sortedArray[11].ProductName + "<br>SupplierId: " + sortedArray[11].SupplierId + "<br>CategtoryId: " + sortedArray[11].CategoryId + "<br>QuantityPerUnit: " + sortedArray[11].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[11].UnitPrice + "<br>UnitsInStock: " + sortedArray[11].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[11].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[11].ReorderLevel + "<br>Discontinued: " + sortedArray[11].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[12].ProductId + "<br>ProductName: " + sortedArray[12].ProductName + "<br>SupplierId: " + sortedArray[12].SupplierId + "<br>CategtoryId: " + sortedArray[12].CategoryId + "<br>QuantityPerUnit: " + sortedArray[12].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[12].UnitPrice + "<br>UnitsInStock: " + sortedArray[12].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[12].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[12].ReorderLevel + "<br>Discontinued: " + sortedArray[12].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[13].ProductId + "<br>ProductName: " + sortedArray[13].ProductName + "<br>SupplierId: " + sortedArray[13].SupplierId + "<br>CategtoryId: " + sortedArray[13].CategoryId + "<br>QuantityPerUnit: " + sortedArray[13].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[13].UnitPrice + "<br>UnitsInStock: " + sortedArray[13].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[13].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[13].ReorderLevel + "<br>Discontinued: " + sortedArray[13].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[14].ProductId + "<br>ProductName: " + sortedArray[14].ProductName + "<br>SupplierId: " + sortedArray[14].SupplierId + "<br>CategtoryId: " + sortedArray[14].CategoryId + "<br>QuantityPerUnit: " + sortedArray[14].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[14].UnitPrice + "<br>UnitsInStock: " + sortedArray[14].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[14].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[14].ReorderLevel + "<br>Discontinued: " + sortedArray[14].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[15].ProductId + "<br>ProductName: " + sortedArray[15].ProductName + "<br>SupplierId: " + sortedArray[15].SupplierId + "<br>CategtoryId: " + sortedArray[15].CategoryId + "<br>QuantityPerUnit: " + sortedArray[15].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[15].UnitPrice + "<br>UnitsInStock: " + sortedArray[15].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[15].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[15].ReorderLevel + "<br>Discontinued: " + sortedArray[15].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[16].ProductId + "<br>ProductName: " + sortedArray[16].ProductName + "<br>SupplierId: " + sortedArray[16].SupplierId + "<br>CategtoryId: " + sortedArray[16].CategoryId + "<br>QuantityPerUnit: " + sortedArray[16].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[16].UnitPrice + "<br>UnitsInStock: " + sortedArray[16].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[16].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[16].ReorderLevel + "<br>Discontinued: " + sortedArray[16].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[17].ProductId + "<br>ProductName: " + sortedArray[17].ProductName + "<br>SupplierId: " + sortedArray[17].SupplierId + "<br>CategtoryId: " + sortedArray[17].CategoryId + "<br>QuantityPerUnit: " + sortedArray[17].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[17].UnitPrice + "<br>UnitsInStock: " + sortedArray[17].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[17].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[17].ReorderLevel + "<br>Discontinued: " + sortedArray[17].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[18].ProductId + "<br>ProductName: " + sortedArray[18].ProductName + "<br>SupplierId: " + sortedArray[18].SupplierId + "<br>CategtoryId: " + sortedArray[18].CategoryId + "<br>QuantityPerUnit: " + sortedArray[18].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[18].UnitPrice + "<br>UnitsInStock: " + sortedArray[18].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[18].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[18].ReorderLevel + "<br>Discontinued: " + sortedArray[18].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[19].ProductId + "<br>ProductName: " + sortedArray[19].ProductName + "<br>SupplierId: " + sortedArray[19].SupplierId + "<br>CategtoryId: " + sortedArray[19].CategoryId + "<br>QuantityPerUnit: " + sortedArray[19].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[19].UnitPrice + "<br>UnitsInStock: " + sortedArray[19].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[19].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[19].ReorderLevel + "<br>Discontinued: " + sortedArray[19].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[20].ProductId + "<br>ProductName: " + sortedArray[20].ProductName + "<br>SupplierId: " + sortedArray[20].SupplierId + "<br>CategtoryId: " + sortedArray[20].CategoryId + "<br>QuantityPerUnit: " + sortedArray[20].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[20].UnitPrice + "<br>UnitsInStock: " + sortedArray[20].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[20].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[20].ReorderLevel + "<br>Discontinued: " + sortedArray[20].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[21].ProductId + "<br>ProductName: " + sortedArray[21].ProductName + "<br>SupplierId: " + sortedArray[21].SupplierId + "<br>CategtoryId: " + sortedArray[21].CategoryId + "<br>QuantityPerUnit: " + sortedArray[21].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[21].UnitPrice + "<br>UnitsInStock: " + sortedArray[21].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[21].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[21].ReorderLevel + "<br>Discontinued: " + sortedArray[21].Discontinued + "<br><br>";
	
	output += "ProductId: " + sortedArray[22].ProductId + "<br>ProductName: " + sortedArray[22].ProductName + "<br>SupplierId: " + sortedArray[22].SupplierId + "<br>CategtoryId: " + sortedArray[22].CategoryId + "<br>QuantityPerUnit: " + sortedArray[22].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[22].UnitPrice + "<br>UnitsInStock: " + sortedArray[22].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[22].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[22].ReorderLevel + "<br>Discontinued: " + sortedArray[22].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[23].ProductId + "<br>ProductName: " + sortedArray[23].ProductName + "<br>SupplierId: " + sortedArray[23].SupplierId + "<br>CategtoryId: " + sortedArray[23].CategoryId + "<br>QuantityPerUnit: " + sortedArray[23].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[23].UnitPrice + "<br>UnitsInStock: " + sortedArray[23].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[23].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[23].ReorderLevel + "<br>Discontinued: " + sortedArray[23].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[24].ProductId + "<br>ProductName: " + sortedArray[24].ProductName + "<br>SupplierId: " + sortedArray[24].SupplierId + "<br>CategtoryId: " + sortedArray[24].CategoryId + "<br>QuantityPerUnit: " + sortedArray[24].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[24].UnitPrice + "<br>UnitsInStock: " + sortedArray[24].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[24].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[24].ReorderLevel + "<br>Discontinued: " + sortedArray[24].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[25].ProductId + "<br>ProductName: " + sortedArray[25].ProductName + "<br>SupplierId: " + sortedArray[25].SupplierId + "<br>CategtoryId: " + sortedArray[25].CategoryId + "<br>QuantityPerUnit: " + sortedArray[25].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[25].UnitPrice + "<br>UnitsInStock: " + sortedArray[25].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[25].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[25].ReorderLevel + "<br>Discontinued: " + sortedArray[25].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[26].ProductId + "<br>ProductName: " + sortedArray[26].ProductName + "<br>SupplierId: " + sortedArray[26].SupplierId + "<br>CategtoryId: " + sortedArray[26].CategoryId + "<br>QuantityPerUnit: " + sortedArray[26].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[26].UnitPrice + "<br>UnitsInStock: " + sortedArray[26].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[26].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[26].ReorderLevel + "<br>Discontinued: " + sortedArray[26].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[27].ProductId + "<br>ProductName: " + sortedArray[27].ProductName + "<br>SupplierId: " + sortedArray[27].SupplierId + "<br>CategtoryId: " + sortedArray[27].CategoryId + "<br>QuantityPerUnit: " + sortedArray[27].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[27].UnitPrice + "<br>UnitsInStock: " + sortedArray[27].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[27].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[27].ReorderLevel + "<br>Discontinued: " + sortedArray[27].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[28].ProductId + "<br>ProductName: " + sortedArray[28].ProductName + "<br>SupplierId: " + sortedArray[28].SupplierId + "<br>CategtoryId: " + sortedArray[28].CategoryId + "<br>QuantityPerUnit: " + sortedArray[28].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[28].UnitPrice + "<br>UnitsInStock: " + sortedArray[28].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[28].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[28].ReorderLevel + "<br>Discontinued: " + sortedArray[28].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[29].ProductId + "<br>ProductName: " + sortedArray[29].ProductName + "<br>SupplierId: " + sortedArray[29].SupplierId + "<br>CategtoryId: " + sortedArray[29].CategoryId + "<br>QuantityPerUnit: " + sortedArray[29].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[29].UnitPrice + "<br>UnitsInStock: " + sortedArray[29].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[29].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[29].ReorderLevel + "<br>Discontinued: " + sortedArray[29].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[30].ProductId + "<br>ProductName: " + sortedArray[30].ProductName + "<br>SupplierId: " + sortedArray[30].SupplierId + "<br>CategtoryId: " + sortedArray[30].CategoryId + "<br>QuantityPerUnit: " + sortedArray[30].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[30].UnitPrice + "<br>UnitsInStock: " + sortedArray[30].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[30].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[30].ReorderLevel + "<br>Discontinued: " + sortedArray[30].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[31].ProductId + "<br>ProductName: " + sortedArray[31].ProductName + "<br>SupplierId: " + sortedArray[31].SupplierId + "<br>CategtoryId: " + sortedArray[31].CategoryId + "<br>QuantityPerUnit: " + sortedArray[31].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[31].UnitPrice + "<br>UnitsInStock: " + sortedArray[31].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[31].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[31].ReorderLevel + "<br>Discontinued: " + sortedArray[31].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[32].ProductId + "<br>ProductName: " + sortedArray[32].ProductName + "<br>SupplierId: " + sortedArray[32].SupplierId + "<br>CategtoryId: " + sortedArray[32].CategoryId + "<br>QuantityPerUnit: " + sortedArray[32].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[32].UnitPrice + "<br>UnitsInStock: " + sortedArray[32].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[32].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[32].ReorderLevel + "<br>Discontinued: " + sortedArray[32].Discontinued + "<br><br>";
	
	output += "ProductId: " + sortedArray[33].ProductId + "<br>ProductName: " + sortedArray[33].ProductName + "<br>SupplierId: " + sortedArray[33].SupplierId + "<br>CategtoryId: " + sortedArray[33].CategoryId + "<br>QuantityPerUnit: " + sortedArray[33].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[33].UnitPrice + "<br>UnitsInStock: " + sortedArray[33].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[33].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[33].ReorderLevel + "<br>Discontinued: " + sortedArray[33].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[34].ProductId + "<br>ProductName: " + sortedArray[34].ProductName + "<br>SupplierId: " + sortedArray[34].SupplierId + "<br>CategtoryId: " + sortedArray[34].CategoryId + "<br>QuantityPerUnit: " + sortedArray[34].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[34].UnitPrice + "<br>UnitsInStock: " + sortedArray[34].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[34].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[34].ReorderLevel + "<br>Discontinued: " + sortedArray[34].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[35].ProductId + "<br>ProductName: " + sortedArray[35].ProductName + "<br>SupplierId: " + sortedArray[35].SupplierId + "<br>CategtoryId: " + sortedArray[35].CategoryId + "<br>QuantityPerUnit: " + sortedArray[35].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[35].UnitPrice + "<br>UnitsInStock: " + sortedArray[35].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[35].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[35].ReorderLevel + "<br>Discontinued: " + sortedArray[35].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[36].ProductId + "<br>ProductName: " + sortedArray[36].ProductName + "<br>SupplierId: " + sortedArray[36].SupplierId + "<br>CategtoryId: " + sortedArray[36].CategoryId + "<br>QuantityPerUnit: " + sortedArray[36].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[36].UnitPrice + "<br>UnitsInStock: " + sortedArray[36].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[36].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[36].ReorderLevel + "<br>Discontinued: " + sortedArray[36].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[37].ProductId + "<br>ProductName: " + sortedArray[37].ProductName + "<br>SupplierId: " + sortedArray[37].SupplierId + "<br>CategtoryId: " + sortedArray[37].CategoryId + "<br>QuantityPerUnit: " + sortedArray[37].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[37].UnitPrice + "<br>UnitsInStock: " + sortedArray[37].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[37].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[37].ReorderLevel + "<br>Discontinued: " + sortedArray[37].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[38].ProductId + "<br>ProductName: " + sortedArray[38].ProductName + "<br>SupplierId: " + sortedArray[38].SupplierId + "<br>CategtoryId: " + sortedArray[38].CategoryId + "<br>QuantityPerUnit: " + sortedArray[38].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[38].UnitPrice + "<br>UnitsInStock: " + sortedArray[38].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[38].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[38].ReorderLevel + "<br>Discontinued: " + sortedArray[38].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[39].ProductId + "<br>ProductName: " + sortedArray[39].ProductName + "<br>SupplierId: " + sortedArray[39].SupplierId + "<br>CategtoryId: " + sortedArray[39].CategoryId + "<br>QuantityPerUnit: " + sortedArray[39].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[39].UnitPrice + "<br>UnitsInStock: " + sortedArray[39].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[39].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[39].ReorderLevel + "<br>Discontinued: " + sortedArray[39].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[40].ProductId + "<br>ProductName: " + sortedArray[40].ProductName + "<br>SupplierId: " + sortedArray[40].SupplierId + "<br>CategtoryId: " + sortedArray[40].CategoryId + "<br>QuantityPerUnit: " + sortedArray[40].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[40].UnitPrice + "<br>UnitsInStock: " + sortedArray[40].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[40].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[40].ReorderLevel + "<br>Discontinued: " + sortedArray[40].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[41].ProductId + "<br>ProductName: " + sortedArray[41].ProductName + "<br>SupplierId: " + sortedArray[41].SupplierId + "<br>CategtoryId: " + sortedArray[41].CategoryId + "<br>QuantityPerUnit: " + sortedArray[41].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[41].UnitPrice + "<br>UnitsInStock: " + sortedArray[41].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[41].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[41].ReorderLevel + "<br>Discontinued: " + sortedArray[41].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[42].ProductId + "<br>ProductName: " + sortedArray[42].ProductName + "<br>SupplierId: " + sortedArray[42].SupplierId + "<br>CategtoryId: " + sortedArray[42].CategoryId + "<br>QuantityPerUnit: " + sortedArray[42].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[42].UnitPrice + "<br>UnitsInStock: " + sortedArray[42].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[42].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[42].ReorderLevel + "<br>Discontinued: " + sortedArray[42].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[43].ProductId + "<br>ProductName: " + sortedArray[43].ProductName + "<br>SupplierId: " + sortedArray[43].SupplierId + "<br>CategtoryId: " + sortedArray[43].CategoryId + "<br>QuantityPerUnit: " + sortedArray[43].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[43].UnitPrice + "<br>UnitsInStock: " + sortedArray[43].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[43].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[43].ReorderLevel + "<br>Discontinued: " + sortedArray[43].Discontinued + "<br><br>";
	
	output += "ProductId: " + sortedArray[44].ProductId + "<br>ProductName: " + sortedArray[44].ProductName + "<br>SupplierId: " + sortedArray[44].SupplierId + "<br>CategtoryId: " + sortedArray[44].CategoryId + "<br>QuantityPerUnit: " + sortedArray[44].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[44].UnitPrice + "<br>UnitsInStock: " + sortedArray[44].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[44].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[44].ReorderLevel + "<br>Discontinued: " + sortedArray[44].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[45].ProductId + "<br>ProductName: " + sortedArray[45].ProductName + "<br>SupplierId: " + sortedArray[45].SupplierId + "<br>CategtoryId: " + sortedArray[45].CategoryId + "<br>QuantityPerUnit: " + sortedArray[45].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[45].UnitPrice + "<br>UnitsInStock: " + sortedArray[45].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[45].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[45].ReorderLevel + "<br>Discontinued: " + sortedArray[45].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[46].ProductId + "<br>ProductName: " + sortedArray[46].ProductName + "<br>SupplierId: " + sortedArray[46].SupplierId + "<br>CategtoryId: " + sortedArray[46].CategoryId + "<br>QuantityPerUnit: " + sortedArray[46].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[46].UnitPrice + "<br>UnitsInStock: " + sortedArray[46].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[46].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[46].ReorderLevel + "<br>Discontinued: " + sortedArray[46].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[47].ProductId + "<br>ProductName: " + sortedArray[47].ProductName + "<br>SupplierId: " + sortedArray[47].SupplierId + "<br>CategtoryId: " + sortedArray[47].CategoryId + "<br>QuantityPerUnit: " + sortedArray[47].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[47].UnitPrice + "<br>UnitsInStock: " + sortedArray[47].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[47].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[47].ReorderLevel + "<br>Discontinued: " + sortedArray[47].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[48].ProductId + "<br>ProductName: " + sortedArray[48].ProductName + "<br>SupplierId: " + sortedArray[48].SupplierId + "<br>CategtoryId: " + sortedArray[48].CategoryId + "<br>QuantityPerUnit: " + sortedArray[48].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[48].UnitPrice + "<br>UnitsInStock: " + sortedArray[48].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[48].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[48].ReorderLevel + "<br>Discontinued: " + sortedArray[48].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[49].ProductId + "<br>ProductName: " + sortedArray[49].ProductName + "<br>SupplierId: " + sortedArray[49].SupplierId + "<br>CategtoryId: " + sortedArray[49].CategoryId + "<br>QuantityPerUnit: " + sortedArray[49].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[49].UnitPrice + "<br>UnitsInStock: " + sortedArray[49].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[49].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[49].ReorderLevel + "<br>Discontinued: " + sortedArray[49].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[50].ProductId + "<br>ProductName: " + sortedArray[50].ProductName + "<br>SupplierId: " + sortedArray[50].SupplierId + "<br>CategtoryId: " + sortedArray[50].CategoryId + "<br>QuantityPerUnit: " + sortedArray[50].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[50].UnitPrice + "<br>UnitsInStock: " + sortedArray[50].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[50].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[50].ReorderLevel + "<br>Discontinued: " + sortedArray[50].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[51].ProductId + "<br>ProductName: " + sortedArray[51].ProductName + "<br>SupplierId: " + sortedArray[51].SupplierId + "<br>CategtoryId: " + sortedArray[51].CategoryId + "<br>QuantityPerUnit: " + sortedArray[51].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[51].UnitPrice + "<br>UnitsInStock: " + sortedArray[51].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[51].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[51].ReorderLevel + "<br>Discontinued: " + sortedArray[51].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[52].ProductId + "<br>ProductName: " + sortedArray[52].ProductName + "<br>SupplierId: " + sortedArray[52].SupplierId + "<br>CategtoryId: " + sortedArray[52].CategoryId + "<br>QuantityPerUnit: " + sortedArray[52].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[52].UnitPrice + "<br>UnitsInStock: " + sortedArray[52].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[52].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[52].ReorderLevel + "<br>Discontinued: " + sortedArray[52].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[53].ProductId + "<br>ProductName: " + sortedArray[53].ProductName + "<br>SupplierId: " + sortedArray[53].SupplierId + "<br>CategtoryId: " + sortedArray[53].CategoryId + "<br>QuantityPerUnit: " + sortedArray[53].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[53].UnitPrice + "<br>UnitsInStock: " + sortedArray[53].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[53].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[53].ReorderLevel + "<br>Discontinued: " + sortedArray[53].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[54].ProductId + "<br>ProductName: " + sortedArray[54].ProductName + "<br>SupplierId: " + sortedArray[54].SupplierId + "<br>CategtoryId: " + sortedArray[54].CategoryId + "<br>QuantityPerUnit: " + sortedArray[54].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[54].UnitPrice + "<br>UnitsInStock: " + sortedArray[54].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[54].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[54].ReorderLevel + "<br>Discontinued: " + sortedArray[54].Discontinued + "<br><br>";
	
	output += "ProductId: " + sortedArray[55].ProductId + "<br>ProductName: " + sortedArray[55].ProductName + "<br>SupplierId: " + sortedArray[55].SupplierId + "<br>CategtoryId: " + sortedArray[55].CategoryId + "<br>QuantityPerUnit: " + sortedArray[55].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[55].UnitPrice + "<br>UnitsInStock: " + sortedArray[55].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[55].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[55].ReorderLevel + "<br>Discontinued: " + sortedArray[55].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[56].ProductId + "<br>ProductName: " + sortedArray[56].ProductName + "<br>SupplierId: " + sortedArray[56].SupplierId + "<br>CategtoryId: " + sortedArray[56].CategoryId + "<br>QuantityPerUnit: " + sortedArray[56].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[56].UnitPrice + "<br>UnitsInStock: " + sortedArray[56].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[56].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[56].ReorderLevel + "<br>Discontinued: " + sortedArray[56].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[57].ProductId + "<br>ProductName: " + sortedArray[57].ProductName + "<br>SupplierId: " + sortedArray[57].SupplierId + "<br>CategtoryId: " + sortedArray[57].CategoryId + "<br>QuantityPerUnit: " + sortedArray[57].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[57].UnitPrice + "<br>UnitsInStock: " + sortedArray[57].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[57].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[57].ReorderLevel + "<br>Discontinued: " + sortedArray[57].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[58].ProductId + "<br>ProductName: " + sortedArray[58].ProductName + "<br>SupplierId: " + sortedArray[58].SupplierId + "<br>CategtoryId: " + sortedArray[58].CategoryId + "<br>QuantityPerUnit: " + sortedArray[58].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[58].UnitPrice + "<br>UnitsInStock: " + sortedArray[58].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[58].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[58].ReorderLevel + "<br>Discontinued: " + sortedArray[58].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[59].ProductId + "<br>ProductName: " + sortedArray[59].ProductName + "<br>SupplierId: " + sortedArray[59].SupplierId + "<br>CategtoryId: " + sortedArray[59].CategoryId + "<br>QuantityPerUnit: " + sortedArray[59].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[59].UnitPrice + "<br>UnitsInStock: " + sortedArray[59].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[59].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[59].ReorderLevel + "<br>Discontinued: " + sortedArray[59].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[60].ProductId + "<br>ProductName: " + sortedArray[60].ProductName + "<br>SupplierId: " + sortedArray[60].SupplierId + "<br>CategtoryId: " + sortedArray[60].CategoryId + "<br>QuantityPerUnit: " + sortedArray[60].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[60].UnitPrice + "<br>UnitsInStock: " + sortedArray[60].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[60].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[60].ReorderLevel + "<br>Discontinued: " + sortedArray[60].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[61].ProductId + "<br>ProductName: " + sortedArray[61].ProductName + "<br>SupplierId: " + sortedArray[61].SupplierId + "<br>CategtoryId: " + sortedArray[61].CategoryId + "<br>QuantityPerUnit: " + sortedArray[61].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[61].UnitPrice + "<br>UnitsInStock: " + sortedArray[61].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[61].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[61].ReorderLevel + "<br>Discontinued: " + sortedArray[61].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[62].ProductId + "<br>ProductName: " + sortedArray[62].ProductName + "<br>SupplierId: " + sortedArray[62].SupplierId + "<br>CategtoryId: " + sortedArray[62].CategoryId + "<br>QuantityPerUnit: " + sortedArray[62].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[62].UnitPrice + "<br>UnitsInStock: " + sortedArray[62].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[62].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[62].ReorderLevel + "<br>Discontinued: " + sortedArray[62].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[63].ProductId + "<br>ProductName: " + sortedArray[63].ProductName + "<br>SupplierId: " + sortedArray[63].SupplierId + "<br>CategtoryId: " + sortedArray[63].CategoryId + "<br>QuantityPerUnit: " + sortedArray[63].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[63].UnitPrice + "<br>UnitsInStock: " + sortedArray[63].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[63].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[63].ReorderLevel + "<br>Discontinued: " + sortedArray[63].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[64].ProductId + "<br>ProductName: " + sortedArray[64].ProductName + "<br>SupplierId: " + sortedArray[64].SupplierId + "<br>CategtoryId: " + sortedArray[64].CategoryId + "<br>QuantityPerUnit: " + sortedArray[64].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[64].UnitPrice + "<br>UnitsInStock: " + sortedArray[64].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[64].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[64].ReorderLevel + "<br>Discontinued: " + sortedArray[64].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[65].ProductId + "<br>ProductName: " + sortedArray[65].ProductName + "<br>SupplierId: " + sortedArray[65].SupplierId + "<br>CategtoryId: " + sortedArray[65].CategoryId + "<br>QuantityPerUnit: " + sortedArray[65].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[65].UnitPrice + "<br>UnitsInStock: " + sortedArray[65].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[65].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[65].ReorderLevel + "<br>Discontinued: " + sortedArray[65].Discontinued + "<br><br>";
	
	output += "ProductId: " + sortedArray[66].ProductId + "<br>ProductName: " + sortedArray[66].ProductName + "<br>SupplierId: " + sortedArray[66].SupplierId + "<br>CategtoryId: " + sortedArray[66].CategoryId + "<br>QuantityPerUnit: " + sortedArray[66].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[66].UnitPrice + "<br>UnitsInStock: " + sortedArray[66].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[66].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[66].ReorderLevel + "<br>Discontinued: " + sortedArray[66].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[67].ProductId + "<br>ProductName: " + sortedArray[67].ProductName + "<br>SupplierId: " + sortedArray[67].SupplierId + "<br>CategtoryId: " + sortedArray[67].CategoryId + "<br>QuantityPerUnit: " + sortedArray[67].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[67].UnitPrice + "<br>UnitsInStock: " + sortedArray[67].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[67].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[67].ReorderLevel + "<br>Discontinued: " + sortedArray[67].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[68].ProductId + "<br>ProductName: " + sortedArray[68].ProductName + "<br>SupplierId: " + sortedArray[68].SupplierId + "<br>CategtoryId: " + sortedArray[68].CategoryId + "<br>QuantityPerUnit: " + sortedArray[68].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[68].UnitPrice + "<br>UnitsInStock: " + sortedArray[68].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[68].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[68].ReorderLevel + "<br>Discontinued: " + sortedArray[68].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[69].ProductId + "<br>ProductName: " + sortedArray[69].ProductName + "<br>SupplierId: " + sortedArray[69].SupplierId + "<br>CategtoryId: " + sortedArray[69].CategoryId + "<br>QuantityPerUnit: " + sortedArray[69].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[69].UnitPrice + "<br>UnitsInStock: " + sortedArray[69].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[69].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[69].ReorderLevel + "<br>Discontinued: " + sortedArray[69].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[70].ProductId + "<br>ProductName: " + sortedArray[70].ProductName + "<br>SupplierId: " + sortedArray[70].SupplierId + "<br>CategtoryId: " + sortedArray[70].CategoryId + "<br>QuantityPerUnit: " + sortedArray[70].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[70].UnitPrice + "<br>UnitsInStock: " + sortedArray[70].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[70].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[70].ReorderLevel + "<br>Discontinued: " + sortedArray[70].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[71].ProductId + "<br>ProductName: " + sortedArray[71].ProductName + "<br>SupplierId: " + sortedArray[71].SupplierId + "<br>CategtoryId: " + sortedArray[71].CategoryId + "<br>QuantityPerUnit: " + sortedArray[71].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[71].UnitPrice + "<br>UnitsInStock: " + sortedArray[71].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[71].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[71].ReorderLevel + "<br>Discontinued: " + sortedArray[71].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[72].ProductId + "<br>ProductName: " + sortedArray[72].ProductName + "<br>SupplierId: " + sortedArray[72].SupplierId + "<br>CategtoryId: " + sortedArray[72].CategoryId + "<br>QuantityPerUnit: " + sortedArray[72].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[72].UnitPrice + "<br>UnitsInStock: " + sortedArray[72].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[72].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[72].ReorderLevel + "<br>Discontinued: " + sortedArray[72].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[73].ProductId + "<br>ProductName: " + sortedArray[73].ProductName + "<br>SupplierId: " + sortedArray[73].SupplierId + "<br>CategtoryId: " + sortedArray[73].CategoryId + "<br>QuantityPerUnit: " + sortedArray[73].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[73].UnitPrice + "<br>UnitsInStock: " + sortedArray[73].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[73].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[73].ReorderLevel + "<br>Discontinued: " + sortedArray[73].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[74].ProductId + "<br>ProductName: " + sortedArray[74].ProductName + "<br>SupplierId: " + sortedArray[74].SupplierId + "<br>CategtoryId: " + sortedArray[74].CategoryId + "<br>QuantityPerUnit: " + sortedArray[74].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[74].UnitPrice + "<br>UnitsInStock: " + sortedArray[74].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[74].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[74].ReorderLevel + "<br>Discontinued: " + sortedArray[74].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[75].ProductId + "<br>ProductName: " + sortedArray[75].ProductName + "<br>SupplierId: " + sortedArray[75].SupplierId + "<br>CategtoryId: " + sortedArray[75].CategoryId + "<br>QuantityPerUnit: " + sortedArray[75].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[75].UnitPrice + "<br>UnitsInStock: " + sortedArray[75].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[75].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[75].ReorderLevel + "<br>Discontinued: " + sortedArray[75].Discontinued + "<br><br>";

	output += "ProductId: " + sortedArray[76].ProductId + "<br>ProductName: " + sortedArray[76].ProductName + "<br>SupplierId: " + sortedArray[76].SupplierId + "<br>CategtoryId: " + sortedArray[76].CategoryId + "<br>QuantityPerUnit: " + sortedArray[76].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[76].UnitPrice + "<br>UnitsInStock: " + sortedArray[76].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[76].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[76].ReorderLevel + "<br>Discontinued: " + sortedArray[76].Discontinued + "<br><br>";

	return output;
}

//	Output2 - less code
function Output2()
{
	var output1 = "ProductId: " + sortedArray[0].ProductId + "<br>ProductName: " + sortedArray[0].ProductName + "<br>SupplierId: " + sortedArray[0].SupplierId + "<br>CategtoryId: " + sortedArray[0].CategoryId + "<br>QuantityPerUnit: " + sortedArray[0].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[1].UnitPrice + "<br>UnitsInStock: " + sortedArray[0].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[0].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[0].ReorderLevel + "<br>Discontinued: " + sortedArray[0].Discontinued + "<br><br>";
	
	for(var i =1; ((i > 0) && (i < 77)); i++)
	{
		output1 += "ProductId: " + sortedArray[i].ProductId + "<br>ProductName: " + sortedArray[i].ProductName + "<br>SupplierId: " + sortedArray[i].SupplierId + "<br>CategtoryId: " + sortedArray[i].CategoryId + "<br>QuantityPerUnit: " + sortedArray[i].QuantityPerUnit + "<br>UnitPrice: " + sortedArray[i].UnitPrice + "<br>UnitsInStock: " + sortedArray[i].UnitsInStock + "<br>UnitsOnOrder: " + sortedArray[i].UnitsOnOrder + "<br>ReorderLevel: " + sortedArray[i].ReorderLevel + "<br>Discontinued: " + sortedArray[i].Discontinued + "<br><br>";
		
	}
	return output1;
}


























