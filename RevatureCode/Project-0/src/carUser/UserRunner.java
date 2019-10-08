package carUser;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

import carPrinter.CarNotValid;
import carPrinter.CarPrinter;
import carSerializer.UserDataAccessor;


public class UserRunner {
	UserData aUserData = new UserData();
						//			10			12				fName	lName
	public UserData user0 = new UserData("0123456789", "n/a", "Rob", "Connell");
	UserData user1 = new UserData("1234567890", "n/a", "Jeff", "Jamieson");
	UserData user2 = new UserData("2345678901", "n/a", "Chris", "Carrier");
	
	CarNotValid aNotValid = new CarNotValid();
	CarPrinter aPrint = new CarPrinter();
	
	public String UserHavic(String answer, Scanner sIn, String file, 
			UserDataAccessor access) {
 
		String password = "", userName = "";
		
		List<UserData> aUser = new ArrayList<UserData>();
		aUser.add(user0);
		aUser.add(user1);
		aUser.add(user2);
		
		
		//	ID Number Section
		System.out.print("\nPlease enter your User Name ");
		userName = sIn.nextLine();
		aUserData.setUserName(userName);
//		anId = userName.length();
//		aTestNumber.isValidNumber(userName, anId);	
		//	Link to different file to test number
		
		//	Password Section
		System.out.print("\nPlease enter your password: ");
		password = sIn.nextLine();
		aUserData.setPassword(password);
		//	First Name Section
		System.out.print("\nPlease enter your first name ");
		answer = sIn.nextLine();
		aUserData.setFirstName(answer);
		//	Last Name Section
		System.out.print("\nPlease enter your last name ");
		answer = sIn.nextLine();
		aUserData.setLastName(answer);
		
		
		
		
		
		
		
		System.out.println("\nAhem\n" + aUserData);
		//	Write File
		access.writeObject(file, aUserData);
		//	Read File
		access.readObject(file);

//		return;
		return answer;
		
	}
	
}













