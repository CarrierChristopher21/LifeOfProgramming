/*   BREAK DOWN Order Details EVEN MORE NOW!   */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data;
using System.Data.OleDb;

namespace Connection
{
    //  ConsoleView Class
    public class DBConsoleView
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
        private DBController aDBController = null;
        //  Program
        DBProgramRunner aDBProgramRunner = new DBProgramRunner();
        //  Startup Input
        DBStartupInput aDBStartupInput = new DBStartupInput();
        //  Print Outputs
        DBPrintOut aPrint = new DBPrintOut();
        //  NotValid Outputs
        DBNotValid aNotValid = new DBNotValid();
               
        //  ConsoleView
        public DBConsoleView()
        {

        }

        //  ConsoleView aDBController
        public DBConsoleView(DBController aDBController)
            : this()
        {
            this.aDBController = aDBController;
            this.PrintMenu();
        }

        /*    Program Method's In subsequent Order! I believe lol!    */
        //  Program                         -       Main Program Itself     -   Runner
        public void PrintMenu()
        {
            //  Unicode Output Encoding
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //  Program Input
            answer = aDBStartupInput.GetStartUpInput(answer);     //  Collecting input from Console

            //  Program Loop
            answer = aDBProgramRunner.ProgramLoop(answer);
        }           
    }   //  End of ConsoleView Class
}   //  End of namespace