using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OurBanner
{
    public partial class StudentFileForm : Form
    {
        int anId = -1;
        string answer = "";

        private StudentController aStudentController = null;

        public StudentFileForm()
        {
            InitializeComponent();
        }

        public StudentFileForm(StudentController aStudentController)
        :this()
        {
             this.aStudentController = aStudentController;
        }
        
        private void studentFileSubmit_Click(object sender, EventArgs e)
        {
            answer = Convert.ToString(studentFileBox.Text);

            bool canConvert_Student = int.TryParse(answer, out anId);   // Student - Changing value of anId to value of answer
            if(canConvert_Student == true)  // Test for if value is a int / number
            {
                answer = StudentConverter(answer, anId);
            }
            else if(answer != "")  //  Output if value is not a int / number
            {
                //this.PrintExist("Your entry is not a valid integer / number!!");
            }
        }

        //  Student Converter               -       Student           -    1
        public string StudentConverter(string answer, int anId)
        {
            if(anId > 0 && anId <= 104) //  Test For Range for Student File
            {
                List<Student> aList = new List<Student>();
                aList = aStudentController.GetStudentsOrder(answer);
                foreach(var aStudent in aList)
                {
                    foreach(string n in Regex.Split(aStudent.ToString(), "\n"))
                    {
                        studentFileOuputBox.Items.Add(n);
                    }
                    
                }
                //this.Print(this.aStudentController.GetStudentsOrder(answer));
            }
            else if(anId == 0)
            {
                
                //answer = StudentOrder(orderBy, order);
            }
            else if(answer != "")  //   Output if File doesn't exist
            {
                
                //this.PrintExist("The file does not exist!!");
            }
            return answer;
        }
        
    }
}
