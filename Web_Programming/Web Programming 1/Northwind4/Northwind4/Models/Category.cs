using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace Northwind4.Models
{

    public class Category
    {
        private int categoryId = -1;
        private string categoryName = "n/a";
        private string description = "n/a";


        public int CategoryId
        {
            get
            {
                return this.categoryId;
            }
            set
            {
                this.categoryId = value;

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

		}

		public Category(int aCategoryId, string aCategoryName, string aDescription)
			: this()
		{
			this.CategoryId = aCategoryId;
			this.CategoryName = aCategoryName;
			this.Description = aDescription;

		}

		public Category(int aCategoryId, string aCategoryName)
			: this(aCategoryId, aCategoryName, "n/a")
		{

		}

        

        // ToString  

        public override string ToString()
        {
			string aString = "";
			aString += "Category ID = " + this.CategoryId + "<br />";
			aString += "Category Name = " + this.CategoryName + "<br />";
			aString += "Description = " + this.Description + "<br /><br />";
			           
            return aString;
        }

        public string Display()
        {
            string aString = "";
            aString += "Category ID = " + CategoryId + "<br />";
            aString += "Category Name = " + CategoryName + "<br />";
            aString += "Description = " + Description + "<br /><br />";
           
            return aString;
        }
    }
}