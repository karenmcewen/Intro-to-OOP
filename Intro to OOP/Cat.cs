using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_OOP
{
    class Cat //new class - class names are singular nouns, PascalCase
    {
        //creating fields for class Cat
        //private means only this class itself has access to it - uses camelCase
        private string name; 
        private string furColor;
        private int furLength;
        private int age;
        private bool isMale;
        private bool isHungry;

        //public properties are needed to access private fields - they have the same name -uses PascalCase
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

        public int FurLength
        {
            get { return this.furLength; }
            set { this.furLength = 1; }
        }

        public int Age
        {
            get { return this.age; }
            
        }

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

        public Cat(string name, string furColor, int furLength, int age, bool isMale, bool isHungry)
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

        } 

        



    }
}
