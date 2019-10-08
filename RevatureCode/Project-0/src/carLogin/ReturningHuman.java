package carLogin;

import java.util.HashMap;
import java.util.Scanner;
import java.util.logging.Logger;

import carDriverPerson.DriverPerson;
import carLot.CarDriver;
import carPrinter.CarNotValid;
import carPrinter.CarPrinter;
import carSerializer.UserDataAccessor;

public class ReturningHuman {
	CarNotValid aNotValid = new CarNotValid();
	CarPrinter aPrint = new CarPrinter();
	CarDriver aCarDriver = new CarDriver();
	DriverPerson aDriver = new DriverPerson();
	
	public String HumanLoginHavic(String answer, Scanner sIn, String emailFile, String passwordFile, 
			String file, Logger logger, HashMap<String, DriverPerson> aDriverHashPerson, UserDataAccessor access) {
		
//		Customer Username
			aPrint.Print("\nPlease enter in your UserName ");
			emailFile = sIn.nextLine();
			aDriver.setEmail(emailFile);
			
			//	Customer Password
			aPrint.Print("\nPlease enter in your Password ");
			passwordFile = sIn.nextLine();
			aDriver.setPassword(passwordFile);
			
			if(aDriverHashPerson.containsKey(emailFile) && aDriverHashPerson.containsKey(passwordFile)) {
				aPrint.PrintList("Welcome to the Crazy World of Cars! \n");
			}else {
				aPrint.PrintList("Your are not registered please head back to the begginning to register! \n");
			}
			
		
		return answer;
	}
}
