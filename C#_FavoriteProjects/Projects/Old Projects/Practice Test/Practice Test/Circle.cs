using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Test
{
    public class Circle
    {
        private double radius;
        
        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value > 0)
                {
                    this.radius = value;
                }
                else
                {
                    this.radius = 0;
                }
            }
        }

        public double Diameter
        {
            get
            {
                return radius * 2;
            }
            set
            {
                if (value > 0)
                {
                    this.radius = value / 2;
                }
                else
                {
                    this.radius = 0;
                }
            }
        }

        public double Circumference
        {
            get
            {
                return 2 * Math.PI * radius;
            }
            set
            {
                if (value > 0)
                {
                    this.radius = value / (2 * Math.PI);
                }
                else
                {
                    this.radius = 0;
                }
            }
        }

        public double CalcArea()
        {
            double Area;
            Area = Math.PI * Math.Pow(radius, 2);

            return Area;
        }

        public Circle()
        {

        }

        public Circle(double aRadius)
            : this()
        {
            this.Radius = aRadius;
            
        }

        public override string ToString()
        {
            string aString = "";
            aString = aString + "Radius = " + Radius + "\n";
            aString = aString + "Diameter = " + Diameter + "\n";
            aString = aString + "Circumference = " + Circumference + "\n";
            aString = aString + "Calculate Area = " + CalcArea() + "\n";

            return aString;
        }
    }
}
