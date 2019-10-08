using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Connection
{
    public class DBProgramRunner
    {
        /*  Information about DBProgramRunner
            This class runs the main loop portion of the entire program. It calls other methods that are 
            located in other class's. The first one starts the entire program which leads to a class that
            responds to the response that you gave back at the StartupInput class. Then the next class called is
            one that asks whether you want to continue the program. The next portion calls a class to see if you gave a valid 
            response. If a valid response you go one of two ways either you choose "Yes" which would start you back at the StartupInput
            class again or you did one of two things and they are that you choose "No" or didnt type anything and 
            hit enter and both of those two choices ends the loop which ends the program.
        */
        //  Program Display
        DBProgramDisplayFile aProgramDisplayFile = new DBProgramDisplayFile();
        //  Continue
        DBContinueRunner aContinueRunner = new DBContinueRunner();
        //  Start Up Input
        DBStartupInput aStartupInput = new DBStartupInput();

        //  Program Loop                    -       2nd Part
        public string ProgramLoop(string answer)
        {
            while(answer != "") // Beginning of loop
            {
                //  Program
                answer = aProgramDisplayFile.ProgramDisplay(answer);

                //  Program Runner for whether to Continue or Not!  
                if(answer != "")
                {
                    answer = aContinueRunner.ContinueQuestion(answer);
                }
                //  Test if the proper response was given
                if(answer != "")
                {
                    answer = aContinueRunner.WhileFalse(answer);
                }
                //  Continuation Question Response
                if(answer == "Y" || answer == "y")
                {
                    Console.Clear();
                    answer = aStartupInput.GetStartUpInput(answer);     //  Collecting input from Console
                }   
                else if(answer == "n" || answer == "N" || answer == "") //  End of program if any of these are answered
                {                                                       //  During the Continuation Question
                    break;
                }
            }   //  End of While statement
            return answer;
        }
    }
}