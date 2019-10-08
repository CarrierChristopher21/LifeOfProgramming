package carLot;

import java.util.Scanner;
import java.util.logging.Logger;
import carPrinter.CarNotValid;
public class CarRunner {
	CarNotValid aNotValid = new CarNotValid();
	Cars aCars = new Cars();
	public String CarPath(String answer, Scanner sIn, Logger logger) {
		String car1 = "Audi-2000-1", car2 = "Audi-2018-1", car3 = "Chevy-2019-1", car4 = "Chevy-1967-1";
		String car5 = "Ford-1968-1", car6 = "Mercedes-Benz-2013-1";
		
		System.out.println("What are you interested? ");
		System.out.println();
		System.out.println("Pick 1 = " + car1 + ", Pick 2 = " + car2 + ", Pick 3 = " + car3 + 
				", Pick 4 = " + car4 + ", Pick 5 = " + car5 + ", Pick 6 = " + car6);
		answer = sIn.nextLine();
		if(answer.equals("1")) {
			System.out.println(car1);
			System.out.println("BrandName = " + "Audi");
			System.out.println("Model = " + "A4");
			System.out.println("Year = " + "2000");
			System.out.println("How many on lot = " + "5");
			System.out.println("Price = " + "2000");
			
		}else if(answer.equals("2")) {
			System.out.println(car2);
			System.out.println("BrandName = " + "Audi");
			System.out.println("Model = " + "A6");
			System.out.println("Year = " + "2018");
			System.out.println("How many on lot = " + "10");
			System.out.println("Price = " + "32000");
			
		}else if(answer.equals("3")) {
			System.out.println(car3);
			System.out.println("BrandName = " + "Chevy");
			System.out.println("Model = " + "Camaro");
			System.out.println("Year = " + "2019");
			System.out.println("How many on lot = " + "7");
			System.out.println("Price = " + "45000");
			
		}else if(answer.equals("4")) {
			System.out.println(car4);
			System.out.println("BrandName = " + "Chevy");
			System.out.println("Model = " + "Camaro");
			System.out.println("Year = " + "1967");
			System.out.println("How many on lot = " + "3");
			System.out.println("Price = " + "20000");
			
		}else if(answer.equals("5")) {
			System.out.println(car5);
			System.out.println("BrandName = " + "Ford");
			System.out.println("Model = " + "Mustang");
			System.out.println("Year = " + "1968");
			System.out.println("How many on lot = " + "2");
			System.out.println("Price = " + "20000");
			
		}else if(answer.equals("6")) {
			System.out.println(car6);	
			System.out.println("BrandName = " + "Mercedes-Benz");
			System.out.println("Model = " + "CL65 AMG");
			System.out.println("Year = " + "2013");
			System.out.println("How many on lot = " + "9");
			System.out.println("Price = " + "36000");
			System.out.println("\n\n");
			
		}else {
			aNotValid.NotValidNumber(answer);
		}
		
		return answer;
	}
}
