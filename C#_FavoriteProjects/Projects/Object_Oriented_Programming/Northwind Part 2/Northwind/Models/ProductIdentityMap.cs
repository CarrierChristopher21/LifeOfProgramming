using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
	public class ProductIdentityMap
	{
		private Dictionary<int, Product> aDictionary = new Dictionary<int, Product>();

		public Dictionary<int, Product> GetDictionary()
		{

			return aDictionary;
		}

		public Boolean isInDictionary(int aKey)
		{

			bool answer = false;

			answer = aDictionary.ContainsKey(aKey);

			return answer;
		}

		public void AddProduct(int aKey, Product aProduct)
		{

			aDictionary.Add(aKey, aProduct);

			//alternatively
			//aDictionary.Add(aCategory.CategoryId, aCategory);
			// This is slightly less good because the key may not
			// be the primary key
		}

		// use this method to retreive an item
		// in the map
		public Product GetProduct(int aKey)
		{
			return aDictionary[aKey];

		}

		// you may at some point need to 
		// remove an item from the map
		// this does not delete from 
		// the database
		// all database functions are
		// on the table gateway object
		public void RemoveProduct(int aKey)
		{

			aDictionary.Remove(aKey);

		}
	}
}