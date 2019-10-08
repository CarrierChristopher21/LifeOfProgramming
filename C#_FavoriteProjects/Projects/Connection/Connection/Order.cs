/* Christopher Carrier
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
    public class Order
    {
        /*      Information about Order Class
            This class receives the Order's data and then assigns the Order's data to a the specific variable
            within the class. Also, this class will test if the data is blank or not available.
            It also sets up the .ToString() format for this file for when its called.
        */
        //Declaration
        private int orderId = -1;
        private string customerId = "n/a";
        private int employeeId = -1;
        private string orderDate = "n/a";
        private string requiredDate = "n/a";
        private string shippedDate = "n/a";
        private int shipVia = -1;
        private double freight = 0;
        private string shipName = "n/a";
        private string shipAddress = "n/a";
        private string shipCity = "n/a";
        private string shipRegion = "n/a";
        private string shipPostalCode = "n/a";
        private string shipCountry = "n/a";
        
        private static int numberOfOrders = 0;

        //GETS + SETS
        public int OrderId
        {
            get
            {
                return this.orderId;
            }
        }

        public string CustomerId
        {
            get                                 
            {
                return this.customerId;
            }
            set
            {
                if(value.Length > 0)                   //For int's use just value but for string use value.length
                {
                    this.customerId = value;
                }
                else
                {
                    this.customerId = "n/a";
                }
            }
        }

        public int EmployeeId
        {
            get
            {
                return this.employeeId;
            }
            set
            {
                if(value > 0)
                {
                    this.employeeId = value;
                }
                else
                {
                    this.employeeId = -1;
                }
            }
        }

        public string OrderDate
        {
            get
            {
                return this.orderDate;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.orderDate = value;
                }
                else
                {
                    this.orderDate = "n/a";
                }
            }
        }

        public string RequiredDate
        {
            get
            {
                return this.requiredDate;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.requiredDate = value;
                }
                else
                {
                    this.requiredDate = "n/a";
                }
            }
        }

        public string ShippedDate
        {
            get
            {
                return this.shippedDate;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.shippedDate = value;
                }
                else
                {
                    this.shippedDate = "n/a";
                }
            }
        }

        public int ShipVia
        {
            get
            {
                return this.shipVia;
            }
            set
            {
                if(value > 0)
                {
                    this.shipVia = value;
                }
                else
                {
                    this.shipVia = -1;
                }
            }
        }

        public double Freight
        {
            get
            {
                return this.freight;
            }
            set
            {
                if(value > 0)
                {
                    this.freight = value;
                }
                else
                {
                    this.freight = -1;
                }
            }
        }

        public string ShipName
        {
            get
            {
                return this.shipName;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.shipName = value;
                }
                else
                {
                    this.shipName = "n/a";
                }
            }
        }

        public string ShipAddress
        {
            get
            {
                return this.shipAddress;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.shipAddress = value;
                }
                else
                {
                    this.shipAddress = "n/a";
                }
            }
        }

        public string ShipCity
        {
            get
            {
                return this.shipCity;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.shipCity = value;
                }
                else
                {
                    this.shipCity = "n/a";
                }
            }
        }

        public string ShipRegion
        {
            get
            {
                return this.shipRegion;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.shipRegion = value;
                }
                else
                {
                    this.shipRegion = "n/a";
                }
            }
        }

        public string ShipPostalCode
        {
            get
            {
                return this.shipPostalCode;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.shipPostalCode = value;
                }
                else
                {
                    this.shipPostalCode = "n/a";
                }
            }
        }

        public string ShipCountry
        {
            get
            {
                return this.shipCountry;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.shipCountry = value;
                }
                else
                {
                    this.shipCountry = "n/a";
                }
            }
        }

        //Constructors
        public Order()
        {
            Order.numberOfOrders++;

        }

        public Order(int anId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, 
            int aShipVia, double aFreight, string aShipName, string aShipAddress, string aShipCity, string aShipRegion, 
            string aShipPostalCode, string aShipCountry)
            : this()
        {
            this.orderId = anId;                // Do Not Capatilize the variable for anID
            this.CustomerId = aCustomerId;      // Capatilize the rest of the this.variable's
            this.EmployeeId = aEmployeeId;
            this.OrderDate = aOrderDate;
            this.RequiredDate = aRequiredDate;
            this.ShippedDate = aShippedDate;
            this.ShipVia = aShipVia;
            this.Freight = aFreight;
            this.ShipName = aShipName;
            this.ShipAddress = aShipAddress;
            this.ShipCity = aShipCity;
            this.ShipRegion = aShipRegion;
            this.ShipPostalCode = aShipPostalCode;
            this.ShipCountry = aShipCountry;
          
        }

        public Order(int anId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate,
            int aShipVia, double aFreight, string aShipName, string aShipAddress, string aShipCity, string aShipRegion,
            string aShipPostalCode)
            : this(anId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, aShipName, aShipAddress, 
            aShipCity, aShipRegion, aShipPostalCode, "n/a")
        {
            
        }

        public Order(int anId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate,
            int aShipVia, double aFreight, string aShipName, string aShipAddress, string aShipCity, string aShipRegion)
            : this(anId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, aShipName, aShipAddress,
            aShipCity, aShipRegion, "n/a", "n/a")
        {

        }

        public Order(int anId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate,
            int aShipVia, double aFreight, string aShipName, string aShipAddress, string aShipCity)
            : this(anId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, aShipName, aShipAddress,
            aShipCity, "n/a", "n/a", "n/a")
        {

        }

        public Order(int anId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate,
            int aShipVia, double aFreight, string aShipName, string aShipAddress)
            : this(anId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, aShipName, aShipAddress,
            "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Order(int anId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate,
            int aShipVia, double aFreight, string aShipName)
            : this(anId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, aShipName, "n/a",
            "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Order(int anId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate,
            int aShipVia, double aFreight)
            : this(anId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, "n/a", "n/a",
            "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Order(int anId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate,
            int aShipVia)
            : this(anId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, 0, "n/a", "n/a",
            "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Order(int anId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate)
            : this(anId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, -1, 0, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Order(int anId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate)
            : this(anId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, "n/a", -1, 0, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Order(int anId, string aCustomerId, int aEmployeeId, string aOrderDate)
            : this(anId, aCustomerId, aEmployeeId, aOrderDate, "n/a", "n/a", -1, 0, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Order(int anId, string aCustomerId, int aEmployeeId)
            : this(anId, aCustomerId, aEmployeeId, "n/a", "n/a", "n/a", -1, 0, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Order(int anId, string aCustomerId)
            : this(anId, aCustomerId, -1, "n/a", "n/a", "n/a", -1, 0, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public Order(int anId)
            : this(anId, "n/a", -1, "n/a", "n/a", "n/a", -1, 0, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }

        public static int GetNumberOfOrder()
        {
            return Order.numberOfOrders;
        }
        public override string ToString()
        {
            string aString = "";
            aString = aString + "Order ID = " + OrderId + "\n";
            aString = aString + "Customer ID = " + CustomerId + "\n";
            aString = aString + "Employee ID = " + EmployeeId  + "\n";
            aString = aString + "Order Date = " + OrderDate + "\n";
            aString = aString + "Required Date = " + RequiredDate + "\n";
            aString = aString + "Shipped Date = " + ShippedDate + "\n";
            aString = aString + "Ship Via = " + ShipVia + "\n";
            aString = aString + "Freight = " + Freight + "\n";
            aString = aString + "Ship Name = " + ShipName + "\n";
            aString = aString + "Ship Address = " + ShipAddress + "\n";
            aString = aString + "Ship City = " + ShipCity + "\n";
            aString = aString + "Ship Region = " + ShipRegion + "\n";
            aString = aString + "Ship Postal Code = " + ShipPostalCode + "\n";
            aString = aString + "Ship Country = " + ShipCountry + "\n";
            aString = aString + "Number of Orders = " + Order.numberOfOrders + "\n";

            return aString;
        }
        
    }
}
