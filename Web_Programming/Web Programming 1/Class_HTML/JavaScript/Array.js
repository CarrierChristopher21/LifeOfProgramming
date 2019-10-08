


var mayArray = [];
var array;
var prod = "product";
var num = 1;
var ray;
var output;

//	Setting up myArray 
while((num >= 1) && (num <= 77))
{
	product = prod + num;
	ray = product;
	// alert(ray);
	
	//alert(array);
	if(num == 1)
	{
		array = ray + ", ";
	}
	else if((num >= 2) && (num <= 76))
	{
		array += ray + ", ";
	}
	else if(num == 77)
	{
		array += ray;
	}
	
	alert
	//alert(myArray);
	ray += product;
	num++;	
}

mayArray += array;
alert(mayArray);



