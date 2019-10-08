function CalculateThrow(myThrowArray) 
{
    var positive = 0;
    var negative = 0;
	try 
	{ 
		for (var i = 0; i < myThrowArray.length; i++) 
		{
			var num = myThrowArray[i];
			if (num >= 0) 
			{
				positive = positive + num;
			} 
			else if(num < 0) 
			{
				negative = negative + Math.abs(num);
			}
			else if(x == "")
			{
				throw "is Empty";
			}
			else if(isNaN(x)) 
			{
				throw "not a number";
			}
		}
		catch(err) 
		{
			message.innerHTML = "Input " + err;
		}
    }    
	alert(positive);
	alert(negative);
    return positive > negative;
}