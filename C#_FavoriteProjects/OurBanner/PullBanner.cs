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

namespace OurBanner
{
    public class PullBanner
    {
        public static void Main(string[] args)
        {
            StudentController aStudentController = new StudentController();
            ConsoleView aView = new ConsoleView(aStudentController);
            //GetInputForm aViewForm = new GetInputForm(aStudentController);
            //aViewForm.ShowDialog();

        }
    }
}
