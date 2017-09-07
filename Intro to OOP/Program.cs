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
            Cat cat2 = new Cat("neko", "black", 3, 1, true, false, false);

            //Console.WriteLine(cat1.Name);
            //Console.WriteLine(cat2.Name);
            //cat1.Name = "gato";
            //Console.WriteLine(cat1.Name);
            // cat1.furColor = "red"; //this is blocked because within the definition this is private
            // Console.WriteLine(cat1.furColor); //this was never set so gives an error
            cat2.Eat();
            cat2.Run();
            cat2.Eat();
            cat2.Purr();
            cat2.Sleep();
            cat1.Run();
            cat1.Eat();
            cat1.Purr();
            cat1.Sleep();

            Dog dog1 = new Dog();
            dog1.Bark("medium");
            dog1.Cuddle();
            dog1.Run();
            dog1.Potty();

            Dog dog2 = new Dog();
            dog1.Bark("small");
            dog1.Cuddle();
            dog1.Run();
            dog1.Potty();


            //create instance for superhero
            SuperHero goodGuy = new SuperHero("Super Good Guy");
            goodGuy.FightEvil();
            goodGuy.FightEvil();
            goodGuy.FightEvil();
            goodGuy.FightEvil();
            goodGuy.FightEvil();
            goodGuy.FightEvil();
            
            goodGuy.NextLevel();
        }
    }
}
