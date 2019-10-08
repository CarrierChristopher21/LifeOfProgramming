package carEmployee;

import java.util.Scanner;
import carEmployee.EmployeeData;
import carLot.CarDriver;
import carPrinter.CarNotValid;
import carPrinter.CarPrinter;
import carSerializer.UserDataAccessor;

public class ReturningEmployee {
	EmployeeData aEmployeeData = new EmployeeData();
	CarNotValid aNotValid = new CarNotValid();
	CarPrinter aPrint = new CarPrinter();
	CarDriver aCarDriver = new CarDriver();

	public String EmployeeLogin(String answer, Scanner sIn, String file, 
			UserDataAccessor access) {
		
		String userName = "n/a", password = "n/a";
		
//		UserName Section
		System.out.print("\nPlease enter your UserName ");
		userName = sIn.nextLine();
		aEmployeeData.setUserName(userName); 
		
		//	Password Section
		System.out.print("\nPlease enter in your password: ");
		password = sIn.nextLine();
		aEmployeeData.setPassword(password);
		
		
		
		EmployeeData aEmployeePass = new EmployeeData(userName, password);
		access.readObject(file);
		
		if(aEmployeePass.passwordTest()) {
			System.out.println("You may enter the dungeon!");
//			aCarDriver.CarDriverHavic(answer, sIn);
			
		}else {
			System.out.println("Your credentials do not check out! " +
					"You shall now be invaded! ");
			
		}
		
		//	Write File
//		access.writeObject(file, aEmployeeData);
		//	Read File
		access.readObject(file);
		
		return answer;
		
	}
}
