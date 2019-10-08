/* Christopher Carrier
 * Lab 1
 * 1/30/14
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1
{
    public class Product
    {
        // Declaration
        private int productId = -1; // only one with a get
        private int supplierId = -1;
        private int categoryId = -1;
        private int unitsInStock = -1;
        private int unitsOnOrder = -1;
        private int reorderLevel = -1;
        private double unitPrice = 1000000000;
        private bool discontinued = false;
        private string productName = "n/a";
        private string quantityPerUnit = "n/a";


        // Get And Sets
        public int ProductId
        {
            get
            {
                return productId;
            }
        }
        public int SupplierId
        {
            get
            {
                return supplierId;
            }
            set
            {
                if(value > 0) 					//For int's use just value but for string use value.length
                {
                    this.supplierId = value;
                }
                else
                {
                    this.supplierId = -1;
                }
            }
        }
        public int CategoryId
        {
            get
            {
                return categoryId;
            }
            set
            {
                if(value > 0)
                {
                    this.categoryId = value;
                }
                else
                {
                    this.categoryId = -1;
                }
            }
        }
        public int UnitsInStock
        {
            get
            {
                return unitsInStock;
            }
            set
            {
                if(value > 0)
                {
                    this.unitsInStock = value;
                }
                else
                {
                    this.unitsInStock = -1;
                }
            }
        }
        public int UnitsOnOrder
        {
            get
            {
                return unitsOnOrder;
            }
            set
            {
                if(value > 0)
                {
                    this.unitsOnOrder = value;
                }
                else
                {
                    this.unitsOnOrder = -1;
                }
            }
        }
        public int ReorderLevel
        {
            get
            {
                return reorderLevel;
            }
            set
            {
                if(value > 0)
                {
                    this.reorderLevel = value;
                }
                else
                {
                    this.reorderLevel = -1;
                }
            }
        }
        public double UnitPrice
        {
            get
            {
                return unitPrice;
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
        public bool Discontinued
        {
            get
            {
                return discontinued;
            }
            set
            {
                this.discontinued = value;
            }
        }
        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.productName = value;
                }
                else
                {
                    this.productName = "n/a";
                }
            }
        }
        public string QuantityPerUnit
        {
            get
            {
                return quantityPerUnit;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.quantityPerUnit = value;
                }
                else
                {
                    this.quantityPerUnit = "n/a";
                }
            }
        }

        // Constructors
        public Product()
        {


        }
        public Product(int anId, int asupplierId, int acategoryId, int aunitsInStock, int 
            aunitsOnOrder, int areorderLevel, string aproductName, string aquantityPerUnit, 
            double aunitPrice, bool adiscontinued)
            : this()
        {

            this.productId = anId;              // Do Not Capatilize the variable for anID
            this.SupplierId = asupplierId;      // Capatilize the rest of the this.variable's
            this.CategoryId = acategoryId;
            this.UnitsInStock = aunitsInStock;
            this.UnitsOnOrder = aunitsOnOrder;
            this.ReorderLevel = areorderLevel;
            this.ProductName = aproductName;
            this.QuantityPerUnit = aquantityPerUnit;
            this.UnitPrice = aunitPrice;
            this.Discontinued = adiscontinued;
                        
        }
        public Product(int anId, int asupplierId, int acategoryId, int aunitsInStock, int 
            aunitsOnOrder, int areorderLevel, string aproductName, string aquantityPerUnit, 
            double aunitPrice)
            : this(anId, asupplierId, acategoryId, aunitsInStock, aunitsOnOrder, areorderLevel, 
            aproductName, aquantityPerUnit, aunitPrice, false)
        {

        }
        public Product(int anId, int asupplierId, int acategoryId, int aunitsInStock, int 
            aunitsOnOrder, int areorderLevel, string aproductName, string aquantityPerUnit)
            : this(anId, asupplierId, acategoryId, aunitsInStock, aunitsOnOrder, areorderLevel, 
            aproductName, aquantityPerUnit, 0, false)
        {

        }
        public Product(int anId, int asupplierId, int acategoryId, int aunitsInStock, int 
            aunitsOnOrder, int areorderLevel, string aproductName)
            : this(anId, asupplierId, acategoryId, aunitsInStock, aunitsOnOrder, areorderLevel, 
            aproductName, "n/a", 0, false)
        {

        }
        public Product(int anId, int asupplierId, int acategoryId, int aunitsInStock, int 
            aunitsOnOrder, int areorderLevel)
            : this(anId, asupplierId, acategoryId, aunitsInStock, aunitsOnOrder, areorderLevel, 
            "n/a", "n/a", 0, false)
        {

        }
        public Product(int anId, int asupplierId, int acategoryId, int aunitsInStock, int 
            aunitsOnOrder)
            : this(anId, asupplierId, acategoryId, aunitsInStock, aunitsOnOrder, -1, "n/a", 
            "n/a", 0, false)
        {

        }
        public Product(int anId, int asupplierId, int acategoryId, int aunitsInStock)
            : this(anId, asupplierId, acategoryId, aunitsInStock, -1, -1, "n/a", "n/a", 0, false)
        {

        }
        public Product(int anId, int asupplierId, int acategoryId)
            : this(anId, asupplierId, acategoryId, -1, -1, -1, "n/a", "n/a", 0, false)
        {

        }
        public Product(int anId, int asupplierId)
            : this(anId, asupplierId, -1, -1, -1, -1, "n/a", "n/a", 0, false)
        {

        }
        public Product(int anId)
            : this(anId, -1, -1, -1, -1, -1, "n/a", "n/a", 0, false)
        {

        }

        // Output
        public override string ToString()
        {
            string aString = "";
            aString = aString + "Product ID = " + ProductId + "\n";
            aString = aString + "Product Name = " + ProductName + "\n";
            aString = aString + "Supplier ID = " + SupplierId + "\n";
            aString = aString + "Category ID = " + CategoryId + "\n";
            aString = aString + "Quantity Per Unit = " + QuantityPerUnit + "\n";
            aString = aString + "Unit Price = " + UnitPrice + "\n";
            aString = aString + "Units In Stock = " + UnitsInStock + "\n";
            aString = aString + "Units On Order = " + UnitsOnOrder + "\n";
            aString = aString + "ReOrderLevel = " + ReorderLevel + "\n";
            aString = aString + "Discontinued = " + Discontinued + "\n";

            return aString;
        }
    }
}
