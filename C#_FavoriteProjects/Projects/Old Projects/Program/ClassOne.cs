/* 
 * Delicate Program
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class ClassOne
    {
        public void SaySomething(string aString)
        {
            Console.WriteLine(aString);
            Console.ReadLine();
        }

        public void SaySomethingElse(string aString)
        {
            int i = 0;
            while(i < 100)
            {
                Console.Write(aString + "   ");
                i = i + 1;
            }
            Console.ReadLine();
        }

        public void ShutUp(string aString)
        {            
            Console.Write("I don't Understand delegeates " + "\n" + aString);
            Console.WriteLine();
            Console.ReadLine();
        }

        //  Filter for the letter O
        public bool FindNamesThatContaintO(string aString)
        {
            bool answer = aString.Contains("o");
            return answer;
        }

        //  Filter for the letter E
        public bool FindNamesThatContaintE(string aString)
        {
            bool answer = aString.Contains("e");
            return answer;
        }
    }
}
