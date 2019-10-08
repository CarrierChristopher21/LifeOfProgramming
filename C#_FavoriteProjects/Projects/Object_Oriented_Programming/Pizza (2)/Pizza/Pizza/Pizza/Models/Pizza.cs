using System;
using System.Collections;
using System.Text;

namespace PizzaFactory.Models
{

	public abstract class Pizza
	{

		protected string name;
		protected string dough;
		protected string sauce;
		protected ArrayList toppings = new ArrayList();


		public string prepare()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("Preparing " + name + "\n");
			sb.Append("Tossing " + dough + "\n");
			sb.Append("Adding " + sauce + "\n");
			sb.Append("Adding toppings:" + "\n");

			foreach(string topping in toppings)
			{
				sb.Append("\t" + topping + "\n");
			}

			return sb.ToString();
		}


		public virtual string bake()
		{
			return "Bake for 25 minutes at 350 \n";
		}



		public virtual string cut()
		{
			return "Cutting the pizza into diagonal slices \n";
		}



		public virtual string box()
		{
			return "Place pizza in official PizzaStore box \n";
		}



		public string getName()
		{
			return name;
		}

	}
}
