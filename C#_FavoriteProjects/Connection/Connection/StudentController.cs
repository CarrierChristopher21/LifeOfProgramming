using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class StudentController
    {
        //  Converter Order Test            -   In Progress, Not In Use
        public List<Object> GetStudentsOrderByAscendingTest(string orderBy)
        {
            List<Object> aObjectList = new List<Object>();
            Console.BufferHeight = 650;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aObjectList = aFileLoader.GetStudentsOrderByAscendingTest(orderBy);
            return aObjectList;
        }

        //  All Student Files Ascending             -   Students            -   1 - 0 - 1           -   DONE
        public List<Student> GetStudentsOrderByAscending(string orderBy)
        {
            List<Student> aStudentList = new List<Student>();
            Console.BufferHeight = 650;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aStudentList = aFileLoader.GetStudentsOrderByAscending(orderBy);
            return aStudentList;
        }

        //  All Student Files Descending            -   Students            -   1 - 0 - 2           -   DONE
        public List<Student> GetStudentsOrderByDescending(string orderBy)
        {
            List<Student> aStudentList = new List<Student>();
            Console.BufferHeight = 650;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aStudentList = aFileLoader.GetStudentsOrderByDescending(orderBy);
            return aStudentList;
        }

        //  Individual Category SQL File            -   Category            -   2                   -   DONE
        public List<Category> GetCategoryOrder(string answer)
        {
            List<Category> aCategoryList = new List<Category>();
            Console.BufferHeight = 100;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aCategoryList = aFileLoader.GetCategoryOrder(answer);
            return aCategoryList;
        }

        //  All Category Files Ascending            -   Category            -   2 - 0 - 1           -   DONE
        public List<Category> GetCategoryOrderByAscending(string orderBy)
        {
            List<Category> aCategoryList = new List<Category>();
            Console.BufferHeight = 75;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aCategoryList = aFileLoader.GetCategoryOrderByAscending(orderBy);
            return aCategoryList;
        }

        //  All Category Files Descending           -   Category            -   2 - 0 - 2           -   DONE
        public List<Category> GetCategoryOrderByDescending(string orderBy)
        {
            List<Category> aCategoryList = new List<Category>();
            Console.BufferHeight = 75;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aCategoryList = aFileLoader.GetCategoryOrderByDescending(orderBy);
            return aCategoryList;
        }

        //  Get CustomerID Name Range               -   Customer            -   3                   -   DONE
        public List<String> GetCustomerIDs()
        {
            List<String> aCustomerList = new List<String>();
            Console.BufferHeight = 100;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aCustomerList = aFileLoader.GetCustomerIDs();
            return aCustomerList;
        }

        //  All Customer Files Ascending            -   Customer            -   3 - 0 - 1           -   DONE
        public List<Customer> GetCustomerOrderByAscending(string orderBy)
        {
            List<Customer> aCustomerList = new List<Customer>();
            Console.BufferHeight = 1250;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aCustomerList = aFileLoader.GetCustomerOrderByAscending(orderBy);
            return aCustomerList;
        }

        //  All Customer Files Descending           -   Customer            -   3 - 0 - 2           -   DONE
        public List<Customer> GetCustomerOrderByDescending(string orderBy)
        {
            List<Customer> aCustomerList = new List<Customer>();
            Console.BufferHeight = 1250;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aCustomerList = aFileLoader.GetCustomerOrderByDescending(orderBy);
            return aCustomerList;
        }

        //  All Employee Files Ascending            -   Employee            -   4 - 0 - 1           -   DONE
        public List<Employee> GetEmployeeOrderByAscending(string orderBy)
        {
            List<Employee> aEmployeeList = new List<Employee>();
            Console.BufferHeight = 300;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aEmployeeList = aFileLoader.GetEmployeeOrderByAscending(orderBy);
            return aEmployeeList;
        }

        //  All Employee Files Descending           -   Employee            -   4 - 0 - 2           -   DONE
        public List<Employee> GetEmployeeOrderByDescending(string orderBy)
        {
            List<Employee> aEmployeeList = new List<Employee>();
            Console.BufferHeight = 750;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aEmployeeList = aFileLoader.GetEmployeeOrderByDescending(orderBy);
            return aEmployeeList;
        }

        //  All Order_Detail Files Ascending        -   Order_Detail        -   5 - 0 - 2           -   DONE
        public List<Order_Detail> GetOrderDetailsOrderByAscending(string orderBy)
        {
            List<Order_Detail> aOrderDetailList = new List<Order_Detail>();
            Console.BufferHeight = 28500;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aOrderDetailList = aFileLoader.GetOrderDetailsOrderByAscending(orderBy);
            return aOrderDetailList;
        }

        //  All Order_Detail Files Descending       -   Order_Detail        -   5 - 0 - 2           -   DONE
        public List<Order_Detail> GetOrderDetailsOrderByDescending(string orderBy)
        {
            List<Order_Detail> aOrderDetailList = new List<Order_Detail>();
            Console.BufferHeight = 28500;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aOrderDetailList = aFileLoader.GetOrderDetailsOrderByDescending(orderBy);
            return aOrderDetailList;
        }

        //  All Order Files Descending              -   Order               -   6 - 0 - 1           -   DONE
        public List<Order> GetOrderOrderByAscending(string orderBy)
        {
            List<Order> aOrderList = new List<Order>();
            Console.BufferHeight = 14300;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aOrderList = aFileLoader.GetOrderOrderByAscending(orderBy);
            return aOrderList;
        }

        //  All Order Files Descending              -   Order               -   6 - 0 - 2           -   DONE
        public List<Order> GetOrderOrderByDescending(string orderBy)
        {
            List<Order> aOrderList = new List<Order>();
            Console.BufferHeight = 14300;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aOrderList = aFileLoader.GetOrderOrderByDescending(orderBy);
            return aOrderList;
        }

        //  Individual Product SQL File             -   Product             -   7                   -   DONE
        public List<Product> GetProductOrder(string answer)
        {
            List<Product> aProductList = new List<Product>();
            Console.BufferHeight = 100;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aProductList = aFileLoader.GetProductOrder(answer);
            return aProductList;
        }

        //  All Product Files Ascending             -   Product             -   7 - 1 - 0 - 1       -   DONE
        public List<Product> GetProductOrderByAscending(string orderBy)
        {
            List<Product> aProductList = new List<Product>();
            Console.BufferHeight = 1000;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aProductList = aFileLoader.GetProductOrderByAscending(orderBy);
            return aProductList;
        }

        //  All Product Files Descending            -   Product             -   7 - 1 - 0 - 2       -   DONE
        public List<Product> GetProductOrderByDescending(string orderBy)
        {
            List<Product> aProductList = new List<Product>();
            Console.BufferHeight = 1000;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aProductList = aFileLoader.GetProductOrderByDescending(orderBy);
            return aProductList;
        }

        //  Individual Product Files                -   Product Category    -   7 - 2               -   DONE
        public List<Product> GetProductCategory(string answer)
        {
            List<Product> aProductList = new List<Product>();
            Console.BufferHeight = 200;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aProductList = aFileLoader.GetProductCategory(answer);
            return aProductList;
        }

        //  Individual Product Files                -   Product Range       -   7 - 3               -   DONE
        public List<Product> GetProductRange(string answerMin, string answerMax)
        {
            List<Product> aProductList = new List<Product>();
            Console.BufferHeight = 950;
            //Console.BufferHeight = 
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aProductList = aFileLoader.GetProductRange(answerMin, answerMax);
            return aProductList;
        }

        //  All Shipper Files Ascending             -   Shipper             -   8 - 0 - 1           -   DONE
        public List<Shipper> GetShipperOrderByAscending(string orderBy)
        {
            List<Shipper> aShipperList = new List<Shipper>();
            Console.BufferHeight = 100;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aShipperList = aFileLoader.GetShipperOrderByAscending(orderBy);
            return aShipperList;
        }

        //  All Shipper Files Descending            -   Shipper             -   8 - 0 - 2           -   DONE
        public List<Shipper> GetShipperOrderByDescending(string orderBy)
        {
            List<Shipper> aShipperList = new List<Shipper>();
            Console.BufferHeight = 100;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aShipperList = aFileLoader.GetShipperOrderByDescending(orderBy);
            return aShipperList;
        }

        //  All Supplier Files Ascending            -   Supplier            -   9 - 0 - 1           -   DONE
        public List<Supplier> GetSupplierOrderByAscending(string orderBy)
        {
            List<Supplier> aSupplierList = new List<Supplier>();
            Console.BufferHeight = 500;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aSupplierList = aFileLoader.GetSupplierOrderByAscending(orderBy);
            return aSupplierList;
        }

        //  All Supplier Files Descending           -   Supplier            -   9 - 0 - 2           -   DONE
        public List<Supplier> GetSupplierOrderByDescending(string orderBy)
        {
            List<Supplier> aSupplierList = new List<Supplier>();
            Console.BufferHeight = 500;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aSupplierList = aFileLoader.GetSupplierOrderByDescending(orderBy);
            return aSupplierList;
        }

        //  Individual Student SQL File             -   Students            -   1                   -   DONE
        public List<Student> GetStudentsOrder(string answer)
        {
            List<Student> aStudentList = new List<Student>();
            //Console.BufferHeight = 100;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aStudentList = aFileLoader.GetStudentsOrder(answer);
            return aStudentList;
        }



        //  Individual Customer SQL File            -   Customer            -   3                   -   DONE
        public List<Customer> GetCustomerOrder(string answer)
        {
            List<Customer> aCustomerList = new List<Customer>();
            Console.BufferHeight = 100;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aCustomerList = aFileLoader.GetCustomerOrder(answer);
            return aCustomerList;
        }

        //  Individual Employee SQL File            -   Employee            -   4                   -   DONE
        public List<Employee> GetEmployeeOrder(string answer)
        {
            List<Employee> aEmployeeList = new List<Employee>();
            Console.BufferHeight = 100;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aEmployeeList = aFileLoader.GetEmployeeOrder(answer);
            return aEmployeeList;
        }

        //  Individual Order Detail SQL File        -   Order Detail        -   5                   -   DONE    -   BREAK IT DOWN EVEN MORE NOW!
        public List<Order_Detail> GetOrderDetailOrder(string answer)
        {
            List<Order_Detail> aOrderDetailList = new List<Order_Detail>();
            Console.BufferHeight = 100;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aOrderDetailList = aFileLoader.GetOrderDetailOrder(answer);
            return aOrderDetailList;
        }

        //  Individual Order SQL File               -   Order               -   6                   -   DONE
        public List<Order> GetOrderOrder(string answer)
        {
            List<Order> aOrderList = new List<Order>();
            Console.BufferHeight = 100;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aOrderList = aFileLoader.GetOrderOrder(answer);
            return aOrderList;
        }



        //  Individual Shipper SQL File             -   Shipper             -   8                   -   DONE
        public List<Shipper> GetShipperOrder(string answer)
        {
            List<Shipper> aShipperList = new List<Shipper>();
            Console.BufferHeight = 100;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aShipperList = aFileLoader.GetShipperOrder(answer);
            return aShipperList;
        }

        //  Individual Supplier SQL File            -   Supplier            -   9                   -   DONE
        public List<Supplier> GetSupplierOrder(string answer)
        {
            List<Supplier> aSupplierList = new List<Supplier>();
            Console.BufferHeight = 100;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aSupplierList = aFileLoader.GetSupplierOrder(answer);
            return aSupplierList;
        }             
    }
}