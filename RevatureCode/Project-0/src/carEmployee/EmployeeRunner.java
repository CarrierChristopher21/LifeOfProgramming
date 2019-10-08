package carEmployee;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

import carPrinter.CarNotValid;
import carPrinter.CarPrinter;
import carSerializer.UserDataAccessor;

public class EmployeeRunner {
	
	EmployeeData aEmployeeData = new EmployeeData();
	CarNotValid aNotValid = new CarNotValid();
	CarPrinter aPrint = new CarPrinter();
	
	public EmployeeData aEmployee0 = new EmployeeData("CrocTheConquer", "n/a", "Jeff", "Jamieson", 26, "n/a");
	EmployeeData aEmployee1 = new EmployeeData("SharkTheDestroyer", "n/a", "Chris", "Carrier", 28, "n/a");
	EmployeeData aEmployee2 = new EmployeeData("PolarBearAnnihilator", "n/a", "Rob", "Connell", 32, "n/a");
	
	

	
	public String EmployeeHavic(String answer, Scanner sIn, String file, 
			UserDataAccessor access) {

		System.out.println(aEmployeeData);
//		Scanner sIn = new Scanner(System.in);
		
//		String  userName = "n/a", password = "n/a", fName = "n/a", lName = "n/a", 
//		String aEmail = "n/a";
		int aAge = -1;
		List<EmployeeData> aEmployee = new ArrayList<EmployeeData>();
		
		aEmployee.add(aEmployee0);
		aEmployee.add(aEmployee1);
		aEmployee.add(aEmployee2);
		
		//	UserName Section
		System.out.print("\nPlease enter your UserName ");
		answer = sIn.nextLine();
		aEmployeeData.setUserName(answer); 
		//	anId = IDNumber.length();
		//	ConvertUserID(IDNumber, anId);	
		//	Link to different file to test number
		
		//	Password Section
		System.out.print("\nPlease enter in your password: ");
		answer = sIn.nextLine();
		aEmployeeData.setPassword(answer);
		
		//	First Name Section
		System.out.print("\nPlease enter in your first name ");
		answer = sIn.nextLine();
		aEmployeeData.setFirstName(answer);
		
		//	Last Name Section
		System.out.print("\nPlease enter in your last name ");
		answer = sIn.nextLine();
		aEmployeeData.setLastName(answer);
		
		//	Age Section
		System.out.print("\nPlease enter in your Age ");
		aAge = Integer.parseInt(sIn.nextLine());
		aEmployeeData.setAge(aAge);
		
		//	Email Section
		System.out.print("\nPlease enter in your Email ");
		answer = sIn.nextLine();
		aEmployeeData.setEmail(answer);
		
		
		
		System.out.println("\nAhem\n" + aEmployeeData);
		//	Write File
		access.writeObject(file, aEmployeeData);
		//	Read File
		access.readObject(file);
		
		return answer;		
		
	}


	
}
