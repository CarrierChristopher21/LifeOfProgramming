package carEmployee;

import java.util.Scanner;
import java.util.logging.Logger;

import carDriverPerson.DriverPerson;
import carLot.CarDriver;
import carPrinter.CarNotValid;
import carPrinter.CarPrinter;
import carSerializer.UserDataAccessor;
import carSerializer.UserSerializer;

public class EmployeeSort {
	CarNotValid aNotValid = new CarNotValid();
	CarPrinter aPrint = new CarPrinter();
//	EmployeeRunner aEmployeeRunner = new EmployeeRunner();
//	ReturningEmployee aReturningEmployee = new ReturningEmployee();
	CarDriver aCarDriver = new CarDriver();
	DriverPerson aDriverPerson = new DriverPerson();
	static UserDataAccessor access;
	
	public String EmployeeSortHavic(String answer, Scanner sIn, Logger logger) {
		access = new UserSerializer();
//		String file = "./Data_Files/EmployeeData.txt";
		String aEmployeeId = "ABC666";
		String anID = "n/a";
		
		System.out.println("\nSo your back again? ");
		System.out.print("Please type in your id. ");
		anID = sIn.next();
		
		aDriverPerson.setEmployeeid(anID);
		
		answer = sIn.nextLine();
		if(anID.equals(aEmployeeId)) {
			aCarDriver.CarDriverHavic(answer, sIn, logger);
		}else {
			aNotValid.NotValidNumber(answer);
		}
		
		
//		if(answer.equals("1")) {
//			aEmployeeRunner.EmployeeHavic(answer, sIn, file, access);
//			
//		}else if (answer.equals("2")) {
//			aReturningEmployee.EmployeeLogin(answer, sIn, file, access);
//		}
//		
		
		return answer;
	}
}
