using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NWFactoryDemo.Models
{
	public class NWAbstractFactory
	{
		//Two abstract methods
		public abstract INWDataReader CreateReader(String aSQL);
		public abstract INWDataSet CreateDataSet(String aSQL);

	}
}