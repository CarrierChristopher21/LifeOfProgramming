package carPrinter;

public class CarNotValid {
	CarPrinter aPrint = new CarPrinter();
	
	 /*          Response's to Wrong Data Entries          */
    //  Not Valid Number    -   answer
    public void NotValidNumber(String answer)
    {
        if(!answer.equals(""))
        {
            aPrint.PrintExist("Your entry is not a valid integer / number!!");
        }
    }

    

    //  File Doesn't Exist  -   answer
    public void NotValidFile(String answer)
    {
        if(!answer.equals(""))  //   Output if File doesn't exist
        {
            aPrint.PrintExist("The file does not exist!!");
        }
    }

//  Not Valid Number    -   orderBy
//  public void NotValidOrderNumber(String orderBy)
//  {
//      if(orderBy != "")
//      {
//          aPrint.PrintExist("Your entry is not a valid integer / number!!");
//      }
//  }
    
    
//    //  File doesn't Exist  -   orderBy
//    public void NotValidOrderFile(String orderBy)
//    {
//        if(orderBy != "")  //   Output if File doesn't exist
//        {
//            DBPrinter.PrintExist("The file does not exist!!");
//        }
//    }
    
    
    
}
