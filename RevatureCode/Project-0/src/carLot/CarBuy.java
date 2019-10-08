package carLot;

import java.util.Scanner;

import org.apache.log4j.Logger;

public class CarBuy {
	public String CarPurchase(String answer, Scanner sIn, Logger logger) {
		
		System.out.println("Do you want to buy this car? ");
		System.out.print("1 for Yes, 2 for No ");
		answer = sIn.nextLine();
		
		
		
		return answer;
		
	}
}
