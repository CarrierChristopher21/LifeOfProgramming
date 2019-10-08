package carPrinter;

import java.util.Scanner;

public class CarContinue {

	CarPrinter aPrint = new CarPrinter();
	
    public String ContinueQuestion(String answer, Scanner sIn)
    {
        answer = "";
        aPrint.Print("Do you want to continue? Y = Yes, N = No: ");
        answer = sIn.nextLine();
        return answer;
    }
	
//  While False                     -       6th Part
    public String WhileFalse(String answer,Scanner sIn)
    {
        while(!answer.contains("y") || !answer.contains("Y") || !answer.contains("n") || !answer.contains("N") || 
        		!answer.contains(""))
        {
            if(answer.equals("y") || answer.equals("Y") || answer.equals("n") || answer.equals("N") 
            		|| answer.equals(""))
            {
                break;
            }
            else
            {
                answer = WhileFalseEnd(answer, sIn);
            }
        }
        return answer;
    }
	
    //  While False End                 -       7th Part
    public String WhileFalseEnd(String answer, Scanner sIn)
    {
        //answer = "";
//        aPrint.PrintExist("Your response is not valid answer!!");
        aPrint.Print("Do you want to continue? Y = Yes, N = No: ");
        answer = sIn.nextLine();
        return answer;
    }


}






