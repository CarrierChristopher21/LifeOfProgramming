package carEmployee;

import java.io.Serializable;

public class EmployeeData implements Serializable{
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private String userName = "n/a";
	private String password = "n/a";
	private String FirstName = "n/a";
	private String LastName = "n/a";	
	private int age = -1;		
	private String email = "n/a";

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
		return FirstName;
	}
	public void setFirstName(String firstName) {
		this.FirstName = firstName;
	}
	public String getLastName() {
		return LastName;
	}
	public void setLastName(String lastName) {
		this.LastName = lastName;
	}
	
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		this.age = age;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	
	public boolean passwordTest() {
		return false;
	}
	
	public EmployeeData(String userName, String password, String firstName, String lastName, 
			int age, String email) {
		super();
		this.userName = userName;
		this.password = password;
		this.FirstName = firstName;
		this.LastName = lastName;
		this.age = age;
		this.email = email;
	}
	
	public EmployeeData(String userName, String password) {
		super();
		this.userName = userName;
		this.password = password;
	}
	
	public EmployeeData() {
		super();
		// TODO Auto-generated constructor stub
	}
	
	@Override
	public String toString() {
		String EmployeeData = "";
		EmployeeData = "Employee Data \n";
		EmployeeData += "Username = " + userName + "\n";
		EmployeeData += "Password = " + password + "\n";
		EmployeeData += "First Name = " + FirstName + "\n";
		EmployeeData += "Last Name = " + LastName + "\n";
		EmployeeData += "Age = " + age + "\n";
		EmployeeData += "Email = " + email + "\n";
		return EmployeeData;
	}



	
	
}
