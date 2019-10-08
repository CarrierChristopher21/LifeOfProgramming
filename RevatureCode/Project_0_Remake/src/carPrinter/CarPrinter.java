package carPrinter;

public class CarPrinter {
	
	//  Basic Print Output Call
    public void Print(String aString)
    {
        System.out.print(aString);
    }
	
    public void PrintMult(String aString) {
    	System.out.println(aString);
    }
    //  Print List Output
    public void PrintList(String aString)
    {
        System.out.println();
        System.out.print(aString);
    }
    
    //  Print Data Not Available / Wrong Information Entered
    public void PrintExist(String aString)
    {
    	System.out.println();
    	System.out.print(aString);
    	System.out.println("\n");
    }
    
    public void PrintLogin(String aString) {

    	System.out.println(aString);
    	
    }
    
    /*//  Employee List           -       4
    public void PrintEmployee(DataTable EmployeeTable)
    {
       System.out.println();

        foreach(DataRow aRow in aDataSet.Tables["EmployeeTable"].Rows)
        {
            String fullname = aRow["Employees Name"].ToString();
            System.out.println("Employee ID = " + aRow["EmployeeID"].ToString());
            System.out.println("Employee's Name = " + aRow["Employees Name"].ToString());
            System.out.println("Birth Date = " + aRow["BirthDate"].ToString());
            System.out.println("Hire Date = " + aRow["HireDate"].ToString());
            System.out.println("Address = " + aRow["Address"].ToString());
            System.out.println("Home Phone = " + aRow["HomePhone"].ToString());
            //  Console.WriteLine("Number Of Employee's = " + aDataSet.Tables["EmployeeTable"].Rows.Count);
            System.out.println();
        }
    }
    */
    
	
	
}
