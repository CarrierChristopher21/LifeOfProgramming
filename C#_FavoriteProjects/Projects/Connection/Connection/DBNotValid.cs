using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class DBNotValid
    {
        /*  Information about DBNotValid
            This class just responds with a invalid response as long as you don't hit enter without anything being in the entry input.
            Each response is different at times. Some are similar but are linked to different types of methods. 
        */
        DBPrintOut DBPrinter = new DBPrintOut();

        /*          Response's to Wrong Data Entries          */
        //  Not Valid Number    -   answer
        public void NotValidNumber(string answer)
        {
            if(answer != "")
            {
                DBPrinter.PrintExist("Your entry is not a valid integer / number!!");
            }
        }

        //  Not Valid Number    -   orderBy
        public void NotValidOrderNumber(string orderBy)
        {
            if(orderBy != "")
            {
                DBPrinter.PrintExist("Your entry is not a valid integer / number!!");
            }
        }

        //  File Doesn't Exist  -   answer
        public void NotValidFile(string answer)
        {
            if(answer != "")  //   Output if File doesn't exist
            {
                DBPrinter.PrintExist("The file does not exist!!");
            }
        }

        //  File doesn't Exist  -   orderBy
        public void NotValidOrderFile(string orderBy)
        {
            if(orderBy != "")  //   Output if File doesn't exist
            {
                DBPrinter.PrintExist("The file does not exist!!");
            }
        }
    }
}