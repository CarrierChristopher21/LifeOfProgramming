package carDriverPerson;

import java.io.Serializable;

import carLot.Cars;

public class DriverPerson extends Cars implements Serializable{


	

		/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
		private int age;
		private int offer;

		private String gender; 
		private String fName; 
		private String lName; 
		private double aPercent;
		private String order;
		private String check; 
		//Which am i
		private boolean approved;
		private String email;
		private transient String password;
		private transient String keylogin;
		private transient String employeeid;
		private transient String customerpass; 
		private transient long SSN;
		
		public int getAge() {
			return age;
		}
		
		public void setAge(int age) {
			this.age = age;
		}
		
		public int getOffer() {
			return offer;
		}
		
		public void setOffer(int offer) {
			this.offer = offer;
		}
		
		public String getGender() {
			return gender;
		}
		
		public void setGender(String gender) {
			this.gender = gender;
		}
		
		public String getFName() {
			return fName;
		}
		
		public void setFName(String fName) {
			this.fName = fName;
		}
		
		public String getLName() {
			return lName;
		}
		
		public void setLName(String lName) {
			this.lName = lName;
		}
		
		public double getaPercent() {
			return aPercent;
		}
		
		public void setaPercent(double aPercent) {
			this.aPercent = aPercent;
		}
		
		public String getOrder() {
			return order;
		}
		
		public void setOrder(String order) {
			this.order = order;
		}
		
		public String getCheck() {
			return check;
		}
		
		public void setCheck(String check) {
			this.check = check;
		}
		
		public boolean isApproved() {
//			if(Employee == true);
			return approved;
		}
		
		public void setApproved(boolean approved) {
			this.approved = approved;
		}
		
		public String getEmail() {
			return email;
		}
		
		public void setEmail(String email) {
			this.email = email;
		}
		
		public String getPassword() {
			return password;
		}
		
		public void setPassword(String password) {
			this.password = password;
		}
		
		public String getKeylogin() {
			return keylogin;
		}
		
		public void setKeylogin(String keylogin) {
			this.keylogin = keylogin;
		}
		
		public String getEmployeeid() {
			return employeeid;
		}
		
		public void setEmployeeid(String employeeid) {
			this.employeeid = employeeid;
		}
		
		public String getCustomerpass() {
			return customerpass;
		}
		
		public void setCustomerpass(String customerpass) {
			this.customerpass = customerpass;
		}
		
		public long getSSN() {
			return SSN;
		}
		
		public void setSSN(long sSN) {
			SSN = sSN;
		}
		
		public DriverPerson() {
			super();
			// TODO Auto-generated constructor stub
		}
		
		public DriverPerson(String fName, String lName,int age, int offer, String gender, double aPercent,
				String order, String check, boolean approved, String email, String password, String keylogin,
				String employeeid, String customerpass, long sSN) {
			super();			
			this.fName = fName;
			this.lName = lName;
			this.age = age;
			this.offer = offer;
			this.gender = gender;

			this.aPercent = aPercent;
			this.order = order;
			this.check = check;
			this.approved = approved;
			this.email = email;
			this.password = password;
			this.keylogin = keylogin;
			this.employeeid = employeeid;
			this.customerpass = customerpass;
			SSN = sSN;
		}

		@Override
		public String toString() {
			String DrivenPerson = "";
			DrivenPerson = "DrivenPerson \n";
			DrivenPerson += "First Name = " + fName + "\n";
			DrivenPerson += "Last Name = " + lName + "\n";
			DrivenPerson += "Email = " + email + "\n";
			DrivenPerson += "Gender = " + gender + "\n";
			DrivenPerson += "Age = " + age + "\n";
			DrivenPerson += "Payment Percent = " + aPercent + "\n";
			DrivenPerson += "Status Check = " + check + "\n";
			DrivenPerson += "Order = " + order + "\n";
			DrivenPerson += "Offer = " + offer + "\n";
			DrivenPerson += "Appoved = " + approved + "\n";
			
			return DrivenPerson;
		}
		
		public void perfectUser() {
			// TODO Auto-generated method stub
			
		}

		
		
		
		 

		
		
		
	
}

