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
    public class PrintOut
    {
        //  Basic Print Output Call
        public void Print(string aString)
        {
            Console.Write(aString);
        }

        //  Print List Output
        public void PrintList(string aString)
        {
            Console.WriteLine();
            Console.Write(aString);
        }

        //  Print Data Not Available / Wrong Information Entered
        public void PrintExist(string aString)
        {
            Console.WriteLine();
            Console.Write(aString);
            Console.WriteLine("\n");
        }

        //  Student List
        public void Print(List<Student> aList)
        {
            Console.WriteLine();
            foreach(Student aStudent in aList)
            {
                Console.WriteLine(aStudent.ToString());
            }
        }

        //  Category List
        public void Print(List<Category> aList)
        {
            Console.WriteLine();
            foreach(Category aCategory in aList)
            {
                Console.WriteLine(aCategory.ToString());
            }
        }

        //  Customer List
        public void Print(List<Customer> aList)
        {
            Console.WriteLine();
            foreach(Customer aCustomer in aList)
            {
                Console.WriteLine(aCustomer.ToString());
            }
        }

        //  Employee List
        public void Print(List<Employee> aList)
        {
            Console.WriteLine();
            foreach(Employee aEmployee in aList)
            {
                Console.WriteLine(aEmployee.ToString());
            }
        }

        //  Order_Detail List                                -       BREAK IT DOWN EVEN MORE NOW!
        public void Print(List<Order_Detail> aList)
        {
            Console.WriteLine();
            foreach(Order_Detail aOrder_Details in aList)
            {
                Console.WriteLine(aOrder_Details.ToString());
            }
        }

        //  Order List
        public void Print(List<Order> aList)
        {
            Console.WriteLine();
            foreach(Order aOrder in aList)
            {
                Console.WriteLine(aOrder.ToString());
            }
        }

        //  Product List
        public void Print(List<Product> aList)
        {
            Console.WriteLine();
            foreach(Product aProduct in aList)
            {
                Console.WriteLine(aProduct.ToString());
            }
        }

        //  Shipper
        public void Print(List<Shipper> aList)
        {
            Console.WriteLine();
            foreach(Shipper aShipper in aList)
            {
                Console.WriteLine(aShipper.ToString());
            }
        }

        //  Supplier List
        public void Print(List<Supplier> aList)
        {
            Console.WriteLine();
            foreach(Supplier aSupplier in aList)
            {
                Console.WriteLine(aSupplier.ToString());
            }
        }
    }
}