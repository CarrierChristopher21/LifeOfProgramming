using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public delegate void OurDelegate(string aString);


    public class ClassTwo
    {
        public void SayAnything(OurDelegate aMethod)
        {
            aMethod("Goodbye World");
        }  
    }
}
