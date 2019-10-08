package carRunners;

import java.util.Scanner;

import carPrinter.CarContinue;

public class DealershipProgramRunner {
	//	Program Display File 
	DealershipProgramDisplayFile aProgramDisplayFile = new DealershipProgramDisplayFile();

    //  Continue
    CarContinue aContinueRunner = new CarContinue();
    //  Start Up Input
    CarStartupInput aStartupInput = new CarStartupInput();
//  Program Loop                    -       2nd Part
    public String ProgramLoop(String answer, Scanner sIn)
    {
        while(!answer.equals("")) // Beginning of loop
        {
            //  Program
            answer = aProgramDisplayFile.ProgramDisplay(answer, sIn);

            //  Program Runner for whether to Continue or Not!  
            if(!answer.equals(""))
            {
                answer = aContinueRunner.ContinueQuestion(answer, sIn);
            }
            //  Test if the proper response was given
            if(!answer.equals(""))
            {
                answer = aContinueRunner.WhileFalse(answer, sIn);
            }
            //  Continuation Question Response
            if(answer.equals("Y") || answer.equals("y"))
            {
//                Console.Clear();
                answer = aStartupInput.GetStartUpInput(answer, sIn);     //  Collecting input from Console
            }   
            else if(answer.equals("n") || answer.equals("N") || answer.equals("")) //  End of program if any of these are answered
            {                               //  During the Continuation Question
            	System.out.println("Have a Great Day! \n");
                break;
            }
        }   //  End of While statement
        return answer;
    }
	
	
}
