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
        /*  Information about DBConsoleView Class
            This class contains the beginning of the actual program itself. It contains one variable which is
            answer. The program call two class's in the print menu which are DBStartupInput and DBProgramRunner.
        */
        string answer = "";
        /*  File Links  */
        //  Student Controller
        private DBController aDBController = null;
        //  Program
        DBProgramRunner aDBProgramRunner = new DBProgramRunner();
        //  Startup Input
        DBStartupInput aDBStartupInput = new DBStartupInput();
               
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