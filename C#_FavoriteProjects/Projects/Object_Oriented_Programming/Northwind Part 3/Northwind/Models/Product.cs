/*	Author: Chris Carrier
 *	Date:	1/15/15
 *	Information about Product Class
        This class receives the Product's data and then assigns the Product's data to a the specific variable
        within the class. Also, this class will test if the data is blank or not available.
        It also sets up the .ToString() format for this file for when its called.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Northwind.Models
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
		private bool isDirty = false;
		private BrokenRules theBrokenRules = new BrokenRules();

        // Get And Sets
        public int ProductId
        {
            get
            {
                return productId;
            }
			set
			{
				// ideally this is not needed because
				// this is the primary key
				// and there should not even be a set
				// for this property

				isDirty = true;
				productId = value;
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
				isDirty = true;
				productName = value;

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "ProductNameRequired";
				aRule.RuleDescription = "You must supply a non emptry Product Name";
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
				isDirty = true;
				supplierId = value;

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "SupplierIDRequired";
				aRule.RuleDescription = "You must supply a non emptry Supplier ID";
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
				isDirty = true;
				categoryId = value;

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "CategoryIDRequired";
				aRule.RuleDescription = "You must supply a non emptry CategoryID";
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
				isDirty = true;
				quantityPerUnit = value;

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "QuantityPerUnitRequired";
				aRule.RuleDescription = "You must supply a non emptry Quantity Per Unit";
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
				isDirty = true;
				unitPrice = value;

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "UnitPriceRequired";
				aRule.RuleDescription = "You must supply a non emptry Unit Price";
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
				isDirty = true;
				unitsInStock = value;

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "UnitsInStockRequired";
				aRule.RuleDescription = "You must supply a non emptry Units In Stock";
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
				isDirty = true;
				unitsOnOrder = value;

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "UnitsOnOrderRequired";
				aRule.RuleDescription = "You must supply a non emptry Units On Order";
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
				isDirty = true;
				reorderLevel = value;

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "ReorderLevelRequired";
				aRule.RuleDescription = "You must supply a non emptry Reorder Level";
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
				isDirty = true;
				discontinued = value;

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "discontinuedRequired";
				aRule.RuleDescription = "You must supply a non emptry Discontinued";
                this.discontinued = value;
            }
        }

		public bool IsDirty
		{
			get
			{
				return isDirty;
			}
			set
			{
				isDirty = value;
			}
		}

		public bool IsValid
		{
			get
			{
				if(theBrokenRules.GetDictionary().Count > 0)
				{
					return false;
				}
				else
				{
					return true;
				}
			}
		}
 
        // Constructors
        public Product()
        {
            
        }

        public Product(int aProductId, string aproductName, string asupplierId, string acategoryId, string aquantityPerUnit, double aunitPrice, 
            int aunitsInStock, int aunitsOnOrder, int areorderLevel, bool adiscontinued)
            : this()
        {
            this.ProductId = aProductId;              // Do Not Capatilize the variable for anID
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
            : this(anId, "n/a", "n/a", "n/a", "n/a", -1, -1, -1, -1, false)
        {

        }

        // Output
        public override string ToString()
        {
            string aString = "";
            aString = aString + "Product ID = " + ProductId + "<br />";
            aString = aString + "Product Name = " + ProductName + "<br />";
            aString = aString + "Company name = " + SupplierId + "<br />";
            aString = aString + "Category Name = " + CategoryId + "<br />";
            aString = aString + "Quantity Per Unit = " + QuantityPerUnit + "<br />";
            aString = aString + "Unit Price = " + UnitPrice + "<br />";
            aString = aString + "Units In Stock = " + UnitsInStock + "<br />";
            aString = aString + "Units On Order = " + UnitsOnOrder + "<br />";
            aString = aString + "ReOrderLevel = " + ReorderLevel + "<br />";
            aString = aString + "Discontinued = " + Discontinued + "<br />";

            return aString;
        }
    }
}
