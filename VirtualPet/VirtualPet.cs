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
        private int weight;
        private int hunger;
        private int thirst;
        private int boredom;
        private int tiredness;
        private bool needsBathroom;
        private bool isSick;

        //Properties

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
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

        public bool NeedsBathroom
        {
            get { return this.needsBathroom; }
            set { this.needsBathroom = value; }
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
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Thirst: " + thirst);
            Console.WriteLine("Boredom: " + boredom);
            Console.WriteLine("Tiredness: " + tiredness);
        }

        public void Feed()
        {
            Console.WriteLine("\nYou feed Gabby.\n");
            hunger -= 5;
            thirst++;
        }

        public void Drink()
        {
            Console.WriteLine("\nYou give Gabby some water.\n");
            thirst -= 5;
        }

        public void Sleep()
        {
            Console.WriteLine("\nYou sing Gabby peacefully to sleep.\n");
            tiredness -= 5;
        }

        public void Play()
        {
            Console.WriteLine("\nYou use the laser pointer and Gabby runs around the room after it.\n");
            boredom -= 2;
            hunger += 2;
            thirst += 3;
            tiredness += 3;
            weight--;

        }

        public void WeightGain()
        {
            if (hunger > 30 || boredom > 30)
            {
                weight += 2;
            }
        }

        public void Bored()
        {
            Console.WriteLine("\nWhy don't you ever want to do anything? Gabby is bored.\n");
            boredom += 3;
        }

        public void GettingHungry()
        {
            if (hunger > 30 && hunger < 40)
            {
                Console.WriteLine(name + " is getting hungry, you better feed her!");
            }
            
        }

        public void GettingThirsty()
        {
            if (thirst > 30 && hunger < 40)
            {
                Console.WriteLine(name + " is getting very thirsty, maybe give her some water.");
            }
        }

        public void GettingTired()
        {
            if (tiredness > 25)
            {
                Console.WriteLine(name + " is looking tired, let her take a nap.");
            }
        }


        public void Relief()
        {
            if (thirst < 15)
            {
                needsBathroom = true;
                Console.WriteLine("Gabby needs you to open the door so she can get to her litter box.");
                thirst = 20;
            }
        }

        public void Sick()
        {
            if (hunger >= 40 && hunger < 50 || thirst >= 40 && thirst < 50 || tiredness >= 35 && tiredness < 45 || weight >= 13 && weight < 16)
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
            if (hunger >= 50 || thirst >= 50 || tiredness >= 45 || weight > 16)
            {
                Console.WriteLine("Sadly, " + name + " has perished. You are not a very good pet owner.");
            }

        }
    }

}
