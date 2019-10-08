
/*
	Hunger Games Assignment
	9/5/15
	Chris Carrier
*/

//	H1 heading
var heading = document.getElementById("output");

//	Styles Function
function Styles()
{
	//	Changing H1 text
	heading.innerHTML = "Welcome to the 1,000<sup>th</sup> Hunger Games Event!!!";
	//	Making the document fontsize bigger
	document.body.style.fontSize = "larger";
}

//	Runs a function for Hunger Output
function Hunger()
{
	if(aNumber <= 9)
	{	//	Test if number is divisible by 3. If so output Hunger - Proper Spacing under 10 - Line 1
		document.write(aLine4 + aNumber + aLine1 + aString1 + aBreaker);
	}
	else if((aNumber >= 10) && (aNumber <= 99))
	{	//	Test if number is divisible by 3. If so output Hunger - Proper Spacing from 10 up to 99 - Line 2
		document.write(aLine4 + aNumber + aLine2 + aString1 + aBreaker);
	}
	else
	{	//	Test if number is divisible by 3. If so output Hunger - Proper Spacing from 100 up to 1,000 - Line 3
		document.write(aLine4 + aNumber + aLine3 + aString1 + aBreaker);
	}
	
}

//	Runs function Games Output
function Games()
{
	if(aNumber <= 9)
	{	//	Test if number is divisible by 7. If so output Games - Proper Spacing under 10 - Line 1
		document.write(aLine4 + aNumber + aLine1 + aString2 + aBreaker);
	}
	else if((aNumber >= 10) && (aNumber <= 99))
	{	//	Test if number is divisible by 7. If so output Games - Proper Spacing from 10 up to 99 - Line 2
		document.write(aLine4 + aNumber + aLine2 + aString2 + aBreaker);
	}
	else
	{	//	Test if number is divisible by 7. If so output Games - Proper Spacing from 100 up to 1,000 - Line 3
		document.write(aLine4 + aNumber + aLine3 + aString2 +aBreaker);
	}	
}

//	Runs function Hunger Games Output
function Hunger_Games()
{
	if(aNumber <= 9)
	{	//	Test if number is divisible by 3 and 7. If so output Hunger Games - Proper Spacing under 10 - Line 1
		document.write(aLine4 + aNumber + aLine1 + aString3 + aBreaker);
	}
	else if((aNumber >= 10) && (aNumber <= 99))
	{	//	Test if number is divisible by 3 and 7. If so output Hunger Games - Proper Spacing from 10 up to 99 - Line 2
		document.write(aLine4 + aNumber + aLine2 + aString3 + aBreaker);
	}
	else
	{	//	Test if number is divisible by 3 and 7. If so output Hunger Games - Proper Spacing from 100 up to 1,000 - Line 3
		document.write(aLine4 + aNumber + aLine3 + aString3 + aBreaker);
	}	
}



//	Start Number
var aNumber = 1;
//	Output Message for numbers divisible by 3
var aString1 = "Hunger";
//	Output Message for numbers divisible by 7
var aString2 = "Games";
//	Output Message for numbers divisible by 3 and 7
var aString3 = aString1 + " " + aString2;
//	Line 0 - 9
var aLine1 = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
//	Line 10 - 99
var aLine2 = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
//	Line 100 - 999
var aLine3 = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
//	Blank Lines
var aLine4 = "&nbsp;";
//	Line Breaker
var aBreaker = "<br><br>";


//	Welcome to the 1000 Hunger Games
alert("Welcome to the 1,000 Hunger Games Event!!!");
//	Calling Styles function
Styles();

	//	Loop through and up to 1000 to output the numbers and messages
while(aNumber <= 1000)
{
	if((aNumber % 3 === 0) && (aNumber % 7 == 0))
	{		//	Test if number is divisible by 3 and 7. If so output Hunger Games
		//	Calls Hunger_Games function
		Hunger_Games();
	}
	else if(aNumber % 3 === 0)
	{		//	Test  if number is divisible by 3. If so output Hunger
		//	Calls Hunger function
		Hunger();
	}	
	else if(aNumber % 7 === 0)
	{		//	Test if number is divisible by 7. If so output Games
		//	Calls Games function
		Games();
	}
	else
	{	//	Default Output if any of the previous tests don't work.
		document.write(aLine4 + aNumber + aBreaker);
	}	
	aNumber++;
}





















