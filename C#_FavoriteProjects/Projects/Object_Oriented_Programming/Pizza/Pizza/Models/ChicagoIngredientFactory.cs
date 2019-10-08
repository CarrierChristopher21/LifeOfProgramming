using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.Models
{
	public class ChicagoIngredientFactory :PizzaIngredientFactory
	{
		public IDough createDough()
		{
			return new ThickCrustDough();
		}
		public ISauce createSauce()
		{
			return new PlumTomatoSauce();
		}
		public ICheese createCheese()
		{
			return new Mozzarella();
		}
		public IPepperoni createPepperoni()
		{
			return new SlicedPepperoni();
		}
		public IClams createClams()
		{
			return new FreshClams();
		}
	}
}