package carCustomer;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

import carPrinter.CarNotValid;
import carPrinter.CarPrinter;
import carSerializer.UserDataAccessor;

public class CustomerRunner {
	CustomerData aCustomerData = new CustomerData();
	CarNotValid aNotValid = new CarNotValid();
	CarPrinter aPrint = new CarPrinter();
	
									//			fName	lName		10			12				
	public CustomerData aCustomer0 = new CustomerData("SharkTheDestroyer","n/a", "Chris", "Carrier", 
			28, "n/a", "12702 Bruce B Downs Blvd", "Tampa", "33612", "698-365-5486");
	
	CustomerData aCustomer1 = new CustomerData("PolarBearAnnihilator", "n/a", "Rob", "Connell", 
			31, "n/a", "3700 Sharon Gagnon Ln #101", "Anchorage", "99508", "586-698-2846");
	
	CustomerData aCustomer2 = new CustomerData("CrocTheConquer", "n/a", "Jeff", "Jamieson", 
			22, "n/a", "255 SW 11th St", "Miami", "33130", "657-252-3978" );	
	
	
	public String CustomerHavic(String answer, Scanner sIn, String file, UserDataAccessor access) {
		
		
		
//			Declare Variable Labeling
		String userName = "n/a", password = "n/a";
//		String fName = "n/a", lName = "n/a", aEmail = "n/a", aAddress = "n/a";
//		String aCity = "n/a", aZip = "n/a", aPhone = "n/a";

		int aAge = -1;
		
		List<CustomerData> aCustomer = new ArrayList<CustomerData>();
		aCustomer.add(aCustomer0);
		aCustomer.add(aCustomer1);
		aCustomer.add(aCustomer2);
		
		
		System.out.println("\nWelcome New Customer!");
		System.out.println("Please fill out this form to start shopping with us! \n");
		
		//	Customer Username
		System.out.print("\nPlease enter in your UserName ");
		userName = sIn.nextLine();
		aCustomerData.setUserName(userName);
		
		//	Customer Password
		System.out.print("\nPlease enter in your Password ");
		password = sIn.nextLine();
		aCustomerData.setPassword(password);
		
		//	First Name Section
		System.out.print("\nPlease enter in your First Name ");
		answer = sIn.nextLine();	
		aCustomerData.setFirstName(answer);
		
		//	Last Name Section
		System.out.print("\nPlease enter in your Last Name ");
		answer = sIn.nextLine();	
		aCustomerData.setLastName(answer);
		
		//	Age Section
		System.out.print("\nPlease enter in your Age ");
		aAge = Integer.parseInt(sIn.nextLine());
		aCustomerData.setAge(aAge);
		
		//	Email Section
		System.out.print("\nPlease enter in your Email ");
		answer = sIn.nextLine();	
		aCustomerData.setEmail(answer);
		
		//	Address Section
		System.out.print("\nPlease enter in your Address ");
		answer = sIn.nextLine();	
		aCustomerData.setAddress(answer);
		
		//	City Section
		System.out.print("\nPlease enter in your City ");
		answer = sIn.nextLine();	
		aCustomerData.setCity(answer);
		
		//	Zip Code Section
		System.out.print("\nPlease enter in your Zip Code ");
		answer = sIn.nextLine();	
		aCustomerData.setZip(answer);
		
		//	Phone Number Section
		System.out.print("\nPlease enter in your Phone Number ");
		answer = sIn.nextLine();		
		aCustomerData.setPhone(answer);
		
		
		
		System.out.println("\nOlly\n" + aCustomerData);
		access.writeObject(file, aCustomerData);
		access.readObject(file);

		return answer;
		
		
	}
	
}

















