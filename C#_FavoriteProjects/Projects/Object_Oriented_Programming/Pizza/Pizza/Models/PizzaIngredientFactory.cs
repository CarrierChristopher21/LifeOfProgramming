using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.Models
{
	public interface PizzaIngredientFactory
	{
		public IDough createDough();
		public ISauce createSauce();
		public ICheese createCheese();
		public IPepperoni createPepperoni();
		public IClams createClams();



	}
}