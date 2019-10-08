// *********
// *Product*
// *********

// Product constructor
function Product(inProductID, inProductName, inSupplierID, inCategoryID, inQuantityPerUnit, inUnitPrice, inUnitsOnOrder, inReorderLevel, inDiscontinued){
	this.ProductID = inProductID;
	this.ProductName = inProductName;
	this.SupplierID = inSupplierID;
	this.CategoryID = inCategoryID;
	this.QuantityPerUnit = inQuantityPerUnit;
	this.UnitPrice = inUnitPrice;
	this.UnitsOnOrder = inUnitsOnOrder;
	this.ReorderLevel = inReorderLevel;
	this.Discontinued = inDiscontinued;
}

// Product toString function
Product.prototype.toString = function(){
		var result = "ProductID = " + this.ProductID + "<br />";
		result += "ProductName = " + this.ProductName + "<br />";
		result += "SupplierID = " + this.SupplierID + "<br />";
		
		return result;
};

// Product toRow function
// Composes an HTML row out of a single product
Product.prototype.toRow = function(){
	var result = "<tr>";
	result += "<td>" + this.ProductID + "</td>";
	result += "<td>" + this.ProductName + "</td>";
	result += "<td>" + this.SupplierID + "</td>";
	result += "<td>" + this.CategoryID + "</td>";
	result += "<td>" + this.QuantityPerUnit + "</td>";
	result += "<td>" + this.UnitPrice + "</td>";
	result += "<td>" + this.UnitsOnOrder + "</td>";
	result += "<td>" + this.ReorderLevel + "</td>";
	result += "<td>" + this.Discontinued + "</td>";
	result += "</tr>";

	return result;
};

// **********
// *Products*
// **********

// Products constructor
function Products(inArrayOfProducts){
	this.ArrayOfProducts = [];
	this.Sorted = false;
	if (inArrayOfProducts !== undefined) {
		this.ArrayOfProducts = inArrayOfProducts;
	}
}

// Products sorting functions

Products.prototype.sortByProductIDDesc = function(){
	compare = function(a, b){
		return b.ProductID - a.ProductID;
	};
	this.ArrayOfProducts.sort(compare);
	this.Sorted = "ProductIDDesc";
};

Products.prototype.sortByProductIDAsc = function(){
	compare = function(a, b){
		return a.ProductID - b.ProductID;
	};
	this.ArrayOfProducts.sort(compare);
	this.Sorted = "ProductIDAsc";
};

Products.prototype.sortByProductNameDesc = function(){
	compare = function(a, b){
		result = 0;
		if (a.ProductName < b.ProductName) return 1;
		else if (a.ProductName > b.ProductName) return -1;
	};
	this.ArrayOfProducts.sort(compare);
	this.Sorted = "ProductNameDesc";
};

Products.prototype.sortByProductNameAsc = function(){
	compare = function(a, b){
		result = 0;
		if (a.ProductName > b.ProductName) return 1;
		else if (a.ProductName < b.ProductName) return -1;
	};
	this.ArrayOfProducts.sort(compare);
	this.Sorted = "ProductNameAsc";
};

Products.prototype.sortByUnitPriceDesc = function(){
	compare = function(a, b){
		return b.UnitPrice - a.UnitPrice;
	};
	this.ArrayOfProducts.sort(compare);
	this.Sorted = "UnitPriceDesc";
};

Products.prototype.sortByUnitPriceAsc = function(){
	compare = function(a, b){
		return a.UnitPrice - b.UnitPrice;
	};
	this.ArrayOfProducts.sort(compare);
	this.Sorted = "UnitPriceAsc";
};

// Products toTable function
Products.prototype.toTable = function(){
	result = "<table>";
	result += "<tr>";
	result += "<th id='ProductIDHeader'>ProductID</th>";
	result += "<th id='ProductNameHeader'>ProductName</th>";
	result += "<th>SupplierID</th>";
	result += "<th>CategoryID</th>";
	result += "<th>QuantityPerUnit</th>";
	result += "<th id='UnitPriceHeader'>UnitPrice</th>";
	result += "<th>UnitsOnOrder</th>";
	result += "<th>ReorderLevel</th>";
	result += "<th>Discontinued</th>";
	result += "</tr>";
	
	for(var r = 0; r < this.ArrayOfProducts.length; r++){
		result += this.ArrayOfProducts[r].toRow();
	}
	
	result += "</table>";
	return result;
};

// ******
// *AJAX*
// ******

function getTable(){
	
	
	// SQL to generate JSON
	// Note: Don't forget to add brackets [] at beginning and end of file
	// as well as to remove the comma after the last object
	/*
	SELECT
	'{"ProductID":"' & ProductID & '", ' &
	'"ProductName":"' & ProductName & '", ' &
	'"SupplierID":"' & SupplierID & '", ' &
	'"CategoryID":"' & CategoryID & '", ' &
	'"QuantityPerUnit":"' & QuantityPerUnit & '", ' &
	'"UnitPrice":"' & UnitPrice & '", ' &
	'"UnitsOnOrder":"' & UnitsOnOrder & '", ' &
	'"ReorderLevel":"' & ReorderLevel & '", ' &
	'"Discontinued":"' & Discontinued & '"}, '
	FROM Products
	*/
	
	$.getJSON("data/products.json", function(data){
	  // Create and fill a Products object
	  var products = new Products();
	  for(var i = 0; i < data.length; i++){
	    products.ArrayOfProducts.push(new Product(data[i].ProductID, data[i].ProductName, data[i].SupplierID, data[i].CategoryID, data[i].QuantityPerUnit, data[i].UnitPrice, data[i].UnitsOnOrder, data[i].ReorderLevel, data[i].Discontinued));
	  };
	  // products object now has an array of products
	  // End Result
	  
	  products.sortByProductIDAsc();
	  document.getElementById("table").innerHTML = products.toTable();
	});
}


// ***************
// *Event Binding*
// ***************

$(document).ready(function(){
	$("div#table").on("click", "th#ProductIDHeader", function(){
		if (products.Sorted == "ProductIDAsc") products.sortByProductIDDesc();
		else if (products.Sorted == "ProductIDDesc") products.sortByProductIDAsc();
		else products.sortByProductIDAsc();
		
		document.getElementById("table").innerHTML = products.toTable();
	});

	$("div#table").on("click", "th#ProductNameHeader", function(){
		if (products.Sorted == "ProductNameAsc") products.sortByProductNameDesc();
		else if (products.Sorted == "ProductNameDesc") products.sortByProductNameAsc();
		else products.sortByProductNameAsc();
		
		document.getElementById("table").innerHTML = products.toTable();
	});

	$("div#table").on("click", "th#UnitPriceHeader", function(){
		if (products.Sorted == "UnitPriceAsc") products.sortByUnitPriceDesc();
		else if (products.Sorted == "UnitPriceDesc") products.sortByUnitPriceAsc();
		else products.sortByUnitPriceAsc();
		
		document.getElementById("table").innerHTML = products.toTable();
	});
});