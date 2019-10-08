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
    public class Test
    {
        /*public static void Main(string[] args)
        {
            //  Create a List
            List<Product> aProductList = new List<Product>();

            //  Create Connection Object
            OleDbConnection aConnection = new OleDbConnection();

            // Set the connection string
            aConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\Chris\Desktop\Visual Studio Programming\Visual Studio 2013\Projects\Connection\Connection\DataNorthwind.accdb";

            //  Open Connection
            aConnection.Open();

            //  Test the Connection
            if(aConnection.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("The database Connection is Now Officially Open For Business!!");
                Console.ReadLine();
                Console.WriteLine("April Fools!!!\n");
            }
            else
            {
                Console.WriteLine("Houston wehave a problem");
            }

            //  Create a Command Object
            OleDbCommand aCommand = aConnection.CreateCommand();
            
            aCommand.CommandText = "PriceRange";
            aCommand.CommandType = CommandType.StoredProcedure;
            aCommand.Parameters.Add("min",OleDbType.Double).Value = 96;
            aCommand.Parameters.Add("max",OleDbType.Double).Value = 100;

            //  Set the SQL Statement
            aCommand.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, " + 
            "UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products;";

            //  Data Adapter
            OleDbDataAdapter anAdapter = new OleDbDataAdapter(aCommand);
            DataSet aDataSet = new DataSet();
            anAdapter.Fill(aDataSet, "MyProducts");

            foreach(DataColumn aColumn in aDataSet.Tables["MyProducts"].Columns)
            {
                Console.Write(aColumn.ColumnName.ToString() + " ");
            }

            foreach(DataRow aRow in aDataSet.Tables["MyProducts"].Rows)
            {
                foreach(DataColumn aColumn in aDataSet.Tables["MyProducts"].Columns)
                {
                    Console.Write(aRow[aColumn].ToString() + " ");
                }
            }
            Console.ReadLine();

            //  Close Connection
            aConnection.Close();


           
            
            //  Execute Connection Reader
            /*OleDbDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                Console.BufferHeight = 950;
                int aProductId = (int) aReader["ProductID"];
                string aProductName = (string) aReader["ProductName"];
                int aSupplierId = (int) aReader["SupplierID"];
                int aCategoryId = (int) aReader["CategoryID"];
                string aQuantityUnitPerUnit = (string) aReader["QuantityPerUnit"];
                double aUnitPrice = (double)(decimal) aReader["UnitPrice"];
                int aUnitsInStock = (short) aReader["UnitsInStock"];
                int aUnitOnOrder = (short) aReader["UnitsOnOrder"];
                int aReorderLevel = (short) aReader["ReorderLevel"];
                bool isDiscontinued = (bool) aReader["DisContinued"];
                Product aProduct = new Product(aProductId, aProductName, aSupplierId, aCategoryId, aQuantityUnitPerUnit, aUnitPrice, 
                    aUnitsInStock, aUnitsInStock, aReorderLevel, isDiscontinued);
                    
                    aProductList.Add(aProduct);
            }

            //---------------------------------------------------------------------------------------------
            //                                      Linq SQL Query 
            Console.WriteLine("                         Now entering Linq Query Style! \n");
            //  Product Range    -   1
            Console.Write("Now entering Part 1!: ");
            Console.ReadLine();
            Console.WriteLine();
            var productsRange = from p in aProductList
                                where (p.UnitPrice >= 10.00 && p.UnitPrice <= 25.00)
                                orderby p.UnitPrice
                                select p;
            foreach(var p in productsRange)
            {
                Console.WriteLine(p.ToString());
            }
                        
            //  Dairy + Beverage    -   2
            Console.Write("Now entering part 2!: ");
            Console.ReadLine();
            Console.WriteLine();
            var dairyProducts = from dbp in aProductList
                                where ((dbp.CategoryId == 1 || dbp.CategoryId == 4) && (dbp.UnitPrice >= 30.00 && dbp.UnitPrice <= 70.00))
                                orderby dbp.UnitPrice
                                select dbp;
            foreach(var dbp in dairyProducts)
            {
                Console.WriteLine(dbp.ToString());
            }           

            //  Beverage Reverse   -   3
            Console.Write("Now entering Part 3!: ");
            Console.ReadLine();
            Console.WriteLine();
            var beverageProducts = from bp in aProductList
                                where (bp.CategoryId == 1)
                                orderby bp.ProductName descending, bp.UnitPrice descending
                                select bp;
            foreach(var bp in beverageProducts)
            {
                Console.WriteLine(bp.ToString());
            }
            Console.Write("Now entering Part 4!: ");
            Console.ReadLine();
            Console.WriteLine();

            //---------------------------------------------------------------------------------------
            //                                  Lambda Linq Style
            Console.WriteLine("                         Now entering Lambda Linq Style! \n");
            Console.Write("Now Entering Part 1!: ");
            Console.ReadLine();
            Console.WriteLine();

            //---------------------------------------------------------------------------------------
            //var dairyProducts = aProductList.Where(dp => dp.CategoryId == 4);

            //var dairyProducts = aProductList.Where(dp => dp.UnitPrice >= 70 && dp.UnitPrice <= 100);

            //var maximumPrice = aProductList.Max(dp => dp.UnitPrice);
            //var minimumPrice =aProductList.Min(dp => dp.UnitPrice);
            

            
            //Console.WriteLine("The maximum Price is " + maximumPrice);
            //Console.WriteLine("The minimum Price is " + minimumPrice);

            //---------------------------------------------------------------------------------------------
            Console.ReadLine();
            //  Close Connection
            aConnection.Close();
            /*
            foreach(var p in aProductList)
            {
                Console.WriteLine(p.ToString());
            }*/
            /*Console.ReadLine();
        }*/
    }
}
