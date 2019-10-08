using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Connection
{
    public class ProgramDisplayFile
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
        StudentRunner aStudentRunner = new StudentRunner();
        //  Category                        -       Category          -    2
        CategoryRunner aCategoryRunner = new CategoryRunner();
        //  Customer                        -       Customer          -    3
        CustomerRunner aCustomerRunner = new CustomerRunner();
        //  Employee                        -       Employee          -    4
        EmployeeRunner aEmployeeRunner = new EmployeeRunner();
        //  Order Details                   -       Order Details     -    5                    -       BREAK IT DOWN EVEN MORE NOW!
        OrderDetailRunner aOrderDetailRunner = new OrderDetailRunner();
        //  Order                           -       Order             -    6
        OrderRunner aOrderRunner = new OrderRunner();
        //  Product                         -       Product           -    7
        ProductRunner aProductRunner = new ProductRunner();
        //  Shipper                         -       Shipper           -    8
        ShipperRunner aShipperRunner = new ShipperRunner();
        //  Supplier                        -       Supplier          -    9
        SupplierRunner aSupplierRunner = new SupplierRunner();
        //  NotValid Outputs
        NotValid aNotValid = new NotValid();

        //  Program Display                 -       3rd Part
        public string ProgramDisplay(string answer)
        {
            bool canConvert_SwitchId = int.TryParse(answer, out anSwitchId);   // Switch - Changing value of anId to value of answer
            if(canConvert_SwitchId == true)
            {
                answer = ProgramConverter(anSwitchId, answer, anId, orderBy, order, answerMin, answerMax, aMin, aMax);
            }
            else
                aNotValid.NotValidNumber(answer);
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
                        answer = aStudentRunner.Student(answer, anId, orderBy, order);
                        break;
                    case 2: // Categories
                        answer = aCategoryRunner.Category(answer, anId, orderBy, order);
                        break;
                    case 3: // Customer
                        answer = aCustomerRunner.Customer(answer, anId, orderBy, order);
                        break;  //  End of 3
                    case 4: // Employees   
                        answer = aEmployeeRunner.Employee(answer, anId, orderBy, order);
                        break;  //  End of 4
                    case 5://2156   Order_Detail
                        answer = aOrderDetailRunner.OrderDetails(answer, anId, orderBy, order);
                        break;  //  End of 5
                    case 6://830    //  Order - 6
                        answer = aOrderRunner.Order(answer, anId, orderBy, order);
                        break;  //  End of 6
                    case 7: // Products
                        answer = aProductRunner.Product(answer, anId, orderBy, order, answerMin, answerMax, aMin, aMax);
                        break;
                    case 8: // Shipper
                        answer = aShipperRunner.Shipper(answer, anId, orderBy, order);
                        break;
                    case 9: // Supplier
                        answer = aSupplierRunner.Supplier(answer, anId, orderBy, order);
                        break;
                }   //  End of switch
            }   //  Switch Statment Range
            else
                aNotValid.NotValidFile(answer);
            return answer;
        }
    }
}