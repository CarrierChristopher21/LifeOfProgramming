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
    public partial class GetInputForm : Form
    {
        int anSwitchId = -1;
        string answer = "";

        private StudentController aStudentController = null;

        public GetInputForm()
        {
            InitializeComponent();
        }

        public GetInputForm(StudentController aStudentController)
        :this()
        {
             this.aStudentController = aStudentController;
        }

        private void getInputSubmission_Click(object sender, EventArgs e)
        {
            answer = Convert.ToString(getInputBox.Text);

            bool canConvert_SwitchId = int.TryParse(answer, out anSwitchId);   // Switch - Changing value of anId to value of answer
            if(canConvert_SwitchId == true)
            {
                answer = ProgramConverter(answer, anSwitchId);
            }
            else if(answer != "")  //  Output if value is not a int / number
            {
                //this.PrintExist("Your entry is not a valid integer / number!!");
            }




            //answer = ProgramDisplay(answer, anSwitchId);


           /*     List<Student> aList = aStudentController.GetStudentsOrder(answer);
            }
            else if(answer.Equals(2))
            {
                List<Category> aList = aStudentController.GetCategoryOrder(answer);
            }
            else if(answer.Equals(3))
            {
                List<Customer> aList = aStudentController.GetCustomerOrder(answer);
            }
            */
        }

        //  Program Converter               -       4th Part    
        public string ProgramConverter(string answer, int anSwitchId)
        {
            if(anSwitchId > 0 && anSwitchId <= 9 && answer != "") //  Test For Range for Student File
            {
                switch(anSwitchId)  //  Switch Begginning
                {
                    case 1:
                        StudentFileForm aForm = new StudentFileForm(aStudentController);
                        this.Hide();
                        aForm.ShowDialog();
                        break;
                    /*case 2: // Categories
                        answer = Category(answer, anId, orderBy, order);
                        break;
                    case 3: // Customer
                        answer = Customer(answer, anId, orderBy, order);
                        break;  //  End of 3
                    case 4: // Employees   
                        answer = Employee(answer, anId, orderBy, order);
                        break;  //  End of 4
                    case 5://2156   Order_Detail
                        answer = OrderDetails(answer, anId, orderBy, order);
                        break;  //  End of 5
                    case 6://830    //  Order - 6
                        answer = Order(answer, anId, orderBy, order);
                        break;  //  End of 6
                    case 7: // Products
                        answer = Product(answer, anId, orderBy, order, answerMin, answerMax, aMin, aMax);
                        break;
                    case 8: // Shipper
                        answer = Shipper(answer, anId, orderBy, order);
                        break;
                    case 9: // Supplier
                        answer = Supplier(answer, anId, orderBy, order);
                        break;*/
                }   //  End of switch
            }   //  Switch Statment Range
            else if(answer != "")  //  Output if value is not a int / number
            {
                //this.PrintExist("Your entry is not a valid integer / number!!");
            }
            return answer;
        }

    }
}
