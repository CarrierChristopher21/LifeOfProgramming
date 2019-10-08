package carUser;

import java.io.Serializable;
import java.util.ArrayList;

/*
 * 	Serialize user information
 * 		figure out 
 * 			will need: private static final long serialVersionUID;
 * 			put in userdata then implement serializable to link to runner
 */

public class UserData implements Serializable{
	private static final long serialVersionUID = 1L;
	private String userName;
	private String password;	
	private String firstName;
	private String lastName;
	
	static ArrayList<UserData> entry = new ArrayList<>();
//	private static Object UserEntry;
	

	public String getUserName() {
		return userName;
	}
	
	public void setUserName(String userName) {
		this.userName = userName;
	}
	
	public String getPassword() {
		return password;
	}
	public void setPassword(String password) {
		this.password = password;
	}
	
	public String getFirstName() {
		return firstName;
	}
	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}
	public String getLastName() {
		return lastName;
	}
	public void setLastName(String lastName) {
		this.lastName = lastName;
	}
	
	public boolean passwordTest() {
		return false;
	}
	
	public UserData(String userName, String password, String firstName, String lastName) {
		super();
		this.userName = userName;
		this.password = password;		
		this.firstName = firstName;
		this.lastName = lastName;
	}
	public UserData() {
		super();
		// TODO Auto-generated constructor stub
	}	

	public UserData(String userName, String password) {
		super();
		this.userName = userName;
		this.password = password;
	}

	@Override
	public String toString() {
		String UserData = "";
		UserData = "User Data \n";	
		UserData += "UserName = " + userName + "\n";	
		UserData += "Password = " + password + "\n";	
		UserData += "First Name = " + firstName + "\n";
		UserData += "Last Name = " + lastName + "\n";
		return UserData;
	}

	
	
	
}
