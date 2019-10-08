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
    public class DBController
    {
        /*  Information about DBController
            This class grabs the data from the DBUtilityAdapterLoader Class. Then it returns the data back to the main program runners
            in which then prints out the data that it received from this process. In other words this is the middle man, a negotiator.
            Inside these methods also contain bufferheights which adjust the height that the buffer of the cmd has access to before 
            portions of data already displayed in the cmd disappear. But since i set a bufferheight all data is shown without any
            problems.       
        */

        //  Individual Student SQL File             -   Students            -   1                   -   DONE
        public List<Student> GetStudentsOrder(string answer)
        {
            List<Student> aSingleStudentList = new List<Student>();
            //Console.BufferHeight = 100;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aSingleStudentList = aFileLoader.GetStudentsOrder(answer);
            return aSingleStudentList;
        }

        //  All Student Files Ascending             -   Students            -   1 - 0 - 1           -   DONE
        public List<Student> GetStudentsOrderByAscending(string orderBy)
        {
            List<Student> aAscendingStudentList = new List<Student>();
            Console.BufferHeight = 650;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aAscendingStudentList = aFileLoader.GetStudentsOrderByAscending(orderBy);
            return aAscendingStudentList;
        }

        //  All Student Files Descending            -   Students            -   1 - 0 - 2           -   DONE
        public List<Student> GetStudentsOrderByDescending(string orderBy)
        {
            List<Student> aDescendingStudentList = new List<Student>();
            Console.BufferHeight = 650;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aDescendingStudentList = aFileLoader.GetStudentsOrderByDescending(orderBy);
            return aDescendingStudentList;
        }

        //  Individual Category SQL File            -   Category            -   2                   -   DONE
        public DataTable GetCategoryOrder(string answer)
        {
            DataTable aCategoryTable = new DataTable();
            Console.BufferHeight = 100;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aCategoryTable = aFileLoader.GetCategoryOrder(answer);
            return aCategoryTable;
        }

        //  All Category Files Ascending            -   Category            -   2 - 0 - 1           -   DONE
        public DataTable GetCategoryOrderByAscending(string orderBy)
        {
            DataTable aAcendingCategoryTable = new DataTable();
            Console.BufferHeight = 75;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;
            
            aAcendingCategoryTable = aFileLoader.GetCategoryOrderByAscending(orderBy);
            return aAcendingCategoryTable;
        }

        //  All Category Files Descending           -   Category            -   2 - 0 - 2           -   DONE
        public DataTable GetCategoryOrderByDescending(string orderBy)
        {
            DataTable aDescendingCategoryTable = new DataTable();
            Console.BufferHeight = 75;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aDescendingCategoryTable = aFileLoader.GetCategoryOrderByDescending(orderBy);
            return aDescendingCategoryTable;
        }

        //  Get CustomerID Name Range               -   Customer            -   3                   -   DONE
        public List<String> GetCustomerIDs()
        {
            List<String> aCustomerList = new List<String>();
            Console.BufferHeight = 100;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aCustomerList = aFileLoader.GetCustomerIDs();
            return aCustomerList;
        }

        //  Individual Customer SQL File            -   Customer            -   3                   -   DONE
        public DataTable GetCustomerOrder(string answer)
        {
            DataTable aCustomerTable = new DataTable();
            Console.BufferHeight = 100;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aCustomerTable = aFileLoader.GetCustomerOrder(answer);
            return aCustomerTable;
        }

        //  All Customer Files Ascending            -   Customer            -   3 - 0 - 1           -   DONE
        public DataTable GetCustomerOrderByAscending(string orderBy)
        {
            DataTable aAscendingCustomerTable = new DataTable();
            Console.BufferHeight = 1250;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aAscendingCustomerTable = aFileLoader.GetCustomerOrderByAscending(orderBy);
            return aAscendingCustomerTable;
        }

        //  All Customer Files Descending           -   Customer            -   3 - 0 - 2           -   DONE
        public DataTable GetCustomerOrderByDescending(string orderBy)
        {
            DataTable aDescendingCustomerTable = new DataTable();
            Console.BufferHeight = 1250;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aDescendingCustomerTable = aFileLoader.GetCustomerOrderByDescending(orderBy);
            return aDescendingCustomerTable;
        }

        //  Individual Employee SQL File            -   Employee            -   4                   -   DONE
        public DataTable GetEmployeeOrder(string answer)
        {
            DataTable aSingleEmployeeTable = new DataTable();
            Console.BufferHeight = 100;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aSingleEmployeeTable = aFileLoader.GetEmployeeOrder(answer);
            return aSingleEmployeeTable;
        }

        //  All Employee Files Ascending            -   Employee            -   4 - 0 - 1           -   DONE
        public DataTable GetEmployeeOrderByAscending(string orderBy)
        {
            DataTable aAscendingEmployeeTable = new DataTable();
            Console.BufferHeight = 200;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aAscendingEmployeeTable = aFileLoader.GetEmployeeOrderByAscending(orderBy);
            return aAscendingEmployeeTable;
        }

        //  All Employee Files Descending           -   Employee            -   4 - 0 - 2           -   DONE
        public DataTable GetEmployeeOrderByDescending(string orderBy)
        {
            DataTable aDescendingEmployeeTable = new DataTable();
            Console.BufferHeight = 200;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aDescendingEmployeeTable = aFileLoader.GetEmployeeOrderByDescending(orderBy);
            return aDescendingEmployeeTable;
        }

        //  Individual Order Detail SQL File        -   Order Detail        -   5                   -   DONE    -   BREAK IT DOWN EVEN MORE NOW!
        public DataTable GetOrderDetailOrder(string answer)
        {
            DataTable aSingleOrderDetailsTable = new DataTable();
            Console.BufferHeight = 100;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aSingleOrderDetailsTable = aFileLoader.GetOrderDetailOrder(answer);
            return aSingleOrderDetailsTable;
        }

        //  All Order_Detail Files Ascending        -   Order_Detail        -   5 - 0 - 2           -   DONE
        public DataTable GetOrderDetailsOrderByAscending(string orderBy)
        {
            DataTable aAscendingOrderDetailsTable = new DataTable();
            Console.BufferHeight = 28500;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aAscendingOrderDetailsTable = aFileLoader.GetOrderDetailsOrderByAscending(orderBy);
            return aAscendingOrderDetailsTable;
        }

        //  All Order_Detail Files Descending       -   Order_Detail        -   5 - 0 - 2           -   DONE
        public DataTable GetOrderDetailsOrderByDescending(string orderBy)
        {
            DataTable aDescendingOrderDetailsTable = new DataTable();
            Console.BufferHeight = 28500;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aDescendingOrderDetailsTable = aFileLoader.GetOrderDetailsOrderByDescending(orderBy);
            return aDescendingOrderDetailsTable;
        }

        //  Individual Order SQL File               -   Order               -   6                   -   DONE
        public DataTable GetOrderOrder(string answer)
        {
            DataTable aSinlgeOrderTable = new DataTable();
            Console.BufferHeight = 100;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aSinlgeOrderTable = aFileLoader.GetOrderOrder(answer);
            return aSinlgeOrderTable;
        }

        //  All Order Files Descending              -   Order               -   6 - 0 - 1           -   DONE
        public DataTable GetOrderOrderByAscending(string orderBy)
        {
            DataTable aAscendingOrderTable = new DataTable();
            Console.BufferHeight = 16500;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aAscendingOrderTable = aFileLoader.GetOrderOrderByAscending(orderBy);
            return aAscendingOrderTable;
        }

        //  All Order Files Descending              -   Order               -   6 - 0 - 2           -   DONE
        public DataTable GetOrderOrderByDescending(string orderBy)
        {
            DataTable aDescendingOrderTable = new DataTable();
            Console.BufferHeight = 16500;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aDescendingOrderTable = aFileLoader.GetOrderOrderByDescending(orderBy);
            return aDescendingOrderTable;
        }

        //  Individual Product SQL File             -   Product             -   7                   -   DONE
        public DataTable GetProductOrder(string answer)
        {
            DataTable aSingleProductTable = new DataTable();
            Console.BufferHeight = 100;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aSingleProductTable = aFileLoader.GetProductOrder(answer);
            return aSingleProductTable;
        }

        //  All Product Files Ascending             -   Product             -   7 - 1 - 0 - 1       -   DONE
        public DataTable GetProductOrderByAscending(string orderBy)
        {
            DataTable aAscendingProductTable = new DataTable();
            Console.BufferHeight = 1000;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aAscendingProductTable = aFileLoader.GetProductOrderByAscending(orderBy);
            return aAscendingProductTable;
        }

        //  All Product Files Descending            -   Product             -   7 - 1 - 0 - 2       -   DONE
        public DataTable GetProductOrderByDescending(string orderBy)
        {
            DataTable aDescendingProductTable = new DataTable();
            Console.BufferHeight = 1000;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aDescendingProductTable = aFileLoader.GetProductOrderByDescending(orderBy);
            return aDescendingProductTable;
        }

        //  Individual Product Files                -   Product Category    -   7 - 2               -   DONE
        public DataTable GetProductCategory(string answer)
        {
            DataTable aProductCategoryTable = new DataTable();
            Console.BufferHeight = 200;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aProductCategoryTable = aFileLoader.GetProductCategory(answer);
            return aProductCategoryTable;
        }

        //  Individual Product Files                -   Product Range       -   7 - 3               -   DONE
        public DataTable GetProductRange(string answerMin, string answerMax)
        {
            DataTable aProductRangeTable = new DataTable();
            Console.BufferHeight = 1000;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aProductRangeTable = aFileLoader.GetProductRange(answerMin, answerMax);
            return aProductRangeTable;
        }

        //  Individual Shipper SQL File             -   Shipper             -   8                   -   DONE
        public DataTable GetShipperOrder(string answer)
        {
            DataTable aSingleShipperTable = new DataTable();
            Console.BufferHeight = 100;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aSingleShipperTable = aFileLoader.GetShipperOrder(answer);
            return aSingleShipperTable;
        }

        //  All Shipper Files Ascending             -   Shipper             -   8 - 0 - 1           -   DONE
        public DataTable GetShipperOrderByAscending(string orderBy)
        {
            DataTable aAscendingShipperTable = new DataTable();
            Console.BufferHeight = 100;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aAscendingShipperTable = aFileLoader.GetShipperOrderByAscending(orderBy);
            return aAscendingShipperTable;
        }

        //  All Shipper Files Descending            -   Shipper             -   8 - 0 - 2           -   DONE
        public DataTable GetShipperOrderByDescending(string orderBy)
        {
            DataTable aDescendingShipperTable = new DataTable();
            Console.BufferHeight = 100;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aDescendingShipperTable = aFileLoader.GetShipperOrderByDescending(orderBy);
            return aDescendingShipperTable;
        }

        //  Individual Supplier SQL File            -   Supplier            -   9                   -   DONE
        public DataTable GetSupplierOrder(string answer)
        {
            DataTable aSingleSupplierTable = new DataTable();
            Console.BufferHeight = 100;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aSingleSupplierTable = aFileLoader.GetSupplierOrder(answer);
            return aSingleSupplierTable;
        }             

        //  All Supplier Files Ascending            -   Supplier            -   9 - 0 - 1           -   DONE
        public DataTable GetSupplierOrderByAscending(string orderBy)
        {
            DataTable aAscendingSupplierTable = new DataTable();
            Console.BufferHeight = 500;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aAscendingSupplierTable = aFileLoader.GetSupplierOrderByAscending(orderBy);
            return aAscendingSupplierTable;
        }

        //  All Supplier Files Descending           -   Supplier            -   9 - 0 - 2           -   DONE
        public DataTable GetSupplierOrderByDescending(string orderBy)
        {
            DataTable aDescendingSupplierTable = new DataTable();
            Console.BufferHeight = 500;
            DBUtilityAdapterLoader aFileLoader = DBUtilityAdapterLoader.GetanInstance;

            aDescendingSupplierTable = aFileLoader.GetSupplierOrderByDescending(orderBy);
            return aDescendingSupplierTable;
        }
    }
}

        //  Converter Order Test            -   In Progress, Not In Use
        /*public List<Object> GetStudentsOrderByAscendingTest(string orderBy)
        {
            List<Object> aObjectList = new List<Object>();
            Console.BufferHeight = 650;
            UtilityXMLFileLoader aFileLoader = UtilityXMLFileLoader.GetanInstance;

            aObjectList = aFileLoader.GetStudentsOrderByAscendingTest(orderBy);
            return aObjectList;
        }*/