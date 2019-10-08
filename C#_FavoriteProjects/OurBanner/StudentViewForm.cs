using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OurBanner
{
    public partial class StudentConsoleViewForm : Form
    {
        int anId = -1;
        int order = -1;
        int anSwitchId = -1;
        string answer = "";
        double aMin = 0;
        double aMax = 0;
        string orderBy = "";
        string answerMin = "";
        string answerMax = "";
        private StudentController aStudentController = null;

        public StudentConsoleViewForm()
        {
            InitializeComponent();
        }
        public StudentConsoleViewForm(StudentController aStudentController)
        : this()
        {
            this.aStudentController = aStudentController;
        }

        


    }
}
