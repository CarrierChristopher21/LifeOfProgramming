using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Models
{
    public class Category
    {
        private int categoryId = 0;
        private string categoryName = "n/a";
        private string description = "n/a";
        private bool isDirty = false;
		private BrokenRules theBrokenRules = new BrokenRules();

        public int CategoryId
        {
            get
            {
                return categoryId;
            }
            set
            {
                // ideally this is not needed because
                // this is the primary key
                // and there should not even be a set
                // for this property

                isDirty = true;
                categoryId = value;
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
                isDirty = true;
                categoryName = value;

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "NameRequired";
				aRule.RuleDescription = "You must supply a non emptry Category Name";
				// **********************************************************************
				// **********************************************************************

				theBrokenRules.CheckRule(aRule.RuleName, aRule, (value.Length > 0));
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
                isDirty = true;
                description = value;

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "DescriptionRequired";
				aRule.RuleDescription = "You must supply a non emptry Category Description";
				// **********************************************************************
				// **********************************************************************

				theBrokenRules.CheckRule(aRule.RuleName, aRule, (value.Length > 0));
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

		public Category(int aCategoryId)
			: this(aCategoryId, "n/a", "n/a")
		{

		}
        public override string ToString()
        {
            string aString = "";
            aString += "Category ID = " + this.CategoryId + "<br />";
            aString += "Category Name = " + this.CategoryName + "<br />";
            aString += "Description = " + this.Description + "<br /><br />";
            return aString;
        }

    }
}