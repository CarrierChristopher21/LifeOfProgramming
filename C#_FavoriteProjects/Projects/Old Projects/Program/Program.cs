using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ClassOne aClassOne = new ClassOne();
            ClassTwo aClassTwo = new ClassTwo();

            aClassOne.SaySomething("Hello World");

            aClassTwo.SayAnything(aClassOne.SaySomething);

            aClassTwo.SayAnything(aClassOne.SaySomethingElse);

            aClassTwo.SayAnything(aClassOne.ShutUp);


            List<string> names = new List<string>()
            {
                "Jane",
                "John",
                "Bob",
                "Robert",
                "Jennifer",
                "Antoinette",
                "Jason"
            };

            //  Filter for the letter O
            var answer = names.FindAll(aClassOne.FindNamesThatContaintO);
            
            foreach(var a in answer)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();

            //  Action<int,bool, double> fn = (i,b,d) => {if(b==true){d = i * d;}};

            //  Filter for the letter E
            answer = names.FindAll(aClassOne.FindNamesThatContaintE);

            foreach(var a in answer)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }

    }
}
