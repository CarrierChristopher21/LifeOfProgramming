

console.log("Chapter 6 ");
console.log("JavaScript and TypeScript Part 2");
console.log(" ");

/**	Using Indexable Types	**/
import { Name, WeatherLocation } from "./modules/NameAndWeather";
import { Name as OtherName } from "./modules/DuplicateName";
import { TempConverter } from "./tempConverter";

let cities: { [index: string]: [string, string] } = {};

cities["London"] = ["raining", TempConverter.convertFtoC("38")];
cities["Paris"] = ["sunny", TempConverter.convertFtoC("52")];
cities["Berlin"] = ["snowing", TempConverter.convertFtoC("23")];

for(let key in cities) {
	console.log(`${key}: ${cities[key][0]}, ${cities[key][1]}`);
}
/****/


/**	Using a Tuple
import { Name, WeatherLocation } from "./modules/NameAndWeather";
import { Name as OtherName } from "./modules/DuplicateName";
import { TempConverter } from "./tempConverter";

let name = new Name("Adam", "Freeman");
let loc = new WeatherLocation("raining", "London");
let other = new OtherName();

let cTemp = TempConverter.convertFtoC("38");

let tuple: [string, string, string];
tuple = ["London", "raining", TempConverter.convertFtoC("38")]

console.log(`It is ${tuple[2]} degrees C and ${tuple[1]} in ${tuple[0]}`);
**/


/**	Using a Number Arguement
import { Name, WeatherLocation } from "./modules/NameAndWeather";
import { Name as OtherName } from "./modules/DuplicateName";
import { TempConverter } from "./tempConverter";

let name = new Name("Adam", "Freeman");
let loc = new WeatherLocation("raining", "London");
let other = new OtherName();

let cTemp = TempConverter.convertFtoC(38);

console.log(name.nameMessage);
console.log(loc.weatherMessage);
console.log(other.message);
console.log(`The temp is ${cTemp}C`);
**/


/**	Using the Wrong Type
import { Name, WeatherLocation } from "./modules/NameAndWeather";
import { Name as OtherName } from "./modules/DuplicateName";
import { TempConverter } from "./tempConverter";

let name = new Name("Adam", "Freeman");
let loc = new WeatherLocation("raining", "London");
let other = new OtherName();

let cTemp = TempConverter.convertFtoC("38");

console.log(name.nameMessage);
console.log(loc.weatherMessage);
console.log(`The temp is ${cTemp}C`);
**/


/**	Importing a Module as an Object
import * as NameAndWeatherLocation from "./modules/NameAndWeather";
import { Name as OtherName } from "./modules/DuplicateName";

let name = new NameAndWeatherLocation.Name("Adam", "Freeman");
let loc = new NameAndWeatherLocation.WeatherLocation("raining", "London");
let other = new OtherName();

console.log(name.nameMessage);
console.log(loc.weatherMessage);
console.log(other.message);
**/


/**	Using a Module Alias
import { Name, WeatherLocation } from "./modules/NameAndWeather";
import { Name as OtherName } from "./modules/DuplicateName";

let name = new Name("Adam", "Freeman");
let loc = new WeatherLocation("raining", "London");
let other = new OtherName();

console.log(name.nameMessage);
console.log(loc.weatherMessage);
console.log(other.message);
**/


/**	ImportingSpecific Types
import { Name, WeatherLocation } from "./modules/NameAndWeather";
let name = new Name("Adam", "Freeman");
let loc = new WeatherLocation("raining", "London");
	
console.log(name.nameMessage);
console.log(loc.weatherMessage);
**/


/**	Using Class Inheritance
class MyClass {
	constructor(name, weather) {
		this.name = name;
		this._weather = weather;
	}
	
	set weather(value) {
		this._weather = value;
	}
	
	get weather() {
		return `Today is ${this._weather}`;
	}
	
	printMessages() {
		console.log("Hello " + this.name + ". ");
		console.log(this.weather);
	}
}
class MySubClass extends MyClass {
	constructor(name, weather, city) {
		super(name, weather);
		this.city = city;
	}
	
	printMessages() {
		super.printMessages();
		console.log(`You are in ${this.city}`);
	}
}

let myData = new MySubClass("Adam", "sunny", "London");
myData.printMessages();
**/


