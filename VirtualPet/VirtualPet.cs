using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //fields

        private string name;
        private int hunger;
        private int thirst;
        private int boredom;
        private int tiredness;
        private bool isSick;

        //Properties

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }

        public int Tiredness
        {
            get { return this.tiredness; }
            set { this.tiredness = value; }
        }

        public bool IsSick
        {
            get { return this.isSick; }
            set { this.isSick = value; }
        }

        //Constructors

        public VirtualPet()
        {

        }

        //Methods

        public void Tick()
        {
            Console.WriteLine(name);
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Thirst: " + thirst);
            Console.WriteLine("Boredom: " + boredom);
            Console.WriteLine("Tiredness: " + tiredness);
        }

        public void Feed()
        {
            hunger -= 5;
        }

        public void Drink()
        {
            thirst -= 5;
        }

        public void Sleep()
        {
            tiredness -= 5;
            if (tiredness < 0)
            {
                tiredness = 0;
            }
        }

        public void Play()
        {
            boredom -= 5;
            hunger += 5;
            thirst += 8;

            if (boredom < 0)
            {
                boredom = 0;
            }
        }

        public void GettingHungry()
        {
            if (hunger > 30)
            {
                Console.WriteLine(name + " is getting hungry, you better feed her!");
            }
            
      

        }

        public void GettingThirsty()
        {
            if (thirst > 30)
            {
                Console.WriteLine(name + "is getting very thirsty, maybe give her some water.");
            }
        }

        public void GettingTired()
        {
            if (tiredness > 20)
            {
                Console.WriteLine(name + "is looking tired, let her take a nap.");
            }
        }

        public void Sick()
        {
            if (hunger > 32 || thirst > 32 || tiredness > 22)
            {
                isSick = true;
                if (isSick == true)
                {
                    Console.WriteLine("Oh no! " + name + " is sick! You need to take better care of her.");
                }
            }
        }

        public void Perish()
        {
            if (hunger >= 40 || thirst >= 40 || tiredness >= 30)
            {
                Console.WriteLine("Sadly, " + name + "has perished. You are not a very good pet owner.");
            }

        }
    }

}