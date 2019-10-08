package carLogin;

import java.util.HashMap;
import java.util.Scanner;
import java.util.logging.Logger;

import carDriverPerson.DriverPerson;
import carPrinter.CarNotValid;
import carPrinter.CarPrinter;
import carSerializer.UserDataAccessor;
import carSerializer.UserSerializer;

public class CarLogin {

	HumanRunner aHumanRunner = new HumanRunner();
	ReturningHuman aReturningHuman = new ReturningHuman();
	CarNotValid aNotValid = new CarNotValid();
	CarPrinter aPrint = new CarPrinter();
	
	static UserDataAccessor access;
	HashMap<String, DriverPerson> aDriverHashPerson = new HashMap<String, DriverPerson>();
	public String CustomerSortHavic(String answer, Scanner sIn, Logger logger) {
		
		access = new UserSerializer();
		
		String file = "./Data_Files/UserData.txt";
		String emailFile = "n/a";
		String passwordFile = "n/a";
		
		aPrint.PrintMult("\nDo you Have an Account? ");
		aPrint.PrintMult("1 for new Account ");
		aPrint.Print("2 for Returning Human: ");
		answer = sIn.nextLine();
		
		if(answer.equals("1")) {
			answer = aHumanRunner.HumanHavic(answer, sIn, emailFile, passwordFile, file, logger, 
					aDriverHashPerson, access);
			
		}else if (answer.equals("2")) {
			answer = aReturningHuman.HumanLoginHavic(answer, sIn, emailFile, passwordFile, file, 
					logger, aDriverHashPerson, access);
		}else {
			aNotValid.NotValidNumber(answer);
		}
		
		return answer;
	}
}
