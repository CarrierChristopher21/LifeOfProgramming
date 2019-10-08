package carLot;

import java.io.Serializable;

public class CarLot implements Serializable{
	

	private static final long serialVersionUID = 1L;
	private String brandName = "n/a";
	private String model = "n/a";
	private int year = -1;
	private int howManyOnLot = -1;
	private double price = 0;
	
	public String getBrandName() {
		return brandName;
	}

	public void setBrandName(String brandName) {
		this.brandName = brandName;
	}

	public String getModel() {
		return model;
	}

	public void setModel(String model) {
		this.model = model;
	}

	public int getYear() {
		return year;
	}

	public void setYear(int year) {
		this.year = year;
	}

	public int getHowManyOnLot() {
		return howManyOnLot;
	}

	public void setHowManyOnLot(int howManyOnLot) {
		this.howManyOnLot = howManyOnLot;
	}

	public double getPrice() {
		return price;
	}

	public void setPrice(double price) {
		this.price = price;
	}

	public CarLot(String brandName, String model, int year, int doors, int wheels, 
			int howManyOnLot) {
		super();
		this.brandName = brandName;
		this.model = model;
		this.year = year;
		this.howManyOnLot = howManyOnLot;
	}	
	public CarLot() {
		super();
		// TODO Auto-generated constructor stub
	}
	
	
	@Override
	public String toString() {
		String CarLot = "";
		 CarLot = "Car Lot \n";
		 CarLot += "Brand Name = " + brandName + "\n";
		 CarLot += "Model = " + model + "\n";
		 CarLot += "Year = " + year + "\n";
		 CarLot += "How Many On Lot = " + howManyOnLot + "\n";

		 return CarLot;
	}
}
















