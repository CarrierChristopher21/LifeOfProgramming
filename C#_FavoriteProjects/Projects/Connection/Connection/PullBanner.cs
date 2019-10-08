/*
 * Christopher T Carrier
 * 2/13/14
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class PullBanner
    {
        public static void Main(string[] args)
        {
            /*  Information about PullBanner Class  
                This class contains the main method that starts the entire program.
                It calls the controller and then it calls the view and the controller is contained in 
                the () of DBConsoleView
            */
            /*      Utility Database Adapter Loader     */
            DBController aDBController = new DBController();
            DBConsoleView aDBView = new DBConsoleView(aDBController);
        }
    }
}            
        
        /*  Data Reader
        StudentController aStudentController = new StudentController();
        ConsoleView aView = new ConsoleView(aStudentController);
            
        */