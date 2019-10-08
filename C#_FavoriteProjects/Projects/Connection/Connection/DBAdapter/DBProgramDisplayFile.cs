using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Connection
{
    public class DBProgramDisplayFile
    {
        int anId = -1;
        int order = -1;
        double aMin = 0;
        double aMax = 0;
        int anSwitchId = -1;
        string orderBy = "";
        string answerMin = "";
        string answerMax = "";

        //  Student                         -       Student           -    1
        DBStudentRunner aDBStudentRunner = new DBStudentRunner();
        //  Category                        -       Category          -    2
        DBCategoryRunner aDBCategoryRunner = new DBCategoryRunner();
        //  Customer                        -       Customer          -    3
        DBCustomerRunner aDBCustomerRunner = new DBCustomerRunner();
        //  Employee                        -       Employee          -    4
        DBEmployeeRunner aDBEmployeeRunner = new DBEmployeeRunner();
        //  Order Details                   -       Order Details     -    5                    -       BREAK IT DOWN EVEN MORE NOW!
        DBOrderDetailRunner aDBOrderDetailRunner = new DBOrderDetailRunner();
        //  Order                           -       Order             -    6
        DBOrderRunner aDBOrderRunner = new DBOrderRunner();
        //  Product                         -       Product           -    7
        DBProductRunner aDBProductRunner = new DBProductRunner();
        //  Shipper                         -       Shipper           -    8
        DBShipperRunner aDBShipperRunner = new DBShipperRunner();
        //  Supplier                        -       Supplier          -    9
        DBSupplierRunner aDBSupplierRunner = new DBSupplierRunner();
        //  NotValid Outputs
        DBNotValid aDBNotValid = new DBNotValid();

        //  Program Display                 -       3rd Part
        public string ProgramDisplay(string answer)
        {
            bool canConvert_SwitchId = int.TryParse(answer, out anSwitchId);   // Switch - Changing value of anId to value of answer
            if(canConvert_SwitchId == true)
            {
                answer = ProgramConverter(anSwitchId, answer, anId, orderBy, order, answerMin, answerMax, aMin, aMax);
            }
            else
                aDBNotValid.NotValidNumber(answer);
            return answer;
        }

        //  Program Converter               -       4th Part    
        public string ProgramConverter(int anSwitchId, string answer, int anId, string orderBy, int order, string answerMin, string answerMax, double aMin, double aMax)
        {
            if(anSwitchId > 0 && anSwitchId <= 9 && answer != "") //  Test For Range for Student File
            {
                switch(anSwitchId)  //  Switch Begginning
                {
                    case 1:
                        //  answer = Student(answer, anId, orderBy, order);
                        answer = aDBStudentRunner.Student(answer, anId, orderBy, order);
                        break;
                    case 2: // Categories
                        answer = aDBCategoryRunner.Category(answer, anId, orderBy, order);
                        break;
                    case 3: // Customer
                        answer = aDBCustomerRunner.Customer(answer, anId, orderBy, order);
                        break;  //  End of 3
                    case 4: // Employees   
                        answer = aDBEmployeeRunner.Employee(answer, anId, orderBy, order);
                        break;  //  End of 4
                    case 5://2156   Order_Detail
                        answer = aDBOrderDetailRunner.OrderDetails(answer, anId, orderBy, order);
                        break;  //  End of 5
                    case 6://830    //  Order - 6
                        answer = aDBOrderRunner.Order(answer, anId, orderBy, order);
                        break;  //  End of 6
                    case 7: // Products
                        answer = aDBProductRunner.Product(answer, anId, orderBy, order, answerMin, answerMax, aMin, aMax);
                        break;
                    case 8: // Shipper
                        answer = aDBShipperRunner.Shipper(answer, anId, orderBy, order);
                        break;
                    case 9: // Supplier
                        answer = aDBSupplierRunner.Supplier(answer, anId, orderBy, order);
                        break;
                }   //  End of switch
            }   //  Switch Statment Range
            else
                aDBNotValid.NotValidFile(answer);
            return answer;
        }
    }
}