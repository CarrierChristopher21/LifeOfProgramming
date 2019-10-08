using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace Northwind2.Models
{

    public class Category
    {
        private int categoryId = -1;
        private string categoryName = "n/a";
        private string description = "n/a";
        private static int numberOfCategories = 0;

        public int CategoryId
        {
            get
            {
                return this.categoryId;
            }
        }

        public string CategoryName
        {
            get
            {
                return this.categoryName;
            }

            set
            {
                this.categoryName = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.description = value;
            }
        }

        // Constructors

        public Category()
        {
            Category.numberOfCategories = Category.numberOfCategories + 1;
        }

        public Category(int aCategoryId, string aCategoryName, string aDescription)
            : this()
        {
            this.categoryId = aCategoryId;
            this.CategoryName = aCategoryName;
            this.Description = aDescription;
        }

        public Category(int aCategoryId, string aCategoryName)
            : this(aCategoryId, aCategoryName, "na")
        {

        }

        public Category(int aCategoryId)
            : this(aCategoryId, "na", "na")
        {

        }

        // ToString  

        public override string ToString()
        {
            string aString = "";
            aString = aString + "SupplierId = " + CategoryId + "\n";
            aString = aString + "Category Name = " + CategoryName + "\n";
            aString = aString + "Description = " + Description + "\n";
            aString = aString + "Number of Categories = " + Category.numberOfCategories + "\n";
            return aString;
        }

        public string Display()
        {
            string aString = "";
            aString = aString + "SupplierId = " + CategoryId + "<br />";
            aString = aString + "Category Name = " + CategoryName + "<br />";
            aString = aString + "Description = " + Description + "<br />";
            aString = aString + "Number of Categories = " + Category.numberOfCategories + "<br />";
            return aString;
        }
    }
}
