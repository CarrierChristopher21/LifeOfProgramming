/*
	Class 7
	9/21/15
*/

function Category(aCategoryId, aCategoryName, aDescription)
{
	this.CategoryId = aCategoryId;
	this.CategoryName = aCategoryName;
	this.Description = aDescription;
	
}

Category.prototype.toString = function()
{
	var output = "CategoryId = " + this.CategoryId + "<br>";
		output = output + "CategoryName = " + this.CategoryName + "<br>";
		output = output + "Description = " + this.Description + "<br>";
		return output;
	
}
//	This shares the method among instances
//	instead of having a different function 
//	for eachinstance

function Shipper(aId, aName, aPhone)
{
	this.ShipperId = aId;
	this.Name = aName;
	this.Phone = aPhone;
	
}

Shipper.prototype.toString = function()
{
	var out = "ShipperId " + this.ShipperId + "<br>";
	out = out + "Shipper Name " + this.Name + "<br>";
	out = out + "Shipper Phone " + this.Phone + "<br>";
	return out;
}	


/*
	Shipper.prototype.ShipperId = 1;
	Shipper.prototype.Name = "Speedy Shippers";
	Shipper.prototype.Phone = "(123) 867-5309";
	Shipper.prototype.toString = function()
	{
		var out = "ShipperId " + this.ShipperId + "<br>";
		out = out + "Shipper Name " + this.Name + "<br>";
		out = out + "Shipper Phone " + this.Phone + "<br>";
		return out;
	}

*/

var category1 = new Category(1, "Beverages", "Soft drinks, coffee, teas, beers, and ales");
var category2 = new Category(2, "Condiments", "Sweet and savory sauces, relishes, spreads, and seasonings");

var results = document.getElementById("results");

/*
var result = category1.CategoryId + " ";
result = result + category1.CategoryName + " ";
result = result + category1.Description + "<br><br>";

result = result + category2.CategoryId + " ";
result = result + category2.CategoryName + " ";
result = result + category2.Description + "<br><br>";

result = result + "<br><br><br><br><br>";
*/

var result = category1.toString() + "<br> ";
result += category2.toString() + "<br>";

result += "category1 is an instance of Category " + (category1 instanceof Category) + " <br>";
result += "category2 is an instance of Category " + (category2 instanceof Category) + " <br>";

result += "category1 is an instance of Object " + (category1 instanceof Object) + " <br>";
result += "category2 is an instance of Object " + (category2 instanceof Object) + " <br>";
result += "<br><br><br>";

result += "category1.toString is the same as category2 toString " 
			+ (category1.toString == category2.toString) + "<br>";

			
var shipper1 = new Shipper(1, "Speedy Express", "(503) 555-9831");
var shipper2 = new Shipper(2, "United Package", "(503) 555-3199");

//	In C# or Java this would give you an error
//	But in JavaScript the prototype variable is masked 
//	by the instance 
//	Don't DO THIS!!!!
// shipper1.Name = "FedEx";

result += "<br><br><br><br><br>";

result += shipper1.toString();
result += shipper2.toString();

result += "shipper1.toString is the same as shipper2 toString "
	+ (shipper1.toString == shipper2.toString) + "<br><br>";
	
	
	
results.innerHTML = result;
























