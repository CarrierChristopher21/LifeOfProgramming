using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Connection
{
    public class ProgramRunner
    {
        //  Program Display
        ProgramDisplayFile aProgramDisplayFile = new ProgramDisplayFile();
        //  Continue
        ContinueRunner aContinueRunner = new ContinueRunner();
        //  Start Up Input
        StartupInput aStartupInput = new StartupInput();

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
                else if(answer == "n" || answer == "N" || answer == "")
                {
                    break;
                }
            }   //  End of While statement
            return answer;
        }
    }
}