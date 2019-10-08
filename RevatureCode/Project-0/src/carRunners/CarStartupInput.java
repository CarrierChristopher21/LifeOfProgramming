package carRunners;

import java.util.Scanner;
import carPrinter.CarPrinter;

public class CarStartupInput {
	//	Printer
	CarPrinter aPrint = new CarPrinter();
	
    public String GetStartUpInput(String answer, Scanner sIn)
    {
    	
        answer = "";
		System.out.println("\nWelcome to the wonderful World of Cars Online Car Dealership. " + 
				"\nHow may I help you today? \n");
		System.out.println("Please pick which function you want to do today? ");
        aPrint.Print("Car Login = 1 \nCar Display = 2 \nEmployee Sign in = 3 "
        		+ "\nCurrent Customer = 4 ");
        aPrint.PrintList("Press a number 1 - 4: ");
        answer = sIn.nextLine();    //  Collecting input from Console
        
        return answer;
    }
}
