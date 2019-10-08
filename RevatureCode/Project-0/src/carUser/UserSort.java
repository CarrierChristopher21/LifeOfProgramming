package carUser;

import java.util.Scanner;

import carPrinter.CarNotValid;
import carPrinter.CarPrinter;
import carSerializer.UserDataAccessor;
import carSerializer.UserSerializer;

public class UserSort {
	CarNotValid aNotValid = new CarNotValid();
	CarPrinter aPrint = new CarPrinter();
	UserRunner aUserRunner = new UserRunner();
	ReturningUser aReturningUser = new ReturningUser();
	
	static UserDataAccessor access;
	
	public String UserSortHavic(String answer, Scanner sIn) {
		access = new UserSerializer();
		String file = "./Data_Files/UserData.txt";
		
		System.out.println("\nAre you a new User or a returning User? ");
		System.out.println("1 for new User ");
		System.out.print("2 for returning User: ");
		answer = sIn.nextLine();
		
		if(answer.equals("1")) {
			aUserRunner.UserHavic(answer, sIn, file, access);
			
		}else if (answer.equals("2")) {
			aReturningUser.UserLogin(answer, sIn, file, access);
		}else {
			aNotValid.NotValidNumber(answer);
		}
		
		
		
		return answer;
	}
}
