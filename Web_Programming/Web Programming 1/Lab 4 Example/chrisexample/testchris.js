function Products (alist){

	this.myarray1 = alist;

}

Products.prototype.toTable = function(){
	
	var i = 0;
	var result = "";
	
	while(i < this.myarray1.length){
		result = result + this.myarray1[i].toRow() + "<br>";
		i++

	}
	return result;

}

function Product(aString){
	
	this.aString = aString;
	
}

Product.prototype.toRow = function(){
	
	return this.aString + "<br>";
	
}

var myresults = document.getElementById("results");

var aProduct1 = new Product("apple");
var aProduct2 = new Product("banana");
var aProduct3 = new Product("cherry");

var myarray =  [aProduct1, aProduct2, aProduct3];


var aProducts = new Products(myarray);

myresults.innerHTML = aProducts.toTable();


