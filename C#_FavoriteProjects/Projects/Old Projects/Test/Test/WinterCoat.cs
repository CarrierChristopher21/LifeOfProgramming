﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class WinterCoat
    {
        private int productId = -1;
        private string productName = "";
        private double unitPrice = 0;
        private int supplierId = -1;
        public List<string> Colors;
        static int numberOfProducts;
        public int ProductId
        {
            get
            {
                return this.productId;
            }
        }

        //  productName
        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                this.productName = value;
            }
        }

        //  Unit Price
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
                    this.UnitPrice = value;
                }
                else
                {
                    this.UnitPrice = 0;
                }
            }
         }

        //  Supplier Id
        public int SupplierId
        {
            get
            {
                return this.supplierId;
            }
            set
            {
                if(value > 0)
                {
                    this.supplierId = value;
                }
                else
                {
                    this.supplierId = 0;
                }
            }
        }

        public WinterCoat()
        {
            numberOfProducts++;
        }

        public WinterCoat(int aProductId, string aProductName, double aUnitPrice, int aSupplierId)
            : this() 
        { 
            this.productId = aProductId;
            this.ProductName = aProductName;
            this.UnitPrice = aUnitPrice;
            this.SupplierId = aSupplierId;

        }

        //  ProductName, UnitPrice, SupplierId
        public WinterCoat(string aProductName, double aUnitPrice, int aSupplierId)
            : this()
        {
            this.ProductName = aProductName;
            this.UnitPrice = aUnitPrice;
            this.SupplierId = aSupplierId;
        } 

        //  ProductName, UnitPrice
        public WinterCoat(string aProductName, double aUnitPrice)
            : this()
        {
            this.ProductName = aProductName;
            this.UnitPrice = aUnitPrice;
        }

        public string AddColor()
        {
            string aColor = "";
            
            return aColor;
        }
        public static int NumberOfProducts()
        {
            return WinterCoat.numberOfProducts;
        }
        //  Output
        public string ToString()
        {
            string aString = "";
            aString = aString + "Product ID = " + ProductId + "\n";
            aString = aString + "Product Name = " + ProductName + "\n";
            aString = aString + "Unit Price = " + UnitPrice + "\n";
            aString = aString + "Supplier ID = " + SupplierId + "\n";
            aString = aString + "Colors = " + Colors + "\n";
            aString = aString + "Number Of Products = " + WinterCoat.numberOfProducts + "\n";
            
            return aString;
        }
    }
}
