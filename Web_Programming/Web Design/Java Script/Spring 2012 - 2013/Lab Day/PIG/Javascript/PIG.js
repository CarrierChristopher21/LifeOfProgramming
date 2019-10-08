
	var userScore = 0;
	var compScore = 0;
	var turnTotal = 0;
	var face = 1; //Class level for updating display.
	var user = true;//boolean keeps track of whether or not it's the user's turn.
	var dieF = new Array(5);
	var timeout = 0;

	function gId(id){return document.getElementById(id);}//shortens getElementById
	function preload()
	{
		var len = dieF.length;
		for(imgNum = 0; imgNum <= len; ++imgNum)
		{
			dieF[imgNum] = new Image(100, 100);
			dieF[imgNum].src = "Images/dieFaces/die" + (imgNum + 1) + ".png";
		}
	}
	function newGame() //sets and resets game
	{
		userScore = 0;
		compScore = 0;
		turnTotal = 0;
		face = 1;
		user = true;
		gId("status").style.backgroundColor = "#407EFF";
		gId("rollBtn").style.visibility = "visible";
		gId("holdBtn").style.visibility = "visible";
		gId("replayBtn").style.visibility = "hidden";
		gId("status").innerHTML = "Your Turn";
		refreshDisplay();
	}
	function roll() //used by computer and user.
	{
		face = Math.floor(Math.random() * 6) + 1;
		if (face == 1)
		{
			if (user == false)
			{
				gId("status").innerHTML = "Your Turn: Computer Rolled a One";
			}
			else
			{
				gId("status").innerHTML = "You rolled a one.";
				gId("status").style.backgroundColor = "#C11B17";
			}
			turn(1200);
		}
		else
		{
			turnTotal += face;
			if (user == true)
			{
				gId("status").innerHTML = "Your Turn";
			}
			testWin();
		}
	}
	function turn(timer) //used by computer and user.
	{
		refreshDisplay();
		turnTotal = 0;
		user = ! user
		if (user == false)
		{
			gId("rollBtn").style.visibility = "hidden";
			gId("holdBtn").style.visibility = "hidden";
			timeout = setTimeout("cTurn()", timer);
		}
		else
		{
			gId("status").style.backgroundColor = "#407EFF";
			gId("rollBtn").style.visibility = "visible";
			gId("holdBtn").style.visibility = "visible";
		}
	}
	function hold() //used only by user.
	{
		userScore += turnTotal;
		turn(100);
	}
	function cTurn() //used only by computer. computer turn
	{
		if (user == false && compScore+turnTotal < 100)
		{
			gId("status").innerHTML = "Computer's Turn";
			gId("status").style.backgroundColor = "#C11B17";
			if ((userScore >= 71) || (turnTotal < 21 + Math.round((userScore-compScore) / 8)))
			{
				roll();
			}
			else //hold
			{
				compScore += turnTotal;
				gId("status").innerHTML = "Your Turn: Computer Held " + turnTotal;
				turn(100);
			}
			timeout = setTimeout("cTurn()", 400);//displays comp rolls 400ms at a time.
		}
	}
	function testWin() //used for both user and computer.
	{
		if((user == true) && ((userScore + turnTotal) >= 100))
		{
			userScore += turnTotal;
			gameOver();
			gId("status").innerHTML = "You Win!";
		}
		else if ((user == false) && ((compScore + turnTotal) >= 100))
		{
			compScore += turnTotal;
			gameOver();
			gId("status").innerHTML = "You Lose";
		}
		refreshDisplay();
	}
	function refreshDisplay() //used constantly, for the gods.
	{
		gId("uScore").innerHTML = "User Score: "+userScore;
		gId("cScore").innerHTML = "Computer Score: "+compScore;
		gId("turnTotal").innerHTML = "Turn Total: "+turnTotal;
		gId("die").src = dieF[face - 1].src;
	}
	function gameOver()//changes accessible buttons.
	{
		gId("rollBtn").style.visibility = "hidden";
		gId("holdBtn").style.visibility = "hidden";
		gId("replayBtn").style.visibility = "visible";
	}
	
	
	
	
	
	
	
	
	
	
	