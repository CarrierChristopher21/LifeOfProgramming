package carCustomer;

import java.util.Scanner;
import carCustomer.CustomerData;
import carLot.CarDriver;
import carPrinter.CarNotValid;
import carPrinter.CarPrinter;
import carSerializer.UserDataAccessor;

public class ReturningCustomer {
	CustomerData aCustomerData = new CustomerData();
	CarNotValid aNotValid = new CarNotValid();
	CarPrinter aPrint = new CarPrinter();
	CarDriver aCarDriver = new CarDriver();
	
	public String CustomerLogin(String answer, Scanner sIn, String file, 
			UserDataAccessor access) {
		
		String userName = "n/a", password = "n/a";
		
				
	
		//	Customer Username
		System.out.print("\nPlease enter in your UserName ");
		userName = sIn.nextLine();
		aCustomerData.setUserName(userName);
		
		//	Customer Password
		System.out.print("\nPlease enter in your Password ");
		password = sIn.nextLine();
		aCustomerData.setPassword(password);
		
		access.readObject(file);
		
		CustomerData aCustomerPass = new CustomerData(userName, password);
		
		
		if(aCustomerPass.passwordTest()) {
			System.out.println("You may enter the dungeon!");
//			aCarDriver.CarDriverHavic(answer, sIn);
		}else {
			System.out.println("Your credentials do not check out! " +
					"You shall now be invaded! ");			
		}
		

		
		access.writeObject(file, aCustomerData);
		access.readObject(file);
		
		return answer;
		
	}
}
