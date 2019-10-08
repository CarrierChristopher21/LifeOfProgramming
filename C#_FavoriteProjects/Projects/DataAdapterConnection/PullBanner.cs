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
            StudentController aStudentController = new StudentController();
            ConsoleView aView = new ConsoleView(aStudentController);
            //  GetInputForm aViewForm = new GetInputForm(aStudentController);
            //  aViewForm.ShowDialog();
            /*  Utility Database Adapter Loader     */
            /*
            UtilityDBAdapterLoader aDBAdapterLoader = UtilityDBAdapterLoader.GetanInstance;
            Console.WriteLine("Got Here");
            Console.ReadLine();
            aDBAdapterLoader.GetProducts();
            Console.ReadLine();
            */
        }
    }
}