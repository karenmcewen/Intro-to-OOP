using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_OOP
{
    class SuperHero
    {
        //class superhero should have 4 fields (like hasCape)
        //
        private string alterEgo;
        private int currentPower;
        private int maxPower;
        private int numberOfBattles;
        
        //4 properties for the fields
        public string AlterEgo
        {
            get { return this.alterEgo; } //get is required, set is optional
            set { this.alterEgo = value; }
        }
        public int CurrentPower
        {
            get { return this.currentPower; } //only want to get the current power, not set it
           
        }
        public int  MaxPower
        {
            get { return this.maxPower; }
            
        }
        public int NumberOfBattles
        {
            get { return this.numberOfBattles; }
            
        }

        //2 constructors
        public SuperHero()
        {
            this.alterEgo = "Bag Guy"; //these are the fields
            this.currentPower = 5;
            this.maxPower = 5;
            this.numberOfBattles = 0;
        }

        public SuperHero(string alterEgo)
        {
            this.alterEgo = alterEgo; //left side is field, right side is parameter
            this.currentPower = 10;
            this.maxPower = 10;
            this.numberOfBattles = 0;
        }

        //2methods - one to impact health, one for power boost
        public void FightEvil()
        {
            if(this.currentPower<2)
            {
                Console.WriteLine("I'm too weak to fight. I need sleep!");
                Sleep();
            }
            else
            {
                this.numberOfBattles += 1; //increases
                this.currentPower -= 2; //decreases
                Console.WriteLine("That was tough, but I made it out ok!");
                Console.WriteLine("My current power is {0}",this.currentPower);

            }
            
        }

        public void Sleep()
        {
            this.currentPower = maxPower;
            Console.WriteLine("I feel better than ever! My power is now {0}",this.currentPower);

        }

        public void NextLevel()
        {
            if (numberOfBattles%3 ==0)//this might not work if don't check after each level, bec. if 4 battles won't be true
            {
                this.maxPower += 10;
                this.currentPower = this.maxPower;
            }
            else
            {
                Console.WriteLine("You don't have enough battles under your belt");
            }
        }
    }
}
