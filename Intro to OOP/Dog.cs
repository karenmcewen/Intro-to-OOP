using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_OOP
{
    class Dog
    {
        //Do It - Create a class Dog
        //The class Dog should have the following fields:
        //hairLength, height, runningSpeed, weight
        //The class should have the following behaviors:
        //Run(), Bark(), Potty(), Cuddle()

        //creating FIELDS for class Dog
        //private means only this class itself has access to it - uses camelCase
        private string name;
        private string furColor;
        private string size;
        private int hairLength;
        private int height;
        private int runningSpeed;
        private int weight;

        //public PROPERTIES are needed to access private fields - they have the same name -uses PascalCase
        public string Name
        {
            get { return this.name; } //get the value and return it
            set { this.name = value; } //set the initial - not always required
        }
     
        public string FurColor
        {
            get { return this.furColor; }
            set { this.furColor = value; }
        }
        public string Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public int HairLength { get; set; }
        public int Height { get; set; }
        public int RunningSpeed { get; set; }
        public int Weight { get; set; }

        //CONSTRUCTOR
        //set a default constructor - has the same name as our Class() and no parameters - all classes need a default
        public Dog()
        {
            this.name = "Fido";//since this is the set default 
        }

        public Dog(string size)
        {
            this.size = size;
        }

        public Dog(string name, string furColor, string size, int hairLength, int height, int runningSpeed, int weight)
        {
            this.name = name;
            this.furColor = furColor;
            this.size = size;
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

        //BEHAVIORS
        public void Run()
        {
            Console.WriteLine("I like to run!");
        }
        public void Bark(string size)
        {
            Console.WriteLine(size);
            if (size == "small")
            {
                Console.WriteLine("Yap yap yap yap");
            }
            else if (size == "medium")
            {
                Console.WriteLine("Bow wow... bow wow...");
            }
           else
            {
                Console.WriteLine("WOOF! WOOF!");
            }
        }
        public void Potty()
        {
            Console.WriteLine("Time for walkies!!!");
        }
        public void Cuddle()
        {
            Console.WriteLine("Please rub my belly");
        }
    }
}
