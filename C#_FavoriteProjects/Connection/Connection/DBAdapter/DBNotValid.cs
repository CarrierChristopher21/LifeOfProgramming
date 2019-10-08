using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class DBNotValid
    {
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