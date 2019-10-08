/*	Author: Chris Carrier
 *	Date:	1/15/15
 *	Information: This class tests the ruleName and ruleDescription and then it decides whether the data from the classes 
 *	is usable or turn up blank / null. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
	public class BrokenRule
	{
		private string ruleName = "n/a";
		private string ruleDescription = "n/a";

		public string RuleName
		{
			get
			{
				return ruleName;
			}
			set
			{
				ruleName = value;
			}
		}
		public string RuleDescription
		{
			get
			{
				return ruleDescription;
			}
			set
			{
				ruleDescription = value;
			}
		}

		public override string ToString()
		{
			string aMessage = this.RuleName;
			aMessage = aMessage + " : " + this.RuleDescription + "<br />";
			return aMessage;
			
		}
	}
}