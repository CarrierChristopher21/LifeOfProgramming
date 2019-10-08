package carLogin;

import java.util.HashMap;
import java.util.Scanner;
import java.util.logging.Logger;

import carDriverPerson.DriverPerson;
import carPrinter.CarNotValid;
import carPrinter.CarPrinter;
import carSerializer.UserDataAccessor;

public class HumanRunner {

	CarNotValid aNotValid = new CarNotValid();
	CarPrinter aPrint = new CarPrinter();
	DriverPerson aDriver = new DriverPerson();
//	HashMap<String, DriverPerson> aDriverHashPerson = new HashMap<String, DriverPerson>();
	
	public String HumanHavic(String answer, Scanner sIn, String emailFile, String passwordFile, 
			String file, Logger logger, HashMap<String, DriverPerson> aDriverHashPerson, UserDataAccessor access) {
		int aAge = -1;

		
		aPrint.PrintMult("\nWelcome Human to the world of Cars!");
		aPrint.PrintList("Please fill out this form to start shopping with us! \n");
		
//		First Name Section
		aPrint.Print("\nPlease enter in your First Name ");
		answer = sIn.nextLine();
		aDriver.setFName(answer);
		
		//	Last Name Section
		aPrint.Print("\nPlease enter in your Last Name ");
		answer = sIn.nextLine();	
		aDriver.setLName(answer);
		
		//	Age
		aPrint.Print("\nTell us your age? ");
		aAge = Integer.parseInt(sIn.nextLine());
		aDriver.setAge(aAge);
		
		//	Gender
		aPrint.Print("\nWhat gender are you? ");
		answer = sIn.nextLine();
		answer.toLowerCase();
		if((answer.equals("male")) || answer.equals("female")) {
			aDriver.setGender(answer);
		}else {
			aNotValid.NotValidNumber(answer);
		}
		
		//	Password
		aPrint.Print("\nPlease Enter your password ");
		answer = sIn.nextLine();
		aDriver.setPassword(answer);
		
		//	Email
		aPrint.Print("\nPlease enter your Email? ");
		emailFile = sIn.nextLine();
		aDriver.setEmail(emailFile);
		
		aDriverHashPerson.put(emailFile, aDriver);
		logger.info(emailFile);
		
		
		
		return answer;
	}
	
}
