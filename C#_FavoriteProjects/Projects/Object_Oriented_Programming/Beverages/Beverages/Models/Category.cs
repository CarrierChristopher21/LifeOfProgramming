using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beverages.Models
{
    public class Category
    {
        private int categoryID;
        private string categoryName;
        private string description;

        //  Gets & Sets
        public int CategoryID
        {
            get
            {
                return categoryID;
            }
            set
            {
                categoryID = value;
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
                categoryName = value;
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
                description = value;
            }
        }


    }
}