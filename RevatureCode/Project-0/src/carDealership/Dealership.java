package carDealership;



import carRunners.DealershipController;
import carRunners.DealershipView;

public class Dealership {
	

	public static void main(String [] args) {

		
		//	Main Runner
		DealershipController aController = new DealershipController();
//		aController.Controller();
		@SuppressWarnings("unused")
		DealershipView aDealershipView = new DealershipView(aController);
		

		

		
		

	}



}
	/*	Old
	 		
		//	CarLot
//		CarLot aCar = new CarLot();
//		//	Customer
//		CustomerData aCustomerData = new CustomerData();
//		CustomerRunner aCustomerRunner = new CustomerRunner();
//		//	Employee
//		EmployeeData aEmployeeData = new EmployeeData();
//		EmployeeRunner aEmployeeRunner = new EmployeeRunner();
//		//	User
//		UserData aUserData = new UserData();		
//		UserRunner aUserRunner = new UserRunner();
		//	System
		SystemRunner aSytemRunner = new SystemRunner();
		
//	Scanner sIn = new Scanner(System.in);
//	String answer = "";
	

	
	//		CarLot
//	System.out.println("CarLot\n" + aCar);
//	
//	
//	//	Customer
//	System.out.println("Howdy\n" + aCustomerData);
//	System.out.println(aCustomerRunner.aCustomer0);
//	answer = aCustomerRunner.CustomerHavic(answer, sIn);
//			
//	//	Employee
//	System.out.println("Greetings\n" + aEmployeeData);
//	System.out.println(aEmployeeRunner.aEmployee0);
//	answer = aEmployeeRunner.EmployeeHavic(answer, sIn);
//	
//	//	User
//
//	System.out.println("HI\n" + aUserData);
//	System.out.println(aUserRunner.user0);
//	answer = aUserRunner.UserHavic(answer, sIn);
 * 
 		//	System
//		System.out.println("System\n" + aSytemRunner);
 * 
 * //		sIn.close();
	*/
