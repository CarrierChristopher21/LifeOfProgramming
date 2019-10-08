/*	Author: Chris Carrier
 *	Date:	1/15/15
 *	Information: This class receives the Category data and then assigns the Category data to a the specific variable within 
 *	the class. Also, this class will test if the data is blank or not available by using constructors. It also sets up 
 *	the ToString() format for this file for when its called.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
    public class Category
    {
        private int categoryId = 0;
        private string categoryName = "n/a";
        private string description = "n/a";
        private BrokenRules theBrokenRules = new BrokenRules();
		private bool isDirty = false;
		

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
                categoryName = value;
				isDirty = true;                

				// Somewhere rules may already exist
				// that is, your organization may have standard rules
				// we don't have that, thus we have to make our own broken rule
				// **********************************************************************
				BrokenRule aRule = new BrokenRule();
				aRule.RuleName = "Name Required";
				aRule.RuleDescription = "You must supply a non emptry Category Name";
				// **********************************************************************
				// **********************************************************************
				theBrokenRules.CheckRule(aRule.RuleName, aRule, (value.Length > 0));
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
				isDirty = true;                

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
            this.categoryId = aCategoryId;
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
            aString = aString + "Category ID = " + this.CategoryId + "<br />";
            aString = aString + "Category Name = " + this.CategoryName + "<br />";
            aString = aString + "Description = " + this.Description + "<br /><br />";
            return aString;
        }

    }
}