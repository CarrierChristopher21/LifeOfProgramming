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

namespace OurBanner
{
    public class Order_Detail
    {
        //Declaration
        private int orderId = -1;
        private int productId = -1;
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

        public int ProductId
        {
            get
            {
                return this.productId;
            }
            set
            {
                if(value > 0)                   //For int's use just value but for string use value.length
                {
                    this.productId = value;
                }
                else
                {
                    this.productId = -1;
                }
            }
        }

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
                if(value > 0)
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

        public Order_Detail(int anId, int aProductId, double aUnitPrice, int aQuantity, string aDiscount)
            : this()
        {
            this.orderId = anId;                // Do Not Capatilize the variable for anID
            this.ProductId = aProductId;        // Capatilize the rest of the this.variable's
            this.UnitPrice = aUnitPrice;
            this.Quantity = aQuantity;
            this.Discount = aDiscount;
        }

        public Order_Detail(int anId, int aProductId, double aUnitPrice, int aQuantity)
            : this(anId, aProductId, aUnitPrice, aQuantity, "n/a")
        {

        }

        public Order_Detail(int anId, int aProductId, double aUnitPrice)
            : this(anId, aProductId, aUnitPrice, -1, "n/a")
        {

        }

        public Order_Detail(int anId, int aProductId)
            : this(anId, aProductId, 0, -1, "n/a")
        {

        }

        public Order_Detail(int anId)
            : this(anId, -1, 0, -1, "n/a")
        {

        }

        public static int GetNumberOfDetails()
        {
            return Order_Detail.numberOfOrderDetails;
        }

        //Output
        public override string ToString()
        {
            string aString = "";
            aString = aString + "Order Number = " + OrderId + "\n";
            aString = aString + "Product ID = " + ProductId + "\n";
            aString = aString + "Unit Price = " + UnitPrice + "\n";
            aString = aString + "Quantity Amount = " + Quantity + "\n";
            aString = aString + "Discount = " + Discount + "\n";
            aString = aString + "Number Of Orders = " + numberOfOrderDetails + "\n";

            return aString;

        }
    }
}
