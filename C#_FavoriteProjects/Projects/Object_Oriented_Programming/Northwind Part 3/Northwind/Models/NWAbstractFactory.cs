/*
 * Author:	Chris Carrier
 * Date: 1/15/15
 * Information:	 This code is one of the abstract factorys. This abstract class creates two of
 * the abstract mehtods that revolves around creating the DataSet and Reader for the Factory Patterns.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
	public abstract class NWAbstractFactory
	{
		//Two abstract methods
		public abstract INWDataReader CreateReader(string aSQL);
		public abstract INWDataSet CreateDataSet(string aSQL);

	}
}