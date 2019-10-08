using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class DBContinueRunner
    {
        /*  Information about DBContinueRunner
            This class is all about testing whether or not you entered a proper response. As well as if you want to continue the program. 
            If you say Yes or No or just hit enter with nothin in there you will return to the DBProgramRunner class and continue on from
            there. Yet if you don't enter the proper response's then you will just keep receiving a invalid response to the entry that
            you entered in the cmd. It will continue to ask you if you want to continue until you enter a proper response.
        */
        DBController aDBController = new DBController();
        DBNotValid aNotValid = new DBNotValid();
        DBPrintOut aPrint = new DBPrintOut();

        //  Continue Question               -       5th Part
        public string ContinueQuestion(string answer)
        {
            answer = "";
            aPrint.Print("Do you want to continue? Y = Yes, N = No: ");
            answer = Console.ReadLine();
            return answer;
        }

        //  While False                     -       6th Part
        public string WhileFalse(string answer)
        {
            while(answer != "y" || answer != "Y" || answer != "n" || answer != "N" || answer != "")
            {
                if(answer == "Y" || answer == "y" || answer == "n" || answer == "N" || answer == "")
                {
                    break;
                }
                else
                {
                    answer = WhileFalseEnd(answer);
                }
            }
            return answer;
        }

        //  While False End                 -       7th Part
        public string WhileFalseEnd(string answer)
        {
            //answer = "";
            aPrint.PrintExist("Your response is not valid answer!!");
            aPrint.Print("Do you want to continue? Y = Yes, N = No: ");
            answer = Console.ReadLine();
            return answer;
        }
    }
}