using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    abstract class VirtualPet
    {
        //fields

        private int weight;
        protected int thirst;
        private int boredom;
        protected int tiredness;
        private bool needsBathroom;
        private bool isSick;

        //Properties

        public string Name { get; set; }
        public int Hunger { get; set; }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
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

        public VirtualPet(string Name)
        {
            this.Name = Name;
        }

        public VirtualPet(string Name, int weight)
        {
            this.Name = Name;
            this.Weight = weight;
        }

        //Methods

        public void Tick()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Hunger: " + Hunger);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Thirst: " + thirst);
            Console.WriteLine("Boredom: " + boredom);
            Console.WriteLine("Tiredness: " + tiredness);
        }

        public void Feed()
        {
            Console.WriteLine("\nYou feed your Pet.\n");
            Hunger -= 5;
            thirst++;
        }

        public void Drink()
        {
            Console.WriteLine("\nYou give " + Name + " some water.\n");
            thirst -= 5;
        }

        public void Sleep()
        {
            Console.WriteLine("\nYou sing {0} peacefully to sleep.\n", Name);
            tiredness -= 5;
        }

        public virtual void Play()
        {
            Console.WriteLine("\nYou use the laser pointer and your pet runs around the room after it.\n");
            boredom -= 2;
            Hunger += 2;
            thirst += 3;
            tiredness += 3;
            weight--;

        }

        abstract public void WeightGain();
      

        public void Bored()
        {
            Console.WriteLine("\nWhy don't you ever want to do anything? {0) is bored.\n", Name);
            boredom += 3;
        }

        public void GettingHungry()
        {
            if (Hunger > 30 && Hunger < 40)
            {
                Console.WriteLine(Name + " is getting hungry, you better feed her!");
            }
            
        }

        public void GettingThirsty()
        {
            if (thirst > 30 && Hunger < 40)
            {
                Console.WriteLine(Name + " is getting very thirsty, maybe give her some water.");
            }
        }

        public void GettingTired()
        {
            if (tiredness > 25)
            {
                Console.WriteLine(Name + " is looking tired, let her take a nap.");
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
            if (Hunger >= 40 && Hunger < 50 || thirst >= 40 && thirst < 50 || tiredness >= 35 && tiredness < 45 || weight >= 13 && weight < 16)
            {
                isSick = true;
                if (isSick == true)
                {
                    Console.WriteLine("Oh no! " + Name + " is sick! You need to take better care of her.");
                }
            }
        }

        public void Perish()
        {
            if (Hunger >= 50 || thirst >= 50 || tiredness >= 45 || weight > 16)
            {
                Console.WriteLine("Sadly, " + Name + " has perished. You are not a very good pet owner.");
            }

        }
    }

}
