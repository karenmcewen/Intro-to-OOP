using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            Cat cat2 = new Cat("neko", "black", 3, 1, true, true);

            Console.WriteLine(cat1.Name);
            Console.WriteLine(cat2.Name);
            cat1.Name = "gato";
            Console.WriteLine(cat1.Name);
           // cat1.furColor = "red"; //this is blocked because within the definition this is private
           // Console.WriteLine(cat1.furColor); //this was never set so gives an error

        }
    }
}
