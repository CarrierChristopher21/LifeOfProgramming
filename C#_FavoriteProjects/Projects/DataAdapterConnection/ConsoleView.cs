/*   BREAK DOWN Order Details EVEN MORE NOW!   */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Connection
{
    //  ConsoleView Class
    public class ConsoleView
    {
        string answer = "";
        /*  Variables
        int anId = -1;
        int order = -1;
        double aMin = 0;
        double aMax = 0;
        int anSwitchId = -1;
        string orderBy = "";
        string answerMin = "";
        string answerMax = "";*/

        /*  File Links  */
        //  Student Controller
        private StudentController aStudentController = null;
        //  Program
        ProgramRunner aProgramRunner = new ProgramRunner();
        //  Startup Input
        StartupInput aStartupInput = new StartupInput();
        //  Print Outputs
        PrintOut aPrint = new PrintOut();
        //  NotValid Outputs
        NotValid aNotValid = new NotValid();
               
        //  ConsoleView
        public ConsoleView()
        {

        }

        //  ConsoleView aStudentController
        public ConsoleView(StudentController aStudentController)
            : this()
        {
            this.aStudentController = aStudentController;
            this.PrintMenu();
        }

        /*    Program Method's In subsequent Order! I believe lol!    */
        //  Program                         -       Main Program Itself     -   Runner
        public void PrintMenu()
        {
            //  Unicode Output Encoding
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //  Program Input
            answer = aStartupInput.GetStartUpInput(answer);     //  Collecting input from Console

            //  Program Loop
            answer = aProgramRunner.ProgramLoop(answer);
        }           
    }   //  End of ConsoleView Class
}   //  End of namespace