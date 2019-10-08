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
    class Order_Detail
    {
        //Declaration
        private int orderId = -1;
        private int productId = -1;
        private int quantity = -1;
        private double unitPrice = 0;
        private double discount = 0;

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
                    this.quantity = -1;
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
                    this.unitPrice = -1;
                }
            }
        }

        public double Discount
        {
            get
            {
                return this.discount;
            }
            set
            {
                if(value > 0)
                {
                    this.discount = value;
                }
                else
                {
                    this.discount = -1;
                }
            }
        }

        //Constructors
        public Order_Detail()
        {

        }

        public Order_Detail(int anId, int aproductId, int aquantity, double aunitPrice, double adiscount)
            : this()
        {
            this.orderId = anId;                // Do Not Capatilize the variable for anID
            this.ProductId = aproductId;        // Capatilize the rest of the this.variable's
            this.Quantity = aquantity;
            this.UnitPrice = aunitPrice;
            this.Discount = adiscount;
        }

        public Order_Detail(int anId, int aproductId, int aquantity, double aunitPrice)
            : this(anId, aproductId, aquantity, aunitPrice, 0)
        {

        }

        public Order_Detail(int anId, int aproductId, int aquantity)
            : this(anId, aproductId, aquantity, 0, 0)
        {

        }

        public Order_Detail(int anId, int aproductId)
            : this(anId, aproductId, 0, 0, 0)
        {

        }

        public Order_Detail(int anId)
            : this(anId, 0, 0, 0, 0)
        {

        }

        //Output
        public override string ToString()
        {
            string aString = "";
            aString = aString + "Order Number = " + OrderId + "\n";
            aString = aString + "Product ID = " + ProductId + "\n";
            aString = aString + "Quantity Amount = " + Quantity + "\n";
            aString = aString + "Unit Price = " + UnitPrice + "\n";
            aString = aString + "Discount = " + Discount + "\n";

            return aString;

        }
    }
}
