package carCustomer;

import java.util.Scanner;

import carPrinter.CarNotValid;
import carPrinter.CarPrinter;
import carSerializer.UserDataAccessor;
import carSerializer.UserSerializer;

public class CustomerSort {
	CustomerData aCustomerData = new CustomerData();
	CarNotValid aNotValid = new CarNotValid();
	CarPrinter aPrint = new CarPrinter();
	CustomerRunner aCustomerRunner = new CustomerRunner();
	ReturningCustomer aReturningCustomer = new ReturningCustomer();
	
	static UserDataAccessor access;
	
	public String CustomerSortHavic(String answer, Scanner sIn) {
		
		access = new UserSerializer();
		
		String file = "./Data_Files/UserData.txt";
		
		
		System.out.println("\nAre you a new Customer or a returning Customer? ");
		System.out.println("1 for new Customer ");
		System.out.print("2 for returning Customer: ");
		answer = sIn.nextLine();
		
		if(answer.equals("1")) {
			aReturningCustomer.CustomerLogin(answer, sIn, file, access);
//			aCustomerRunner.CustomerHavic(answer, sIn, file, access);
			
//		}else if (answer.equals("2")) {
//			aReturningCustomer.CustomerLogin(answer, sIn, file, access);
		}else {
			aNotValid.NotValidNumber(answer);
		}
		
		
		return answer;	
		
	}
}
