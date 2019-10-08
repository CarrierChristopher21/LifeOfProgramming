package carLot;

import java.util.HashMap;
import java.util.Scanner;
import java.util.logging.Logger;

import carDriverPerson.DriverPerson;
import carPrinter.CarNotValid;
import carTestNumber.CarTestNumber;

public class CarDriver {
	int anSwitchId;
	Cars aCars = new Cars();
	CarNotValid aNotValid = new CarNotValid();
	CarTestNumber aTestNumber = new CarTestNumber();
	DriverPerson aDriverPerson = new DriverPerson();
	
	static HashMap<String, Double> goWild = new HashMap<String,Double>();
	static HashMap<String, String> vehicles = new HashMap<String, String>();
	public String CarDriverHavic(String answer, Scanner sIn, Logger logger) {
		
		String car1 = "Audi-2000-1", car2 = "Audi-2018-1", car3 = "Chevy-2019-1", car4 = "Chevy-1967-1";
		String car5 = "Ford-1968-1", car6 = "Mercedes-Benz-2013-1";
		Cars.vehicledriver.add(car1);
		Cars.vehicledriver.add(car2);
		Cars.vehicledriver.add(car3);
		Cars.vehicledriver.add(car4);
		Cars.vehicledriver.add(car5);
		Cars.vehicledriver.add(car6);
		
		System.out.println("Welcome to the Car Lot!");
		System.out.println("Please pick which CarLot you want to explore! ");
		System.out.print("We have CarLots 0 - 6 (example: 0-6, 0 - ALL) ");
		answer = sIn.nextLine();
		CarDisplayTest(answer, sIn);
		
		System.out.println("DO you want to buy the selected CarLot?");
		System.out.print("Type 1 for yes and 2 for no: ");
		answer = sIn.nextLine();
		if((answer.equals("1"))) {
			System.out.println(goWild + "\n");
			System.out.println("Would you like to reject the offer? ");
			System.out.print("Choose 1 for yes and 2 for no: ");
			answer = sIn.nextLine();
			if((answer.equals("1"))) {
				System.out.print("Enter the name of the human you want to reject! ");
				answer = sIn.nextLine();
				String dropped = answer;
				aDriverPerson.setBrandName(answer);
				System.out.println("Please enter the offer you have dropped? ");
				double percent = sIn.nextDouble();
				aDriverPerson.setaPercent(percent);
				if(goWild.containsValue(percent) || goWild.containsKey(dropped)) {
					goWild.remove(dropped);
					System.out.println("Offer Declined");
				}
				if(vehicles.containsKey(dropped)) {
					System.out.println("No longer Pending");
					vehicles.remove(dropped);
				}
			}
			
		}else if(answer.equals("2")) {
			System.out.println(car1);
			System.out.println(car2);
			System.out.println(car3);
			System.out.println(car4);
			System.out.println(car5);
			System.out.println(car6);
			System.out.println("\n\n\n");
			System.out.println("Do you want to Remove a Car?");
			System.out.println("Do you want to Add a Car?");
			System.out.print("Choose 1 for Remove and 2 for Add.");
			answer = sIn.nextLine();
			if(answer.equals("1")) {
				System.out.println("\n\n");
				System.out.print("Which car do you want to remove?");
				System.out.println("Pick 1 = " + car1 + ", Pick 2 = " + car2 + ", Pick 3 = " + car3 + 
						", Pick 4 = " + car4 + ", Pick 5 = " + car5 + ", Pick 6 = " + car6);
				answer = sIn.nextLine();
				if(answer.equals("1")) {
					Cars.vehicledriver.remove(car1);
					System.out.println(car1 + " removed.");
					System.out.println(Cars.vehicledriver.toString());
					
				}else if(answer.equals("2")) {
					Cars.vehicledriver.remove(car2);
					System.out.println(car2 + " removed.");
					System.out.println(Cars.vehicledriver.toString());
					
				}else if(answer.equals("3")) {
					Cars.vehicledriver.remove(car3);
					System.out.println(car3 + " removed.");
					System.out.println(Cars.vehicledriver.toString());
					
				}else if(answer.equals("4")) {
					Cars.vehicledriver.remove(car4);
					System.out.println(car4 + " removed.");
					System.out.println(Cars.vehicledriver.toString());
					
				}else if(answer.equals("5")) {
					Cars.vehicledriver.remove(car5);
					System.out.println(car5 + " removed.");
					System.out.println(Cars.vehicledriver.toString());
					
				}else if(answer.equals("6")) {
					Cars.vehicledriver.remove(car6);
					System.out.println(car6 + " removed.");
					System.out.println(Cars.vehicledriver.toString());
					
				}
			}else if(answer.equals("2")) {
				System.out.println("\n\n");
				System.out.print("Which car do you want to remove?");
				System.out.println("Pick 1 = " + car1 + ", Pick 2 = " + car2 + ", Pick 3 = " + car3 + 
						", Pick 4 = " + car4 + ", Pick 5 = " + car5 + ", Pick 6 = " + car6);
				answer = sIn.nextLine();
				if(answer.equals("1")) {
					Cars.vehicledriver.add(car1);
					System.out.println(car1 + " added.");
					System.out.println(Cars.vehicledriver.toString());
					
				}else if(answer.equals("2")) {
					Cars.vehicledriver.add(car2);
					System.out.println(car2 + " added.");
					System.out.println(Cars.vehicledriver.toString());
					
				}else if(answer.equals("3")) {
					Cars.vehicledriver.add(car3);
					System.out.println(car3 + " added.");
					System.out.println(Cars.vehicledriver.toString());
					
				}else if(answer.equals("4")) {
					Cars.vehicledriver.add(car4);
					System.out.println(car4 + " added.");
					System.out.println(Cars.vehicledriver.toString());
					
				}else if(answer.equals("5")) {
					Cars.vehicledriver.add(car5);
					System.out.println(car5 + " added.");
					System.out.println(Cars.vehicledriver.toString());
					
				}else if(answer.equals("6")) {
					Cars.vehicledriver.add(car6);
					System.out.println(car6 + " added.");
					System.out.println(Cars.vehicledriver.toString());
					
				}
			}		
				
		}	
		
		return answer;
	}
	
