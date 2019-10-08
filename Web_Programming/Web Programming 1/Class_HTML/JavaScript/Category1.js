


function Category(aCategoryId, aCategoryName, aDescription){

	this.CategoryId = aCategoryId;
	this.CategoryName = aCategoryName;
	this.Description = aDescription;
	/*
	this.toString = function(){
		var result = "CategoryId = " + this.CategoryId + "<br />";
		result = result + "CategoryName = " + this.CategoryName + "<br />";
		result = result + "Description = " + this.Description + "<br />";	
		return result;
	}
	*/
}
// This shares the method among instances
// instead of having a different function 
// for each instance
Category.prototype.toString = function(){
		var result = "CategoryId = " + this.CategoryId + "<br />";
		result += "CategoryName = " + this.CategoryName + "<br />";
		result += "Description = " + this.Description + "<br />";	
		return result;
}


/*function Shipper(){

}

Shipper.prototype.ShipperId = 1;
Shipper.prototype.Name = "Speedy Shippers";
Shipper.prototype.Phone = "(123) 867-5309";

Shipper.prototype.toString = function(){
	var result = "Shipper Id " + this.ShipperId + "<br />";
	result = result + "Shipper Name " + this.Name + "<br />";
	result = result + "Shipper Phone " + this.Phone + "<br />";
	return result;
	
}
*/

function Shipper(anId, aName, aPhone){
	this.ShipperId = anId;
	this.Name = aName;
	this.Phone = aPhone;
}

Shipper.prototype.toString = function(){
	var result = "Shipper Id " + this.ShipperId + "<br />";
	result += "Shipper Name " + this.Name + "<br />";
	result += "Shipper Phone " + this.Phone + "<br />";
	return result;
	
}
var product1 = new Category(1, "Beverages", "Soft drinks, coffees, teas, beers, and ales");
var category2 = new Category(2, "Condiments", "Sweet and savory sauces, relishes, spreads, and seasonings");

var results = document.getElementById("results");

/*
var result = category1.CategoryId + "<br />";
result += category1.CategoryName + "<br />";
result = category1.Description + "<br /><br />";

result += category2.CategoryId + "<br />";
result += category2.CategoryName + "<br />";
result += category2.Description + "<br /><br />";

result += "<br /><br /><br /><br /><br />";
*/

var result = category1.toString() + "<br />";
result += category2.toString() + "<br />";

result += "category1 is an instance of Category " + (category1 instanceof Category) + "<br />" ;
result += "category2 is an instance of Category " + (category2 instanceof Category) + "<br />" ;
result += "category1 is an instance of Object " + (category1 instanceof Object) + "<br />" ;
result += "category2 is an instance of Object " + (category2 instanceof Object) + "<br />" ;
result += "<br /><br /><br /><br />" ;

result += "category1.toString is the same as category2 toString " 
		+ (category1.toString == category2.toString) + "<br />" ;
		
		
var shipper1 = new Shipper(1, "Speedy Express", "(503) 555-9831");
var shipper2 = new Shipper(2, "United Package", "(503) 555-3199");

// in C# or Java this would give you an error
// but in JS the prototype variable is masked
// by the instance variable
// Don't do this!!!!!!!

shipper1.Name = "FedEx";

result = result + "<br /><br /><br /><br />" ;

result += shipper1.toString() ;
result += shipper2.toString() ;

result += "shipper1.toString is the same as shipper2 toString " 
		+ (shipper1.toString == shipper2.toString) + "<br />" ;
		
results.innerHTML = result;















