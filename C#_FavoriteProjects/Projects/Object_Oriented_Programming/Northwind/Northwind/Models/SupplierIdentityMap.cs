using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
	public class SupplierIdentityMap
	{
		private Dictionary<int, Supplier> aDictionary = new Dictionary<int, Supplier>();

		public Dictionary<int, Supplier> GetDictionary()
		{

			return aDictionary;
		}

		public Boolean isInDictionary(int aKey)
		{

			bool answer = false;

			answer = aDictionary.ContainsKey(aKey);

			return answer;
		}

		public void AddSupplier(int aKey, Supplier aSupplier)
		{

			aDictionary.Add(aKey, aSupplier);

			//alternatively
			//aDictionary.Add(aCategory.CategoryId, aCategory);
			// This is slightly less good because the key may not
			// be the primary key
		}

		// use this method to retreive an item
		// in the map
		public Supplier GetSupplier(int aKey)
		{
			return aDictionary[aKey];

		}

		// you may at some point need to 
		// remove an item from the map
		// this does not delete from 
		// the database
		// all database functions are
		// on the table gateway object
		public void RemoveSupplier(int aKey)
		{

			aDictionary.Remove(aKey);

		}
	}
}