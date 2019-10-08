/* 
 * Christopher Carrier
 * HW 1
 * 1/30/14
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class Order_Detail
    {
        /*      Information about Order Details Class
            This class receives the Order Detail's data and then assigns the Order Detail's data to a the specific variable
            within the class. Also, this class will test if the data is blank or not available.
            It also sets up the .ToString() format for this file for when its called.
        */
        //Declaration
        private int orderId = -1;
        private string productId = "n/a";
        private string customerTitle = "n/a";
        private string customerName = "n/a";
        private string employeeTitleCourtesy = "n/a";
        private string employeeFirstName = "n/a";
        private string employeeLastName = "n/a";
        private string employeeTitle= "n/a";
        /*  In Progress Declaration
        private Customer Customer = null;
        private Employee Employee = null;*/
        private double unitPrice = 0;
        private int quantity = -1;
        private string discount = "n/a";
        private static int numberOfOrderDetails = 0;

        //GETS AND SETS
        public int OrderId
        {
            get
            {
                return this.orderId;
            }
        }

        public string ProductId
        {
            get
            {
                return this.productId;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.productId = value;
                }
                else
                {
                    this.productId = "n/a";
                }
            }
        }

        public string CustomerTitle
        {
            get
            {
                return this.customerTitle;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.customerTitle = value;
                }
                else
                {
                    this.customerTitle = "n/a";
                }
            }
        }

        public string CustomerName
        {
            get
            {
                return this.customerName;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.customerName = value;
                }
                else
                {
                    this.customerName = "n/a";
                }
            }
        }

        public string EmployeeTitleCourtesy
        {
            get
            {
                return this.employeeTitleCourtesy;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.employeeTitleCourtesy = value;
                }
                else
                {
                    this.employeeTitleCourtesy = "n/a";
                }
            }
        }

        public string EmployeeFirstName
        {
            get
            {
                return this.employeeFirstName;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.employeeFirstName = value;
                }
                else
                {
                    this.employeeFirstName = "n/a";
                }
            }
        }

        public string EmployeeLastName
        {
            get
            {
                return this.employeeLastName;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.employeeLastName = value;
                }
                else
                {
                    this.employeeLastName = "n/a";
                }
            }
        }

        public string EmployeeTitle
        {
            get
            {
                return this.employeeTitle;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.employeeTitle = value;
                }
                else
                {
                    this.employeeTitle = "n/a";
                }
            }
        }

        /*  Calling Customer
        public Customer CustomerID
        {
            get
            {
                return this.Customer;
            }
            set
            {
                this.Customer = value;
            }
        }*/

        /*  Calling Employee
        public Employee EmployeeID
        {
            get
            {
                return this.Employee;
            }
            set
            {
                this.Employee = value;
            }
        }*/

        public double UnitPrice
        {
            get
            {
                return this.unitPrice;
            }
            set
            {
                if(value > 0)
                {
                    this.unitPrice = value;
                }
                else
                {
                    this.unitPrice = 0;
                }
            }
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                if(value > 0)   //For int's use just value but for string use value.length
                {
                    this.quantity = value;
                }
                else
                {
                    this.quantity = 0;
                }
            }
        }

        public string Discount
        {
            get
            {
                return this.discount;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.discount = value;
                }
                else
                {
                    this.discount = "n/a";
                }
            }
        }

        //Constructors
        public Order_Detail()
        {
            Order_Detail.numberOfOrderDetails++;
        }

        /*  In Proccess */
        public Order_Detail(int anId, string aProductId, string aCustomerTitle, string aCustomerName, 
            string aEmployeeTitleCourtesy, string aEmployeeFirstName, string aEmployeeLastName, string aEmployeeTitle, double aUnitPrice, 
            int aQuantity, string aDiscount)
            : this()
        {
            this.orderId = anId;                // Do Not Capatilize the variable for anID
            this.ProductId = aProductId;        // Capatilize the rest of the this.variable's
            this.CustomerTitle = aCustomerTitle;
            this.CustomerName = aCustomerName;
            this.EmployeeTitleCourtesy = aEmployeeTitleCourtesy;
            this.EmployeeFirstName = aEmployeeFirstName;
            this.EmployeeLastName = aEmployeeLastName;
            this.EmployeeTitle = aEmployeeTitle;
            this.UnitPrice = aUnitPrice;
            this.Quantity = aQuantity;
            this.Discount = aDiscount;
        }

        public Order_Detail(int anId, string aProductId, string aCustomerTitle, string aCustomerName, string aEmployeeTitleCourtesy,
            string aEmployeeFirstName, string aEmployeeLastName, string aEmployeeTitle, double aUnitPrice, int aQuantity)
            : this(anId, aProductId, aCustomerTitle, aCustomerName, aEmployeeTitleCourtesy, aEmployeeFirstName, aEmployeeLastName,
            aEmployeeTitle, aUnitPrice, aQuantity, "n/a")
        {

        }

        public Order_Detail(int anId, string aProductId, string aCustomerTitle, string aCustomerName, string aEmployeeTitleCourtesy,
            string aEmployeeFirstName, string aEmployeeLastName, string aEmployeeTitle, double aUnitPrice)
            : this(anId, aProductId, aCustomerTitle, aCustomerName, aEmployeeTitleCourtesy, aEmployeeFirstName, aEmployeeLastName,
            aEmployeeTitle, aUnitPrice, -1, "n/a")
        {

        }

        public Order_Detail(int anId, string aProductId, string aCustomerTitle, string aCustomerName, string aEmployeeTitleCourtesy,
        string aEmployeeFirstName, string aEmployeeLastName, string aEmployeeTitle)
            : this(anId, aProductId, aCustomerTitle, aCustomerName, aEmployeeTitleCourtesy, aEmployeeFirstName, aEmployeeLastName,
            aEmployeeTitle, 0, -1, "n/a")
        {

        }

        public Order_Detail(int anId, string aProductId, string aCustomerTitle, string aCustomerName, string aEmployeeTitleCourtesy,
        string aEmployeeFirstName, string aEmployeeLastName)
            : this(anId, aProductId, aCustomerTitle, aCustomerName, aEmployeeTitleCourtesy, aEmployeeFirstName, aEmployeeLastName,
            "n/a", 0, -1, "n/a")
        {

        }

        public Order_Detail(int anId, string aProductId, string aCustomerTitle, string aCustomerName, string aEmployeeTitleCourtesy,
        string aEmployeeFirstName)
            : this(anId, aProductId, aCustomerTitle, aCustomerName, aEmployeeTitleCourtesy, aEmployeeFirstName, "n/a", "n/a", 0, -1, "n/a")
        {

        }

        public Order_Detail(int anId, string aProductId, string aCustomerTitle, string aCustomerName, string aEmployeeTitleCourtesy)
            : this(anId, aProductId, aCustomerTitle, aCustomerName, aEmployeeTitleCourtesy, "n/a", "n/a", "n/a", 0, -1, "n/a")
        {

        }

        public Order_Detail(int anId, string aProductId, string aCustomerTitle, string aCustomerName)
            : this(anId, aProductId, aCustomerTitle, aCustomerName, "n/a", "n/a", "n/a", "n/a", 0, -1, "n/a")
        {

        }

        public Order_Detail(int anId, string aProductId, string aCustomerTitle)
            : this(anId, aProductId, aCustomerTitle, "n/a", "n/a", "n/a", "n/a", "n/a", 0, -1, "n/a")
        {

        }

        public Order_Detail(int anId, string aProductId)
            : this(anId, aProductId, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", 0, -1, "n/a")
        {

        }

        public Order_Detail(int anId)
            : this(anId, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", 0, -1, "n/a")
        {

        }//*/

        /*  In Proccess
        public Order_Detail(int anId, string aProductId, Customer aCustomerTitle, Customer aCustomerName, 
            Employee aEmployeeTitleCourtesy, Employee aEmployeeFirstName, Employee aEmployeeLastName, Employee aEmployeeTitle, double aUnitPrice, 
            int aQuantity, string aDiscount)
            : this()
        {
            this.orderId = anId;                // Do Not Capatilize the variable for anID
            this.ProductId = aProductId;        // Capatilize the rest of the this.variable's
            this.CustomerID = aCustomerTitle;
            this.CustomerID = aCustomerName;
            this.EmployeeID = aEmployeeTitleCourtesy;
            this.EmployeeID = aEmployeeFirstName;
            this.EmployeeID = aEmployeeLastName;
            this.EmployeeID = aEmployeeTitle;
            this.UnitPrice = aUnitPrice;
            this.Quantity = aQuantity;
            this.Discount = aDiscount;
        }

        public Order_Detail(int anId, string aProductId, Customer aCustomerTitle, Customer aCustomerName, Employee aEmployeeTitleCourtesy,
            Employee aEmployeeFirstName, Employee aEmployeeLastName, Employee aEmployeeTitle, double aUnitPrice, int aQuantity)
            : this(anId, aProductId, aCustomerTitle, aCustomerName, aEmployeeTitleCourtesy, aEmployeeFirstName, aEmployeeLastName,
            aEmployeeTitle, aUnitPrice, aQuantity, "n/a")
        {

        }

        public Order_Detail(int anId, string aProductId, Customer aCustomerTitle, Customer aCustomerName, Employee aEmployeeTitleCourtesy,
            Employee aEmployeeFirstName, Employee aEmployeeLastName, Employee aEmployeeTitle, double aUnitPrice)
            : this(anId, aProductId, aCustomerTitle, aCustomerName, aEmployeeTitleCourtesy, aEmployeeFirstName, aEmployeeLastName,
            aEmployeeTitle, aUnitPrice, -1, "n/a")
        {

        }

        public Order_Detail(int anId, string aProductId, Customer aCustomerTitle, Customer aCustomerName, Employee aEmployeeTitleCourtesy,
        Employee aEmployeeFirstName, Employee aEmployeeLastName, Employee aEmployeeTitle)
            : this(anId, aProductId, aCustomerTitle, aCustomerName, aEmployeeTitleCourtesy, aEmployeeFirstName, aEmployeeLastName,
            aEmployeeTitle, 0, -1, "n/a")
        {

        }

        public Order_Detail(int anId, string aProductId, Customer aCustomerTitle, Customer aCustomerName, Employee aEmployeeTitleCourtesy,
        Employee aEmployeeFirstName, Employee aEmployeeLastName)
            : this(anId, aProductId, aCustomerTitle, aCustomerName, aEmployeeTitleCourtesy, aEmployeeFirstName, aEmployeeLastName,
            null, 0, -1, "n/a")
        {

        }

        public Order_Detail(int anId, string aProductId, Customer aCustomerTitle, Customer aCustomerName, Employee aEmployeeTitleCourtesy,
        Employee aEmployeeFirstName)
            : this(anId, aProductId, aCustomerTitle, aCustomerName, aEmployeeTitleCourtesy, aEmployeeFirstName, null, null, 0, -1, "n/a")
        {

        }

        public Order_Detail(int anId, string aProductId, Customer aCustomerTitle, Customer aCustomerName, Employee aEmployeeTitleCourtesy)
            : this(anId, aProductId, aCustomerTitle, aCustomerName, aEmployeeTitleCourtesy, null, null, null, 0, -1, "n/a")
        {

        }

        public Order_Detail(int anId, string aProductId, Customer aCustomerTitle, Customer aCustomerName)
            : this(anId, aProductId, aCustomerTitle, aCustomerName, null, null, null, null, 0, -1, "n/a")
        {

        }

        public Order_Detail(int anId, string aProductId, Customer aCustomerTitle)
            : this(anId, aProductId, aCustomerTitle, null, null, null, null, null, 0, -1, "n/a")
        {

        }

        public Order_Detail(int anId, string aProductId)
            : this(anId, aProductId, "n/a", null, null, null, null, null, 0, -1, "n/a")
        {

        }

        public Order_Detail(int anId)
            : this(anId, "n/a", "n/a", null, null, null, null, null, 0, -1, "n/a")
        {

        }
        */
       
        /*  Old Section 
        public Order_Detail(int anId, string aProductId, double aUnitPrice, int aQuantity, string aDiscount)
            : this()
        {
        
            this.orderId = anId;                // Do Not Capatilize the variable for anID
            this.ProductId = aProductId;        // Capatilize the rest of the this.variable's
            this.UnitPrice = aUnitPrice;
            this.Quantity = aQuantity;
            this.Discount = aDiscount;
        }
        
        public Order_Detail(int anId, string aProductId, double aUnitPrice, int aQuantity)
            : this(anId, aProductId, aUnitPrice, aQuantity, "n/a")
        {

        }
         
        public Order_Detail(int anId, string aProductId, double aUnitPrice)
            : this(anId, aProductId, aUnitPrice, -1, "n/a")
        {

        }

        public Order_Detail(int anId, string aProductId)
            : this(anId, aProductId, 0, -1, "n/a")
        {

        }

        public Order_Detail(int anId)
            : this(anId, "n/a", 0, -1, "n/a")
        {

        }//*/

        public static int GetNumberOfDetails()
        {
            return Order_Detail.numberOfOrderDetails;
        }

        //Output
        public override string ToString()
        {
            string aString = "";
            aString = aString + "Order Number = " + OrderId + "\n";
            aString = aString + "Product Name = " + ProductId + "\n";
            aString = aString + "Contact Title = " + CustomerTitle + "\n";
            aString = aString + "Contact Name = " + CustomerName + "\n";
            aString = aString + "Title Of Courtesy = " + EmployeeTitleCourtesy + "\n";
            aString = aString + "First Name = " + EmployeeFirstName + "\n";
            aString = aString + "Last Name = " + EmployeeLastName + "\n";
            aString = aString + "Title = " + EmployeeTitle + "\n";
            aString = aString + "Unit Price = " + UnitPrice + "\n";
            aString = aString + "Quantity Amount = " + Quantity + "\n";
            aString = aString + "Discount = " + Discount + "\n";
            aString = aString + "Number Of Orders = " + numberOfOrderDetails + "\n";

            return aString;
        }
    }
}

        /*  Output In Progress
        public override string ToString()
        {
            string aString = "";
            aString = aString + "Order Number = " + OrderId + "\n";
            aString = aString + "Product Name = " + ProductId + "\n";
            aString = aString + "Contact Title = " + Customer + "\n";
            aString = aString + "Contact Name = " + Customer + "\n";
            aString = aString + "Title Of Courtesy = " + Employee + "\n";
            aString = aString + "First Name = " + Employee + "\n";
            aString = aString + "Last Name = " + Employee + "\n";
            aString = aString + "Title = " + Employee + "\n";
            aString = aString + "Unit Price = " + UnitPrice + "\n";
            aString = aString + "Quantity Amount = " + Quantity + "\n";
            aString = aString + "Discount = " + Discount + "\n";
            aString = aString + "Number Of Orders = " + numberOfOrderDetails + "\n";

            return aString;

        }*/