/**	Using Getters and Setters
class MyClass {
	constructor(name, weather) {
		this.name = name;
		this._weather = weather;
	}
	
	set weather(value) {
		this._weather = value;
	}
	
	get weather() {
		return `Today is ${this._weather}`;
	}
	
	printMessages() {
		console.log("Hello " + this.name + ". ");
		console.log(this.weather);
	}
}
let myData = new MyClass("Adam", "sunny");
myData.printMessages();
**/


/**	JavaScript Classes VS. Protoypes
var MyClass = function MyClass(name, weather) {
	this.name = name;
	this.weather = weather;
}

MyClass.prototype.printMessages = function () {
	console.log("Hello " + this.name + ". ");
	console.log("Today is " + this.weather + ".?");
};

var myData = new MyClass("Adam", "sunny");
myData.printMessages();
**/


/**	Defining a Class
class MyClass {
	constructor(name, weather) {
		this.name = name;
		this.weather = weather;
	}
	
	printMessages() {
		console.log("Hello " + this.name + ". ");
		console.log("Today is " + this.weather + ".-");
	}
}

let myData = new MyClass("Adam", "sunny");
myData.printMessages();
**/


/**	Adding Methods to an object
let myData = {
	name: "Adam",
	weather: "sunny",
	printMessages: function () {
		console.log("Hello " + this.name + ". ");
		console.log("Today is " + this.weather + "./");
	}
};
myData.printMessages();
**/


/**	Using Object Literal Format
let myData = {
	name: "Adam",
	weather: "sunny"
};
console.log("Hello " + myData.name + ". ");
console.log("Today is " + myData.weather + ".");
**/


/**	Creating an Object
let myData = new Object();
myData.name = "Adam";
myData.weather = "sunny";

console.log("Hello " + myData.name + ".");
console.log("Today is " + myData.weather + ".");
**/


/**	Processing a Data Array 
let products = [
	{ name: "Hat", price: 24.5, stock: 10},
	{ name: "Kayak", price: 289.99, stock: 1},
	{ name: "Soccer Ball", price: 10, stock: 0 },
	{ name: "Running Shoes", price: 116.50, stock: 20 }
];

let totalValue = products
	.filter(item => item.stock > 0)
	.reduce((prev, item) => prev + (item.price * item.stock), 0);
	
console.log("Total value: $" + totalValue.toFixed(2));

**/

/**	Using the Spread Operator
let myArray = [100, "Adam", true];
let otherArray = [...myArray, 200, "Bob", false];

for ( let i = 0; i < otherArray.length; i++) {
	console.log(`Array item ${i}: ${otherArray[i]}`);
}
**/


/**	Enumerating the Contents of an Array
let myArray = [100, "Adam", true];

for (let i = 0; i < myArray.length; i++) {
	console.log("Index " + i + ": " + myArray[i]);
}

console.log("---");

myArray.forEach((value, index) => console.log("Index " + index + ": " + value));
**/


/**	Modifying the Contents of an Array
let myArray = [100, "Adam", true];
myArray[0] = "Tuesday";
console.log("Index 0: " + myArray[0]);
**/


/**	Reading the Data from an Array Index
let myArray = [100, "Adam", true];
console.log("Index 0: " + myArray[0]);
**/


/**	Using the Array Literal Style
let myArray = [100, "Adam", true];
**/


/**	Creating and Populating an Array
let myArray = new Array();
myArray[0] = 100;
myArray[1] = "Adam";
myArray[2] = true;
**/


/**	Converting Strings to Numbers
let firstVal = "5";
let secondVal = "5";

let result = Number(firstVal) + Number(secondVal);
console.log("Result: " + result);
**/


/** Using the number.toString Method
let myData1 = (5).toString() + String(5);
console.log("Result: " + myData1);
**/


/**	String Concatenation Operator Precedence
let myData1 = 5 + 5;
let myData2 = 5 + "5";

console.log("Result 1: " + myData1);
console.log("Result 2: " + myData2);
**/


/**	Identity Operator
let firstVal = 5;
let secondVal = "5";

if (firstVal === secondVal) {
	console.log("They are the same");
} else {
	console.log("They are NOT the same");
}
**/


/**	Using Equality Operator
let firstVal = 5;
let secondVal = "5";

if (firstVal == secondVal) {
	console.log("They are the same");
} else {
	console.log("They are NOT the same");
}
**/


