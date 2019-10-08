using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
	public class BrokenRules
	{
		private Dictionary<string, BrokenRule> aDictionary = new Dictionary<string, BrokenRule>();

		public Dictionary<string, BrokenRule> GetDictionary()
		{
			return aDictionary;
		}

		public Boolean isInDictionary(string aKey)
		{
			bool answer = false;
			answer = aDictionary.ContainsKey(aKey);
			return answer;
		}

		public void AddRule(string aKey, BrokenRule aBrokenRule)
		{
			aDictionary.Add(aKey, aBrokenRule);

			//alternatively
			//aDictionary.Add(aCategory.CategoryId, aCategory);
			// This is slightly less good because the key may not
			// be the primary key
		}

		// use this method to retreive an item
		// in the map

		public BrokenRule GetRule(string aKey)
		{
			return aDictionary[aKey];
		}

		// you may at some point need to 
		// remove an item from the map
		// this does not delete from 
		// the database
		// all database functions are
		// on the table gateway object

		public void RemoveRule(string aKey)
		{
			aDictionary.Remove(aKey);
		}

		public void CheckRule(string aRuleName, BrokenRule aRule, bool isBroken)
		{
			bool alreadyExists = this.isInDictionary(aRuleName);
			if(isBroken == true && alreadyExists == false)
			{
				this.AddRule(aRuleName, aRule);
			}
			else if(isBroken == false && alreadyExists == true)
			{
				this.RemoveRule(aRuleName);
			}
		}

		public override string ToString()
		{
			string aMessage = "";

			foreach(var b in aDictionary)
			{
				aMessage = aMessage + b.Value.ToString();
			}

			return aMessage;
		}
	}
}