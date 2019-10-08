/*
	JavaScript Northwind

*/
//	Customer
function Customer(aCustomerId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, aFax)
{

	this.CustomerId = aCustomerId;
	this.CompanyName = aCompanyName;
	this.ContactName = aContactName;
	this.ContactTitle = aContactTitle;
	this.Address = aAddress;
	this.City = aCity;
	this.Region = aRegion;
	this.PostalCode = aPostalCode;
	this.Country = aCountry;
	this.Phone = aPhone;
	this.Fax = aFax;

}

//	Customer Prototype
Customer.prototype.toString = function()
{
	var result = "CustomerId = " + this.CustomerId + "<br>";
	result += "CompanyName = " + this.CompanyName + "<br>";
	result += "ContactName = " + this.ContactName + "<br>";
	result += "ContactTitle = " + this.ContactTitle + "<br>";
	result += "Address = " + this.Address + "<br>";
	result += "City = " + this.City + "<br>";
	result += "Region = " + this.Region + "<br>";
	result += "PostalCode = " + this.PostalCode + "<br>";
	result += "Country = " + this.Country + "<br>";
	result += "Phone = " + this.Phone + "<br>";
	result += "Fax = " + this.Fax + "<br>";
	return result;
}

//	Employees
function Employees(aEmployeeId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, aExtension, aNotes, aReportsTo)
{

	this.EmployeeId = aEmployeeId;
	this.LastName = aLastName;
	this.FirstName = aFirstName;
	this.Title = aTitle;
	this.TitleOfCourtesy = aTitleOfCourtesy;
	this.BirthDate = aBirthDate;
	this.HireDate = aHireDate;	
	this.Address = aAddress;
	this.City = aCity;
	this.Region = aRegion;
	this.PostalCode = aPostalCode;
	this.Country = aCountry;
	this.HomePhone = aHomePhone;
	this.Extension = aExtension;
	this.Notes = aNotes;
	this.ReportsTo = aReportsTo;

}

//	Employees Prototype
Employees.prototype.toString = function()
{
	var result = "EmployeeId = " + this.EmployeeId + "<br>";
	result += "LastName = " + this.LastName + "<br>";
	result += "FirstName = " + this.FirstName + "<br>";
	result += "Title = " + this.Title + "<br>";
	result += "TitleOfCourtesy = " + this.TitleOfCourtesy + "<br>";
	result += "BirthDate = " + this.BirthDate + "<br>";
	result += "HireDate = " + this.HireDate + "<br>";
	result += "Address = " + this.Address + "<br>";
	result += "City = " + this.City + "<br>";
	result += "Region = " + this.Region + "<br>";
	result += "PostalCode = " + this.PostalCode + "<br>";
	result += "Country = " + this.Country + "<br>";
	result += "HomePhone = " + this.HomePhone + "<br>";
	result += "Extension = " + this.Extension + "<br>";
	result += "Notes = " + this.Notes + "<br>";
	result += "ReportsTo = " + this.ReportsTo + "<br>";
	return result;
}

//	Order Details
function OrderDetails(aOrderId, aProductId, aUnitPrice, aQuantity, aDiscount)
{

	this.OrderId = aOrderId;
	this.ProductId = aProductId;
	this.UnitPrice = aUnitPrice;
	this.Quantity = aQuantity;
	this.Discount = aDiscount;
}

//	OrderDetails Prototype
OrderDetails.prototype.toString = function()
{
	var result = "OrderId = " + this.OrderId + "<br>";
	result += "ProductId = " + this.ProductId + "<br>";
	result += "UnitPrice = " + this.UnitPrice + "<br>";
	result += "Quantity = " + this.Quantity + "<br>";
	result += "Discount = " + this.Discount + "<br>";
	return result;
}

//	Orders
function Orders(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, aShipName, aShipAddress, aShipCity, aShipRegion, aShipPostalCode, aShipCountry)
{
	this.OrderId = aOrderId;
	this.CustomerId = aCustomerId;
	this.EmployeeId = aEmployeeId;
	this.OrderDate = aOrderDate;
	this.RequiredDate = aRequiredDate;
	this.ShippedDate = aShippedDate;
	this.ShipVia = aShipVia;
	this.Freight = aFreight;
	this.ShipName = aShipName;	
	this.ShipAddress = aShipAddress;
	this.ShipCity = aShipCity;
	this.ShipRegion = aShipRegion;
	this.ShipPostalCode = aShipPostalCode;
	this.ShipCountry = aShipCountry;

}

//	Orders Prototype
Orders.prototype.toString = function()
{
	var result = "OrderId = " + this.OrderId + "<br>";
	result += "CustomerId = " + this.CustomerId + "<br>";
	result += "EmployeeId = " + this.EmployeeId + "<br>";
	result += "OrderDate = " + this.OrderDate + "<br>";
	result += "RequiredDate = " + this.RequiredDate + "<br>";
	result += "ShippedDate = " + this.ShippedDate + "<br>";
	result += "ShipVia = " + this.ShipVia + "<br>";
	result += "Freight = " + this.Freight + "<br>";
	result += "ShipName = " + this.ShipName + "<br>";
	result += "ShipAddress = " + this.ShipAddress + "<br>";
	result += "ShipCity = " + this.ShipCity + "<br>";
	result += "ShipRegion = " + this.ShipRegion + "<br>";
	result += "ShipPostalCode = " + this.ShipPostalCode + "<br>";
	result += "ShipCountry = " + this.ShipCountry + "<br>";
	return result;
}


//	Shipper
function Shipper(aShipperId, aName, aPhone){
	this.ShipperId = aShipperId;
	this.Name = aName;
	this.Phone = aPhone;
}

//	Shipper Prototype
Shipper.prototype.toString = function(){
	var result = "Shipper Id " + this.ShipperId + "<br>";
	result += "Shipper Name " + this.Name + "<br>";
	result += "Shipper Phone " + this.Phone + "<br>";
	return result;
	
}

//	Suppliers
function Supplier(aSupplierId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, aFax, aHomePage)
{

	this.SupplierId = aSupplierId;
	this.CompanyName = aCompanyName;
	this.ContactName = aContactName;
	this.ContactTitle = aContactTitle;
	this.Address = aAddress;
	this.City = aCity;
	this.Region = aRegion;
	this.PostalCode = aPostalCode;
	this.Country = aCountry;
	this.Phone = aPhone;
	this.Fax = aFax;
	this.HomePage = aHomePage;
}

//	Suppliers Prototype
Supplier.prototype.toString = function()
{
	var result = "SupplierId = " + this.SupplierId + "<br>";
	result += "CompanyName = " + this.CompanyName + "<br>";
	result += "ContactName = " + this.ContactName + "<br>";
	result += "ContactTitle = " + this.ContactTitle + "<br>";
	result += "Address = " + this.Address + "<br>";
	result += "City = " + this.City + "<br>";
	result += "Region = " + this.Region + "<br>";
	result += "PostalCode = " + this.PostalCode + "<br>";
	result += "Country = " + this.Country + "<br>";
	result += "Phone = " + this.Phone + "<br>";
	result += "Fax = " + this.Fax + "<br>";
	result += "HomePage = " + this.HomePage + "<br>";
	return result;
}




















