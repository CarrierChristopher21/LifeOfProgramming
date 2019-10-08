/*	Author: Chris Carrier
 *	Date:	1/15/15
 *	Information: This class is to use the ShipperIdentityMap for the Shipper class. Which revolves around putting 
 *	categories into dictionaries where it will see if any of the data saved has been altered at any point in time. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
	public class ShipperIdentityMap
	{
		private Dictionary<int, Shipper> aDictionary = new Dictionary<int, Shipper>();

		public Dictionary<int, Shipper> GetDictionary()
		{

			return aDictionary;
		}

		public Boolean isInDictionary(int aKey)
		{

			bool answer = false;

			answer = aDictionary.ContainsKey(aKey);

			return answer;
		}

		public void AddShipper(int aKey, Shipper aShipper)
		{

			aDictionary.Add(aKey, aShipper);

			//alternatively
			//aDictionary.Add(aCategory.CategoryId, aCategory);
			// This is slightly less good because the key may not
			// be the primary key
		}

		// use this method to retreive an item
		// in the map
		public Shipper GetShipper(int aKey)
		{
			return aDictionary[aKey];

		}

		// you may at some point need to 
		// remove an item from the map
		// this does not delete from 
		// the database
		// all database functions are
		// on the table gateway object
		public void RemoveShipper(int aKey)
		{

			aDictionary.Remove(aKey);

		}
	}
}