using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_OOP
{
    class Cat //new class - class names are singular nouns, PascalCase
    {
        //creating FIELDS for class Cat
        //private means only this class itself has access to it - uses camelCase
        private string name; 
        private string furColor;
     
        private int furLength;
        private int age;

        private bool isMale;
        private bool isHungry;
        private bool isHappy;
        private bool isTired;

        //public PROPERTIES are needed to access private fields - they have the same name -uses PascalCase
        public string Name
        {
            get { return this.name; } //get the value and return it
            set { this.name = value; } //set the initial - not always required
        }
        //will need to make public for all the other private fields - these are the properties(?)
        public string FurColor
        {
            get { return this.furColor; }
            set { this.furColor = "black"; }
        } 

        public int FurLength { get; set; } //another way to do this if you aren't putting in special values
        

        public int Age
        {
            get { return this.age; }
            
        }

        public bool IsHappy
        {
            get { return this.isHappy; }
            set { this.isHappy = false; }

        }

        public bool IsTired
        {
            get { return this.isHungry; }
            set { this.isTired = false; }
        }
        
        //CONSTRUCTOR
        //set a default constructor - has the same name as our Class() and no parameters - all classes need a default
       public Cat()
        {
            this.name = "Mittens";//since this is the set default 
        }

        //we can have as many constructors as we need - method overloading
        //in the constructor we set the values of our fields 

        public Cat(string name)
        {
            this.name = name;
        }

        //public Cat(string furColor) //this doesn't work because it is the same data type as above?

            public Cat(int age)
        {
            this.age = age;
        }

        public Cat(string name, string furColor, int furLength, int age, bool isMale, bool isHungry, bool isTired)
            //these are the values that are being passed in
        {
            //these are instance variables that belong to the class
            //we can create multiple cats which will have all of these
            this.name = name;
            this.furColor = furColor;
            this.furLength = furLength;
            this.age = age;
            this.isMale = isMale;
            this.isHungry = isHungry;
            this.isTired = isTired;
           
        } 

        //Creating behavior
        public void Eat() //doesn't have the static
        {
            if(isHungry) //if the cat is hungry
            {
                this.isHungry = false; //"this" command references the instance of the object 
                //once you feed it, no longer hungry!
                Console.WriteLine(this.name + ": I'm stuffed...");
                this.isHappy = true;
            }
            else if (!isHungry) //if the cat is not (! bang symbol) hungry
            {
                Console.WriteLine(this.name +  ": I'm good - no food for me.");
            }
        }
        
        public void Run()
        {
            Console.WriteLine(this.name + ": I am running really fast!!");
            this.isHungry = true;
            Console.WriteLine(this.name + ": Now I need to eat!");
        }

        public void Purr()
        {
            if (!isHungry)
            {
                if (isHappy)
                {
                    Console.WriteLine("{0}: Purrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr", this.name);//another way to do this
                    isTired = true;
                }
            }
        }

        public void Sleep()
        {
            if (!isHungry)
            {
                if (isHappy)
                {
                    if(isTired)
                    {
                        Console.WriteLine(this.name + ": Go away. I'm sleeping now.");
                    }
                }
            }
        }
    }
}
