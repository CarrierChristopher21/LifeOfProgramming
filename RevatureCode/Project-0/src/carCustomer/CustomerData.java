package carCustomer;

import java.io.Serializable;

public class CustomerData implements Serializable{

	private static final long serialVersionUID = 1L;
	private String userName = "n/a";
	private String password = "n/a";
	private String FirstName = "n/a";
	private String LastName = "n/a";
	private int age = -1;		
	private String email = "n/a";
	private String address = "n/a";
	private String city = "n/a";
	private String zip = "n/a";
	private String phone = "n/a";
	
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
	public String getAddress() {
		return address;
	}
	public void setAddress(String address) {
		this.address = address;
	}
	public String getCity() {
		return city;
	}
	public void setCity(String city) {
		this.city = city;
	}
	public String getZip() {
		return zip;
	}
	public void setZip(String zip) {
		this.zip = zip;
	}
	public String getPhone() {
		return phone;
	}
	public void setPhone(String phone) {
		this.phone = phone;
	}
	
	public boolean passwordTest() {
	// TODO Auto-generated method stub
	
		return false;	
	}
	
	public CustomerData(String userName, String password, String firstName, String lastName, 
			int age, String email, String address, String city, String zip,	String phone) {
		super();
		this.userName = userName;
		this.password = password;
		this.FirstName = firstName;
		this.LastName = lastName;
		this.age = age;
		this.email = email;
		this.address = address;
		this.city = city;
		this.zip = zip;
		this.phone = phone;
	}
	
	public CustomerData(String userName, String password) {
		super();
		this.userName = userName;
		this.password = password;
	}
	
	public CustomerData() {
		super();
		// TODO Auto-generated constructor stub
	}
	

	
	
	@Override
	public String toString() {		
		String CustomerData = "";
		CustomerData = "Customer Data \n";
		CustomerData += "UserName = " + userName + "\n";
		CustomerData += "Password = " + password + "\n";
		CustomerData += "First Name = " + FirstName + "\n";
		CustomerData += "Last Name = " + LastName + "\n";
		CustomerData += "Age = " + age	+ "\n";
		CustomerData += "Email = " + email + "\n";
		CustomerData += "Address = " + address + "\n";
		CustomerData += "City = " + city + "\n";
		CustomerData += "Zip = " + zip + "\n";
		CustomerData += "Phone = " + phone + "\n";
		
		return CustomerData; 
	}


}
