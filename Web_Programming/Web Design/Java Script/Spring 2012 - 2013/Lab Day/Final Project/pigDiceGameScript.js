	
	function RollDice()
	{	
		var die1 = 0;
		var die2 = 0;
		var turn = 0;
		var userscore = 0;
		var compscore = 0;
		var num = 0;
		var dietotal = 0;
		
		var roll = document.getElementById("diceRollingForm").innerHTML.roll.submit;
		var hold = document.getElementById("diceRollingForm").innerHTML.hold.submit;
		roll = 0;
		hold = 0;
		do{	
			
			
			continue;
			//Determining whos turn it is
			var display1 = document.getElementById("imgDisplay1").innerHTML;
			var display2 = document.getElementById("imgDisplay2").innerHTML;
			var roll1 = document.getElementById("die1").type;	
			var roll2 = document.getElementById("die2").type;
			
			

			//USER'S TURN
			if(turn%2==1) // users turn
			{
				if(userscore >= 71 || compscore >= 71 || turn < hold)
				{
					click.roll;
				}
				else
				{
					click.hold;
				}
				
				alert("Human turn");
				roll = roll + roll;
				hold = hold + hold;
				dietotal = die1 + die2;
				var roll = document.forms.diceRollingForm.roll.submit;
				var hold = document.forms.diceRollingForm.hold.submit;
				if(hold)
				{
					break;
				}
				if(display1)
				{
					die1 = Math.floor(1 + Math.random() * 6); // Runs the dice number
					
					//die1 = Math.floor(1 + (Math.random() * 6));// Loop this through to keep getting a different dice 
					//number
				}
				else if(display2)
				{	
					die2 = Math.floor(1 + Math.random() * 6);
					
					
				}
				
				// LINKING THE NUMBER TO THE CORRECT DICE NUMBER PICTURE TO GO WITH THE DICE 
				var preLoadedDiceImages = new Array(5);
				if(die1 == 1 || die2 == 1)
				{
					preLoadedDiceImages[0] = new Image(100, 100);
					preLoadedDiceImages[0].src = "die1.png";
				}
				else if(die1 == 2 || die2 == 2)
				{
					preLoadedDiceImages[1] = new Image(100, 100);
					preLoadedDiceImages[1].src = "die2.png";
				}
				else if(die1 == 3 || die2 == 3)
				{
					preLoadedDiceImages[2] = new Image(100, 100);
					preLoadedDiceImages[2].src = "die3.png";
				}
				else if(die1 == 4 || die2 == 4)
				{
					preLoadedDiceImages[3] = new Image(100, 100);
					preLoadedDiceImages[3].src = "die4.png";
				}
				else if(die1 == 5 || die2 == 5)
				{
					preLoadedDiceImages[4] = new Image(100, 100);
					preLoadedDiceImages[4].src = "die5.png";
				}	
				else if(die1 == 6 || die2 == 6)
				{
					preLoadedDiceImages[5] = new Image(100, 100);
					preLoadedDiceImages[5].src = "die6.png";
				}
				
				// DOING THE MATH FOR THE USER SCORE
				if(die1 == preLoadedDiceImages[0] || die2 == preLoadedDiceImages[0])
				{
					num = 1;
					userscore = userscore + num;
				}
				else if(die1 == preLoadedDiceImages[1] || die2 == preLoadedDiceImages[1])
				{
					num = 2;
					userscore = userscore + num;
				}
				else if(die1 == preLoadedDiceImages[2] || die2 == preLoadedDiceImages[2])
				{
					num = 3;
					userscore = userscore + num;
				}
				else if(die1 == preLoadedDiceImages[3] || die2 == preLoadedDiceImages[3])
				{
					num = 4;
					userscore = score + num;
				}
				else if(die1 == preLoadedDiceImages[4] || die2 == preLoadedDiceImages[4])
				{
					num = 5;
					userscore = score + num;
				}
				else if(die1 == preLoadedDiceImages[5] || die2 == preLoadedDiceImages[5])
				{
					num = 6;
					userscore = userscore + num;
				}
				
				
				turn++;
			} //END OF USER CODE
			
			
			//COMPUTER'S TURN / CODE
			else //otherwise its odd which is computer turn
			{
				if(userscore >= 71 || compscore >= 71 || turn < hold)
				{
					click.roll;
				}
				else
				{
					click.hold;
				}
				roll = roll + roll;
				hold = hold + hold;
				dietotal = die1 + die2;
				alert("Computer Turn");
				//comphold =  (21 + round((userscore - computerscore) / 8));  //- not sure how to implement it
				var roll = document.forms.diceRollingForm.roll.submit;
				var hold = document.forms.diceRollingForm.hold.submit;
				
				if(display1)
				{
					die1 = Math.floor(1 + Math.random() * 6); // Runs the dice number
					
					//die1 = Math.floor(1 + (Math.random() * 6));// Loop this through to keep getting a different dice 
					//number
				}
				else if(display2)
				{	
					die2 = Math.floor(1 + Math.random() * 6);
				}				
				
				// LINKING THE NUMBER TO THE CORRECT DICE NUMBER PICTURE TO GO WITH THE DICE 
				var preLoadedDiceImages = new Array(5);
				if(die1 == 1 || die2 == 1)
				{
					preLoadedDiceImages[0] = new Image(100, 100);
					preLoadedDiceImages[0].src = "die1.png";
				}
				else if(die1 == 2 || die2 == 2)
				{
					preLoadedDiceImages[1] = new Image(100, 100);
					preLoadedDiceImages[1].src = "die2.png";
				}
				else if(die1 == 3 || die2 == 3)
				{
					preLoadedDiceImages[2] = new Image(100, 100);
					preLoadedDiceImages[2].src = "die3.png";
				}
				else if(die1 == 4 || die2 == 4)
				{
					preLoadedDiceImages[3] = new Image(100, 100);
					preLoadedDiceImages[3].src = "die4.png";
				}
				else if(die1 == 5 || die2 == 5)
				{
					preLoadedDiceImages[4] = new Image(100, 100);
					preLoadedDiceImages[4].src = "die5.png";
				}	
				else if(die1 == 6 || die2 == 6)
				{
					preLoadedDiceImages[5] = new Image(100, 100);
					preLoadedDiceImages[5].src = "die6.png";
				}
				
				// DOING THE MATH FOR THE COMPUTER SCORE
				if(die1 == preLoadedDiceImages[0] || die2 == preLoadedDiceImages[0])
				{
					num = 1;
					compscore = compscore + num;
				}
				else if(die1 == preLoadedDiceImages[1] || die2 == preLoadedDiceImages[1])
				{
					num = 2;
					compscore = compscore + num;
				}
				else if(die1 == preLoadedDiceImages[2] || die2 == preLoadedDiceImages[2])
				{
					num = 3;
					compscore = compscore + num;
				}
				else if(die1 == preLoadedDiceImages[3] || die2 == preLoadedDiceImages[3])
				{
					num = 4;
					compscore = compscore + num;
				}
				else if(die1 == preLoadedDiceImages[4] || die2 == preLoadedDiceImages[4])
				{
					num = 5;
					compscore = compscore + num;
				}
				else if(die1 == preLoadedDiceImages[5] || die2 == preLoadedDiceImages[5])
				{
					num = 6;
					compscore = compscore + num;
				}
				
				turn++;
			}	// END OF COMPUTER'S CODE
			

			//	CODE FOR CHANGING THE PICTURE WHEN THE BUTTON IS CLICKED
			if(die1)
			{
				//swap the image to the requested number
				document.forms.diceRollingForm.imgDisplay1.src = preLoadedDiceImages[imageNumber].src;
				//display1.src = preLoadedDiceImages[imageNumber].src;
			}
			else if(die2)
			{
				//swap the image to the requested number
				document.forms.diceRollingForm.imgDisplay2.src = preLoadedDiceImages[imageNumber].src;
				//display2.src = preLoadedDiceImages[imageNumber].src;
			}
			
			//	OUTPUT AND DECISION WHETHER ITS THE COMPUTER OR USER'S TURN
			if(num == 1) // End of turn
			{
				
				document.write("Your score is: " + userscore); 
				document.write("Computer score is: " + compscore);
				document.write("Turn total is: " + turn);
				reset(display1)
				reset(display2)
				hold++;
				break;
			}
			else if(num > 1 || num <= 6) // Continue your turn
			{
				document.write("Your score is: " + userscore); 
				document.write("Computer score is: " + compscore);
				document.write("Turn total is: " + turn);
				reset(display1)
				reset(display2)
			}
		}while(userscore >= 100 || compscore >= 100)
	
	}
			
			
			
		
			