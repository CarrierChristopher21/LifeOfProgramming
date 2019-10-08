using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class ContinueRunner
    {
        StudentController aStudentController = new StudentController();
        NotValid aNotValid = new NotValid();
        PrintOut aPrint = new PrintOut();

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