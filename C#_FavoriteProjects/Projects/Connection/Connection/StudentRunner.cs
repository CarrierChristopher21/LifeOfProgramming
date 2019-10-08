using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class StudentRunner
    {
        StudentController aStudentController = new StudentController();
        NotValid aNotValid = new NotValid();
        PrintOut aPrint = new PrintOut();

        //  Student                         -       Student           -    1
        public string Student(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            aPrint.PrintList("Press a number 1 - 104 to choose a student \nOR Press 0 to recieve All of the Students on File: ");
            answer = Console.ReadLine();
            bool canConvert_Student = int.TryParse(answer, out anId);   // Student - Changing value of anId to value of answer
            if(canConvert_Student == true)  // Test for if value is a int / number
            {
                answer = StudentConverter(answer, anId, orderBy, order);
            }
            else
                aNotValid.NotValidNumber(answer);
            return answer;
        }

        //  Student Converter               -       Student           -    1
        public string StudentConverter(string answer, int anId, string orderBy, int order)
        {
            if(anId > 0 && anId <= 104) //  Test For Range for Student File
            {
                aPrint.Print(this.aStudentController.GetStudentsOrder(answer));
            }
            else if(anId == 0)
            {
                answer = StudentOrder(orderBy, order);
            }
            else
                aNotValid.NotValidFile(answer);
            return answer;
        }

        //  Student Order                   -       Student           -    1 - 0
        public string StudentOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            aPrint.PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if(canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = StudentOrderConverter(orderBy, order);
            }
            else
                aNotValid.NotValidOrderNumber(orderBy);
            return orderBy;
        }

        //  Student Order Converter         -       Student           -    1 - 0 - 1 || 2
        public string StudentOrderConverter(string orderBy, int order)
        {
            if(order == 1)  //  Ascend
            {
                aPrint.Print(this.aStudentController.GetStudentsOrderByAscending(orderBy));
            }
            else if(order == 2) //  Descend
            {
                aPrint.Print(this.aStudentController.GetStudentsOrderByDescending(orderBy));
            }
            else
                aNotValid.NotValidOrderFile(orderBy);
            return orderBy;
        }
    }
}