using System;
using System.Collections;
using System.Text;

namespace PizzaFactory.Models
{

	public abstract class Pizza
	{

		protected string name;
		protected IDough dough;
		protected ISauce sauce;
        protected ICheese cheese;
        protected IPepperoni pepperoni;
        protected IClams clams;

		public abstract void prepare();


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

        public void setName(String aName)
        {
            this.name = aName;
        }

        public  String toString()
        {
            String aMessgae = "";
            aMessgae = aMessgae + this.getName();

            return aMessgae;
        }
	}
}