	public String CarDisplayTest(String answer, Scanner sIn) {
		
		boolean pass = aTestNumber.isValidNumber(answer, anSwitchId);
		if(pass == true)
        {
        	anSwitchId = Integer.parseInt(answer);
            answer = CarTestConverter(anSwitchId, answer, sIn);
        }
        else
            aNotValid.NotValidNumber(answer);
		return answer;
		
	}
	
	public String CarTestConverter(int anSwitchId, String answer, Scanner sIn) {
		if(anSwitchId > 0 && anSwitchId <= 6 && answer != "") {				
			switch(anSwitchId) {
				case 1:	//	CarLot1
					System.out.println("\n\n");
					System.out.println("Audi-2000-1");
					System.out.println("BrandName = " + "Audi");
					System.out.println("Model = " + "A4");
					System.out.println("Year = " + "2000");
					System.out.println("How many on lot = " + "5");
					System.out.println("Price = " + "2000");
					System.out.println();
					System.out.println("\nYou have picked Lot1");
					break;
				case 2:	//	CarLot2
					System.out.println("\n\n");
					System.out.println("Audi-2018-1");
					System.out.println("BrandName = " + "Audi");
					System.out.println("Model = " + "A6");
					System.out.println("Year = " + "2018");
					System.out.println("How many on lot = " + "10");
					System.out.println("Price = " + "32000");
					System.out.println();
					System.out.println("\nYou have picked Lot2");
					break;
				case 3:	//	CarLot3
					System.out.println("\n\n");
					System.out.println("Chevy-2019-1");
					System.out.println("BrandName = " + "Chevy");
					System.out.println("Model = " + "Camaro");
					System.out.println("Year = " + "2019");
					System.out.println("How many on lot = " + "7");
					System.out.println("Price = " + "45000");
					System.out.println();
					System.out.println("\nYou have picked Lot3");
					break;
				case 4:	//	CarLot4
					System.out.println("\n\n");
					System.out.println("Chevy-1967-1");
					System.out.println("BrandName = " + "Chevy");
					System.out.println("Model = " + "Camaro");
					System.out.println("Year = " + "1967");
					System.out.println("How many on lot = " + "3");
					System.out.println("Price = " + "20000");
					System.out.println();
					System.out.println("\nYou have picked Lot4");
					break;
				case 5:	//	CarLot5
					System.out.println("\n\n");
					System.out.println("Ford-1968-1");
					System.out.println("BrandName = " + "Ford");
					System.out.println("Model = " + "Mustang");
					System.out.println("Year = " + "1968");
					System.out.println("How many on lot = " + "2");
					System.out.println("Price = " + "20000");
					System.out.println();
					System.out.println("\nYou have picked Lot5");
					break;
				case 6:	//	CarLot6
					System.out.println("\n\n");
					System.out.println("Mercedes-Benz-2013-1");
					System.out.println("BrandName = " + "Mercedes-Benz");
					System.out.println("Model = " + "CL65 AMG");
					System.out.println("Year = " + "2013");
					System.out.println("How many on lot = " + "9");
					System.out.println("Price = " + "36000");
					System.out.println();
					System.out.println("You have picked Lot6");
					break;
				case 0:
					System.out.println();
					System.out.println("\n\n");
					System.out.println("Audi-2000-1");
					System.out.println("BrandName = " + "Audi");
					System.out.println("Model = " + "A4");
					System.out.println("Year = " + "2000");
					System.out.println("How many on lot = " + "5");
					System.out.println("Price = " + "2000");
					System.out.println();
					System.out.println("\nYou have picked Lot1");
					
					System.out.println();					
					System.out.println("\n\n");
					System.out.println("Audi-2018-1");
					System.out.println("BrandName = " + "Audi");
					System.out.println("Model = " + "A6");
					System.out.println("Year = " + "2018");
					System.out.println("How many on lot = " + "10");
					System.out.println("Price = " + "32000");
					System.out.println();
					System.out.println("\nYou have picked Lot2");
					
					System.out.println();
					System.out.println("\n\n");
					System.out.println("Chevy-2019-1");
					System.out.println("BrandName = " + "Chevy");
					System.out.println("Model = " + "Camaro");
					System.out.println("Year = " + "2019");
					System.out.println("How many on lot = " + "7");
					System.out.println("Price = " + "45000");
					System.out.println();
					System.out.println("\nYou have picked Lot3");
					
					System.out.println();
					System.out.println("\n\n");
					System.out.println("Chevy-1967-1");
					System.out.println("BrandName = " + "Chevy");
					System.out.println("Model = " + "Camaro");
					System.out.println("Year = " + "1967");
					System.out.println("How many on lot = " + "3");
					System.out.println("Price = " + "20000");
					System.out.println();
					System.out.println("\nYou have picked Lot4");
					
					System.out.println();
					System.out.println("\n\n");
					System.out.println("Ford-1968-1");
					System.out.println("BrandName = " + "Ford");
					System.out.println("Model = " + "Mustang");
					System.out.println("Year = " + "1968");
					System.out.println("How many on lot = " + "2");
					System.out.println("Price = " + "20000");
					System.out.println();
					System.out.println("\nYou have picked Lot5");
					
					System.out.println();
					System.out.println("\n\n");
					System.out.println("Mercedes-Benz-2013-1");
					System.out.println("BrandName = " + "Mercedes-Benz");
					System.out.println("Model = " + "CL65 AMG");
					System.out.println("Year = " + "2013");
					System.out.println("How many on lot = " + "9");
					System.out.println("Price = " + "36000");
					System.out.println("You have picked Lot6");
					System.out.println();
					System.out.println("You have picked ALL lots!");
					
					break;
			}
		}else {
			aNotValid.NotValidNumber(answer);
		}
		
		return answer;
		
	}
}
