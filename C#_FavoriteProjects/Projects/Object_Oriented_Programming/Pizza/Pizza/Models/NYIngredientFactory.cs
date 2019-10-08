using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.Models
{
	public class NYIngredientFactory : PizzaIngredientFactory
	{
		public IDough createDough()
		{
			return new ThinCrustDough();
		}
		public ISauce createSauce()
		{
			return new MarinaraSauce();
		}
		public ICheese createCheese()
		{
			return new ReggianoCheese();
		}
		public IPepperoni createPepperoni()
		{
			return new SlicedPepperoni();
		}
		public IClams createClams()
		{
			return new FrozenClams();
		}
	}
}