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


namespace Connection
{
    public class Product
    {
        // Declaration
        private int productId = -1; // only one with a get
        private string productName = "n/a";
        private string supplierId = "n/a";
        private string categoryId = "n/a";        
        private string quantityPerUnit = "n/a";
        private double unitPrice = 1000000000;
        private int unitsInStock = -1;
        private int unitsOnOrder = -1;
        private int reorderLevel = -1;
        private bool discontinued = false;
        private static int numberOfProducts = 0;

        // Get And Sets
        public int ProductId
        {
            get
            {
                return productId;
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

        public string SupplierId
        {
            get
            {
                return supplierId;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.supplierId = value;   
                }
                else
                {
                    this.supplierId = "n/a";
                }             
            }
        }

        public string CategoryId
        {
            get
            {
                return categoryId;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.categoryId = value; 
                }
                else
                {
                    this.categoryId = "n/a";
                }               
            }
        }//*/

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

        public double UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                if(value >= 0)
                {
                    this.unitPrice = value;
                }
                else
                {
                    this.unitPrice = -1;
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
                if(value >= 0)
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
                if(value >= 0)
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
                if(value >= 0)
                {
                    this.reorderLevel = value;
                }
                else
                {
                    this.reorderLevel = -1;
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
 
        // Constructors
        public Product()
        {
            Product.numberOfProducts++;
        }

        public Product(int anId, string aproductName, string asupplierId, string acategoryId, string aquantityPerUnit, double aunitPrice, 
            int aunitsInStock, int aunitsOnOrder, int areorderLevel, bool adiscontinued)
            : this()
        {
            this.productId = anId;              // Do Not Capatilize the variable for anID
            this.ProductName = aproductName;
            this.SupplierId = asupplierId;      // Capatilize the rest of the this.variable's
            this.CategoryId = acategoryId;
            this.QuantityPerUnit = aquantityPerUnit;
            this.UnitPrice = aunitPrice;
            this.UnitsInStock = aunitsInStock;
            this.UnitsOnOrder = aunitsOnOrder;
            this.ReorderLevel = areorderLevel;
            this.Discontinued = adiscontinued;
            
        }

        public Product(int anId, string aproductName, string asupplierId, string acategoryId, string aquantityPerUnit, double aunitPrice, 
            int aunitsInStock, int aunitsOnOrder, int areorderLevel)
            : this(anId, aproductName, asupplierId, acategoryId, aquantityPerUnit, aunitPrice, aunitsInStock, 
                aunitsOnOrder, areorderLevel, false)
        {

        }

        public Product(int anId, string aproductName, string asupplierId, string acategoryId, string aquantityPerUnit, double aunitPrice, 
            int aunitsInStock, int aunitsOnOrder)
            : this(anId, aproductName, asupplierId, acategoryId, aquantityPerUnit, aunitPrice, aunitsInStock, aunitsOnOrder, -1, false)
        {

        }

        public Product(int anId, string aproductName, string asupplierId, string acategoryId, string aquantityPerUnit, double aunitPrice, 
            int aunitsInStock)
            : this(anId, aproductName, asupplierId, acategoryId, aquantityPerUnit, aunitPrice, aunitsInStock, 
                -1, -1, false)
        {

        }

        public Product(int anId, string aproductName, string asupplierId, string acategoryId, string aquantityPerUnit, double aunitPrice)
            : this(anId, aproductName, asupplierId, acategoryId, aquantityPerUnit, aunitPrice, -1, -1, -1, false)
        {

        }

        public Product(int anId, string aproductName, string asupplierId, string acategoryId, string aquantityPerUnit)
            : this(anId, aproductName, asupplierId, acategoryId, aquantityPerUnit, 0, -1, -1, -1, false)
        {

        }

        public Product(int anId, string aproductName, string asupplierId, string acategoryId)
            : this(anId, aproductName, asupplierId, acategoryId, "n/a", 0, -1, -1, -1, false)
        {

        }

        public Product(int anId, string aproductName, string asupplierId)
            : this(anId, aproductName, asupplierId, "n/a", "n/a", 0, -1, -1, -1, false)
        {

        }

        public Product(int anId, string aproductName)
            : this(anId, aproductName, "n/a", "n/a", "n/a", 0, -1, -1, -1, false) 
        {

        }

        public Product(int anId)
            : this(anId, "n/a", /*-1, -1,*/"n/a", "n/a", "n/a", -1, -1, -1, -1, false)
        {

        }

        public static int GetNumberOfProducts()
        {
            return Product.numberOfProducts;
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
            aString = aString + "Number Of Products = " + numberOfProducts + "\n";

            return aString;
        }
    }
}
