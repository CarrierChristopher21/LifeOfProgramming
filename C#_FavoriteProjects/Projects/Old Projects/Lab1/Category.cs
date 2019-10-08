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
    public class Category
    {
        // Declaration
        private int categoryId = -1;
        private string categoryName = "n/a";
        private string description = "n/a";

        // Get And Sets
        public int CategoryId
        {
            get
            {
                return categoryId;
            }
        }

        public string CategoryName
        {
            get
            {
                return categoryName;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.categoryName = value;
                }
                else
                {
                    this.categoryName = "n/a";
                }
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if(value.Length > 0)
                {
                    this.description = value;
                }
                else
                {
                    this.description = "n/a";
                }
            }
        }

        // Constructors
        public Category()
        {

        }

        public Category(int anId, string acategoryName, string adescription)
            : this()
        {
            this.categoryId = anId;                 // Do Not Capatilize the variable for anID
            this.CategoryName = acategoryName;      // Capatilize the rest of the this.variable's
            this.Description = adescription;
        }
        public Category(int anId, string acategoryName)
            : this(anId, acategoryName, "n/a")
        {

        }
        public Category(int anId)
            : this(anId, "n/a", "n/a")
        {

        }

        // Output
        public override string ToString()
        {
            string aString = "";
            aString = aString + "Category ID = " + CategoryId + "\n";
            aString = aString + "Category Name = " + CategoryName + "\n";
            aString = aString + "Description = " + Description + "\n";

            return aString;

        }
            

    }
}
