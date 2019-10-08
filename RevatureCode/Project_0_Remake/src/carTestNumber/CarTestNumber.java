package carTestNumber;

import carPrinter.CarNotValid;
import carPrinter.CarPrinter;

public class CarTestNumber {
	
	CarNotValid aNotValid = new CarNotValid();
	CarPrinter aPrint = new CarPrinter();
	
//	Used from https://stackoverflow.com/questions/8391979/does-java-have-a-int-tryparse-that-doesnt-throw-an-exception-for-bad-data
	public boolean tryParseInt(String answer, int anId) {  
	     try {  
	         Integer.parseInt(answer, anId);  
	         return true;  
	      } catch (NumberFormatException e) {  
	         return false;  
	      }  
	}
	
	
	// Used from https://www.dotnetperls.com/parseint-java
	public void ConvertUserID(String answer, int anId) {
		boolean pass = tryParseInt(answer, anId);
		System.out.println(pass);
		int count = 0, number = 0;
		System.out.println("AnId = " + anId);
            // If this is a valid number, parse it.
        if (isValidNumber(answer, count)) {
            number = Integer.parseInt(answer);
            System.out.print("We are all numbers ");
            System.out.println(number);
            if(anId == 5) {
//				aUserData.setIdNumber(answer);
				
			}else {
				
				aNotValid.NotValidNumber(answer);
			}	            
        }else {
        	System.out.println("We have a Letter, Fix this");
        	aNotValid.NotValidNumber(answer);        	
        }
        
		

		
	}
	// Used from https://www.dotnetperls.com/parseint-java
	public boolean isValidNumber(String answer, int count) {
        // Loop over all characters in the String.
        // ... If isDigit is false, this method too returns false.
        for (int i = 0; i < answer.length(); i++) {
            if (!Character.isDigit(answer.charAt(i))) {
            	System.out.println("You failed");
            	count++;
            	System.out.println(count);
                return false;
            }
            count++;
        }
        return true;
    }

	
}