/**	Using Conditional Statements
let name = "Adam";

if(name == "Adam") {
	console.log("Name is Adam");
} else if (name == "Jacqui") {
	console.log("Name is Jacqui");
} else {
	console.log("Name is neither Adam or Jacqui");
}

switch (name) {
	case "Adam":
		console.log("Name is Adam");
		break;
	case "Jacqui":
		console.log("Name is Jacqui");
		break;
	default:
		console.log("Name is neither Adam or Jacqui");
		break;
}
**/


/**	Defining number Values
let daysInWeek = 7;
let pi = 3.14;
let hexValue = 0xFFFF;
**/


/**	Using Template String
let messageFunction = function (weather) {
	let message = `It is ${weather} today`;
	console.log(message);
}

messageFunction("raining");
**/


/**	Defining string Variables
let firstString = "This is a string";
let secondString = 'And so is this';
**/


/**	Defining boolean Values
let firstBool = true;
let secondBool = false;
**/	


/**	Using Variable Closure
let myFunc = function(name) {
	let myLocalVar = "sunny";
	let innerFunction = function () {
		return ("Hello " + name + ". Today is " + myLocalVar + ".");
	}
	return innerFunction();
};
console.log(myFunc("Adam"));
**/


/**	Using var to Declare Variables
let messageFunction = function (name, weather) {
	var message = "Hello, Adam";
	if(weather == "sunny"){
		var message = "It is a nice day.";
		console.log(message);
	} else {
		var message = "It is " + weather + " today.";
		console.log(message);
	}
	console.log(message);
}

messageFunction("Adam", "raining");
**/


/**	Using let to Declare Variables
let messageFunction = function (name, weather) {
	let message = "Hello, Adam";
	if(weather == "sunny"){
		let message = "It is a nice day";
		console.log(message);
	} else {
		let message = "It is " + weather + " today";
		console.log(message);
	}
	console.log(message);
}

messageFunction("Adam", "raining");
**/ 


/**	Using Arrow Functions
let myFunc = (nameFunction) => ("Hello " + nameFunction() + "./");

let printName = (nameFunction, printFunction) => printFunction(myFunc(nameFunction));

printName(function () { return "Adam" }, console.log);
**/


/**	Chaining Functions Calls
let myFunc = function (nameFunction) {
	return ("Hello " + nameFunction() + ".-");
};

let printName = function (nameFunction, printFunction) {
	printFunction(myFunc(nameFunction));
}

printName(function () { return "Adam" }, console.log);
**/


/**	Using a Function as an Arguements to Another Function
let myFunc = function (nameFunction) {
	return ("Hello " + nameFunction() + ".?");
};

console.log(myFunc(function () {
	return "Adam";
}));
**/


/**	Returning a Result from a Function
let myFunc = function(name) {
	return ("Hello " + name + ".");
};

console.log(myFunc("Adam"));
**/


/**	Using a Rest Parameter
let myFunc = function (name, weather, ...extraArgs) {
	console.log("Hello " + name + ".");
	console.log("It is " + weather + " today.");
	for(let i = 0; i < extraArgs.length; i++) {
		console.log("Extra Arg: " + extraArgs[i]);
	}
};

myFunc("Adam", "sunny", "one", "two", "three");
**/


/**	Using a Default Parameter
let myFunc = function (name, weather = "raining") {
	console.log("Hello " + name + ".");
	console.log("It is " + weather + " today");
	
};

myFunc("Adam");
**/


/**	Defining Functions with Parameters
let myFunc = function(name, weather){
	console.log("Hello " + name + ".");
	console.log("It is " + weather + " today");
};

myFunc("Adam", "sunny");
**/


/**	Defining a JavaScript Function Part 2
myFunc();

function myFunc() {
	console.log("This is a statement.");
}
**/


/**	Defining a JavaScript Function Part 1
let myFunc = function () {
	console.log("This is a statement.");
};

myFunc();
**/


/**	Adding JavaScript Statements
console.log("Hello");
console.log("Apples");
console.log("This is a statement");
console.log("This is also a statement");
**/


/**	Adding a Statement
console.log("Hello");
console.log("Apples");
**/


/**	Replacing the Contents
console.log("Hello");
**/

















