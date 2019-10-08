package carUser;

import java.util.Scanner;
import carCustomer.CustomerSort;
import carUser.UserData;
import carSerializer.UserDataAccessor;

public class ReturningUser {
	UserData aUserData = new UserData();
	CustomerSort aCustomerSort = new CustomerSort();
	
	public String UserLogin(String answer, Scanner sIn, String file, 
			UserDataAccessor access) {
		String userName = "n/a", password = "n/a";
		
		//	UserName Section
		System.out.print("\nPlease enter your User Name ");
		userName = sIn.nextLine();
		aUserData.setUserName(userName);
		
		//	Password Section
		System.out.print("\nPlease enter your password: ");
		password = sIn.nextLine();
		aUserData.setPassword(password);
		
		access.readObject(file);
		
		
		UserData aUserPass = new UserData(userName, password);
		
		
		if(aUserPass.passwordTest()) {
			System.out.println("\nYou may enter the dungeon!");
			System.out.println("Do you want to make a Customer Account? ");
			System.out.println("Y - Yes to be redirected to the Customer Sort.");
			System.out.println("N - No to just move on.");
			System.out.print("Please choose Y or N: ");
			answer = sIn.nextLine();
			answer.toUpperCase();
			if((answer.equals("Y")) || (answer.equals("YES")) || (answer.equals("YA"))){
				aCustomerSort.CustomerSortHavic(answer, sIn);
			}else
				return answer;			
			
		}else {
			System.out.println("Your credentials do not check out! " +
					"You shall now be invaded! ");
			
		}
		
		
		
		return answer;
	}
	
}
