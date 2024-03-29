﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class DBSupplierRunner
    {
        /*  Information about DBSupplierRunner Class
            Now it asks for you to pick a number between two numbers which would give you a file of that specific number 
            over a list of file data. You could also press 0 and follow that route which would give you an entire list of the data 
            instead of a single file's worth of data. If you go down the list of files then you also get the option to ascend or 
            descend the list from 1-29 or 29-1. 
        */
        DBController aDBController = new DBController();
        DBNotValid aNotValid = new DBNotValid();
        DBPrintOut aDBPrinter = new DBPrintOut();

        //  Supplier File                   -       Supplier          -   9
        public string Supplier(string answer, int anId, string orderBy, int order)
        {
            answer = "";
            aDBPrinter.PrintList("Press a number 1 - 29 to choose a supplier \nOR Press 0 to recieve All of the Supplier's on " +
            "File: ");
            answer = Console.ReadLine();
            bool canConvert_SupplierId = int.TryParse(answer, out anId);   // Changing value of anId to value of answer
            if(canConvert_SupplierId == true)  // Test for if value is a int / number
            {
                answer = SupplierConverter(anId, answer, orderBy, order);
            }
            else
                aNotValid.NotValidNumber(answer);
            return answer;
        }

        //  Supplier Converter              -       Supplier          -   9
        public string SupplierConverter(int anId, string answer, string orderBy, int order)
        {
            if(anId > 0 && anId <= 29) //  Test For Range for Student File
            {
                aDBPrinter.PrintSupplier(this.aDBController.GetSupplierOrder(answer));
            }
            else if(anId == 0)
            {
                answer = SupplierOrder(orderBy, order);
            }
            else
                aNotValid.NotValidFile(answer);
            return answer;
        }

        //  Supplier Order                  -       Supplier          -   9 - 0
        public string SupplierOrder(string orderBy, int order)
        {
            orderBy = "";
            order = 0;
            aDBPrinter.PrintList("Press 1 to get order to go down \nand 2 to get the order to go up: ");
            orderBy = Console.ReadLine();
            bool canConvert_OrderBy = int.TryParse(orderBy, out order); // Ordering / Sorting - Changing orderBy
            if(canConvert_OrderBy == true)  // Test for if value is a int / number
            {
                orderBy = SupplierOrderConverter(orderBy, order);
            }
            else
                aNotValid.NotValidOrderNumber(orderBy);
            return orderBy;
        }

        //  Supplier Converter Order        -       Supplier          -   9 - 0 - 1 || 2
        public string SupplierOrderConverter(string orderBy, int order)
        {
            if(order == 1)  //  Ascend
            {
                aDBPrinter.PrintSupplier(this.aDBController.GetSupplierOrderByAscending(orderBy));
            }
            else if(order == 2) //  Descend
            {
                aDBPrinter.PrintSupplier(this.aDBController.GetSupplierOrderByDescending(orderBy));
            }
            else
                aNotValid.NotValidOrderFile(orderBy);
            return orderBy;
        }
    }
}