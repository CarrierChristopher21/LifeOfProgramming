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

namespace HW1
{
    public class Order
    {
        //Declaration
        private int orderId = -1;
        private int customerId = -1;
        private int employeeId = -1;
        private int shipVia = -1;
        private string orderDate = "n/a";
        private string requiredDate = "n/a";
        private string shippedDate = "n/a";
        private string shipName = "n/a";
        private string shipAddress = "n/a";
        private string shipCity = "n/a";
        private string shipRegion = "n/a";
        private string shipPostalCode = "n/a";
        private string shipCountry = "n/a";
        private double freight = 0;

        //GETS + SETS
        public int OrderId
        {
            get
            {
                return this.orderId;
            }
        }

        public int CustomerId
        {
            get                                 
            {
                return this.customerId;
            }
            set
            {
                if(value > 0)                   //For int's use just value but for string use value.length
                {
                    this.customerId = value;
                }
                else
                {
                    this.customerId = -1;
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

        //Constructors
        public Order()
        {


        }

        public Order(int anId, int acustomerId, int aemployeeId, int ashipVia, string aorderDate, 
            string arequiredDate, string ashippedDate, string ashipName, string ashipAddress, 
            string ashipCity, string ashipRegion, string ashipPostalCode, string ashipCountry, 
            double afreight)
            : this()
        {
            this.orderId = anId;                // Do Not Capatilize the variable for anID
            this.CustomerId = acustomerId;      // Capatilize the rest of the this.variable's
            this.EmployeeId = aemployeeId;
            this.ShipVia = ashipVia;
            this.OrderDate = aorderDate;
            this.RequiredDate = arequiredDate;
            this.ShippedDate = ashippedDate;
            this.ShipName = ashipName;
            this.ShipAddress = ashipAddress;
            this.ShipCity = ashipCity;
            this.ShipRegion = ashipRegion;
            this.ShipPostalCode = ashipPostalCode;
            this.ShipCountry = ashipCountry;
            this.Freight = afreight;

        }
        
        public Order(int anId, int acustomerId, int aemployeeId, int ashipVia, string aorderDate, 
            string arequiredDate, string ashippedDate, string ashipName, string ashipAddress, 
            string ashipCity, string ashipRegion, string ashipPostalCode, string ashipCountry)
            : this(anId, acustomerId, aemployeeId, ashipVia, aorderDate, arequiredDate, 
            ashippedDate, ashipName, ashipAddress, ashipCity, ashipRegion, ashipPostalCode, 
            ashipCountry, 0)
        {
            
        }

        public Order(int anId, int acustomerId, int aemployeeId, int ashipVia, string aorderDate,
            string arequiredDate, string ashippedDate, string ashipName, string ashipAddress,
            string ashipCity, string ashipRegion, string ashipPostalCode)
            : this(anId, acustomerId, aemployeeId, ashipVia, aorderDate, arequiredDate,
            ashippedDate, ashipName, ashipAddress, ashipCity, ashipRegion, ashipPostalCode,
            "n/a", 0)
        {

        }

        public Order(int anId, int acustomerId, int aemployeeId, int ashipVia, string aorderDate,
            string arequiredDate, string ashippedDate, string ashipName, string ashipAddress,
            string ashipCity, string ashipRegion)
            : this(anId, acustomerId, aemployeeId, ashipVia, aorderDate, arequiredDate,
            ashippedDate, ashipName, ashipAddress, ashipCity, ashipRegion, "n/a", "n/a", 0)
        {

        }

        public Order(int anId, int acustomerId, int aemployeeId, int ashipVia, string aorderDate,
            string arequiredDate, string ashippedDate, string ashipName, string ashipAddress,
            string ashipCity)
            : this(anId, acustomerId, aemployeeId, ashipVia, aorderDate, arequiredDate,
            ashippedDate, ashipName, ashipAddress, ashipCity, "n/a", "n/a", "n/a", 0)
        {

        }

        public Order(int anId, int acustomerId, int aemployeeId, int ashipVia, string aorderDate,
            string arequiredDate, string ashippedDate, string ashipName, string ashipAddress)
            : this(anId, acustomerId, aemployeeId, ashipVia, aorderDate, arequiredDate,
            ashippedDate, ashipName, ashipAddress, "n/a", "n/a", "n/a",
            "n/a", 0)
        {

        }

        public Order(int anId, int acustomerId, int aemployeeId, int ashipVia, string aorderDate,
            string arequiredDate, string ashippedDate, string ashipName)
            : this(anId, acustomerId, aemployeeId, ashipVia, aorderDate, arequiredDate,
            ashippedDate, ashipName, "n/a", "n/a", "n/a", "n/a", "n/a", 0)
        {

        }

        public Order(int anId, int acustomerId, int aemployeeId, int ashipVia, string aorderDate,
            string arequiredDate, string ashippedDate)
            : this(anId, acustomerId, aemployeeId, ashipVia, aorderDate, arequiredDate,
            ashippedDate, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", 0)
        {

        }

        public Order(int anId, int acustomerId, int aemployeeId, int ashipVia, string aorderDate,
            string arequiredDate)
            : this(anId, acustomerId, aemployeeId, ashipVia, aorderDate, arequiredDate, "n/a", 
            "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", 0)
        {

        }

        public Order(int anId, int acustomerId, int aemployeeId, int ashipVia, string aorderDate)
            : this(anId, acustomerId, aemployeeId, ashipVia, aorderDate, "n/a", "n/a", "n/a", 
            "n/a", "n/a", "n/a", "n/a", "n/a", 0)
        {

        }

        public Order(int anId, int acustomerId, int aemployeeId, int ashipVia)
            : this(anId, acustomerId, aemployeeId, ashipVia, "n/a", "n/a", "n/a", "n/a", "n/a", 
            "n/a", "n/a", "n/a", "n/a", 0)
        {

        }

        public Order(int anId, int acustomerId, int aemployeeId)
            : this(anId, acustomerId, aemployeeId, -1, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", 
            "n/a", "n/a", "n/a", 0)
        {

        }

        public Order(int anId, int acustomerId)
            : this(anId, acustomerId, -1, -1, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", 
            "n/a", "n/a", 0)
        {

        }

        public Order(int anId)
            : this(anId, -1, -1, -1, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", 
            "n/a", 0)
        {

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

            return aString;
        }
        
    }
}
