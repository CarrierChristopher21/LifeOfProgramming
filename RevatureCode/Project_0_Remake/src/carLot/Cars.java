package carLot;

import java.util.ArrayList;
import java.util.HashMap;

public class Cars extends CarLot{

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	static ArrayList<String> vehicledriver = new ArrayList<String>();
	HashMap<String, CarLot> aCar = new HashMap<String, CarLot>();
	
	CarLot Lot1 = new CarLot(); {
		
		Lot1.setBrandName("Audi");
		Lot1.setModel("A4");
		Lot1.setYear(2000);
		Lot1.setHowManyOnLot(5);
		Lot1.setPrice(2000);
		aCar.put("Audi-2000-1", Lot1);
	}
	
	CarLot Lot2 = new CarLot(); {
		
		Lot2.setBrandName("Audi");
		Lot2.setModel("A6");
		Lot2.setYear(2018);
		Lot2.setHowManyOnLot(10);
		Lot2.setPrice(32000);
		aCar.put("Audi-2018-1", Lot2);
	}
	
	CarLot Lot3 = new CarLot(); {
		
		Lot3.setBrandName("Chevy");
		Lot3.setModel("Camaro");
		Lot3.setYear(2019);
		Lot3.setHowManyOnLot(7);
		Lot3.setPrice(45000);
		aCar.put("Chevy-2019-1", Lot3);
	}
	
	CarLot Lot4 = new CarLot(); {
		
		Lot4.setBrandName("Chevy");
		Lot4.setModel("Camaro");
		Lot4.setYear(1967);
		Lot4.setHowManyOnLot(3);
		Lot4.setPrice(20000);
		aCar.put("Chevy-1967-1", Lot4);
	}
	
	CarLot Lot5 = new CarLot(); {
		
		Lot5.setBrandName("Ford");
		Lot5.setModel("Mustang");
		Lot5.setYear(1968);
		Lot5.setHowManyOnLot(2);
		Lot5.setPrice(20000);
		aCar.put("Ford-1968-1", Lot5);
	}
	
	CarLot Lot6 = new CarLot(); {
		
		Lot6.setBrandName("Mercedes-Benz");
		Lot6.setModel("CL65 AMG");
		Lot6.setYear(2013);
		Lot6.setHowManyOnLot(9);
		Lot6.setPrice(36000);
		aCar.put("Mercedes-Benz-2013-1", Lot6);
	}
	
	
	
	
	
	
	
	
	
	
	
		
		
	
}
