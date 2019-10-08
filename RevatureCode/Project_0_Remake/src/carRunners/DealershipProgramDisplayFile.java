package carRunners;

import java.util.Scanner;
import java.util.logging.Logger;

import carDealerShip.Dealership;
import carDriverPerson.CarHuman;
import carEmployee.EmployeeSort;
import carLogin.CarLogin;
import carLot.CarDriver;
import carLot.CarRunner;
import carPrinter.CarNotValid;
import carTestNumber.CarTestNumber;

public class DealershipProgramDisplayFile extends CarHuman{

    	private final static Logger CarLog = Logger.getLogger(Logger.GLOBAL_LOGGER_NAME); 

		int anSwitchId;
	
		//	Dealership
		Dealership aDealership = new Dealership();
		int numId = -1;
		//	User - 1
		//	Employee - 2
		EmployeeSort aEmployeeSort = new EmployeeSort();
		//	System - 4
//		SystemRunner aSysRunner = new SystemRunner();
		//	Not Valid
		CarNotValid aNotValid = new CarNotValid();
		// Car TestNumber
		CarTestNumber aTestNumber = new CarTestNumber();
		//	Car Login
		CarLogin aCarLogin = new CarLogin();
		//	CarDriver
		CarDriver aCarDriver = new CarDriver();
		//	CarRunner
		CarRunner aCarRunner = new CarRunner();
		
		
	       //  Program Display                 -       3rd Part
        public String ProgramDisplay(String answer, Scanner sIn)
        {
        	
        	boolean pass = aTestNumber.isValidNumber(answer, anSwitchId);
//    		aTestNumber.ConvertUserID(answer, anId);
        	
            //bool canConvert_SwitchId = int.TryParse(answer, out anSwitchId);   // Switch - Changing value of anId to value of answer
            if(pass == true)
            {
            	anSwitchId = Integer.parseInt(answer);
				answer = ProgramConverter(anSwitchId, answer, sIn, CarLog);
            }
            else
                aNotValid.NotValidNumber(answer);
            return answer;
        }

		
		
		public String ProgramConverter(int anSwitchId, String answer, Scanner sIn, Logger logger) {
			
			if(anSwitchId > 0 && anSwitchId <= 4 && answer != "") {				
				switch(anSwitchId) {
					case 1:	//	User
						answer = aCarLogin.CustomerSortHavic(answer, sIn, CarLog);
						//	Create Customer Account - Create setup / Register Form
						break;					
					case 2:	//	Car Collection
						answer = aCarRunner.CarPath(answer, sIn, CarLog);
						
//						answer = aCarDriver.CarDriverHavic(answer, sIn, logger);
//						answer = aCustomerSort.CustomerSortHavic(answer, sIn);
						break;
					case 3:	//	Current Customer
						answer = aEmployeeSort.EmployeeSortHavic(answer, sIn, CarLog);
//						
						//	Employee Sign In	- Create set up / Login Setup
						
						break;					
					case 4:	//	System
						
						//	Offers accept / deny
						//	Manage pay outs
						break;
				}
			}else {
//				System.out.println("Please try again.");
				aNotValid.NotValidNumber(answer);
			}
			
			return answer;
		}
		
}
