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

        protected int weight;
        protected int thirst;
        private int boredom;
        protected int tiredness;
        private bool needsBathroom;
        protected bool isSick;
        protected bool perpetualMenu = true;

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

        //Methods - Action Methods

        public void Feed()
        {
            Console.WriteLine("You feed {0}", Name);
            Hunger -= 3;
            thirst++;
        }

        public void Drink()
        {
            Console.WriteLine("You give {0} some water", Name);
            thirst -= 2;
        }

        public void Sleep()
        {
            Console.WriteLine("You sing {0} peacefully to sleep.", Name);
            tiredness -= 5;
        }

        public virtual void Play()
        {
            boredom -= 2;
            Hunger += 2;
            thirst += 3;
            tiredness += 3;
            weight--;
        }

        public void Bored()
        {
            //Console.WriteLine("\nWhy don't you ever want to do anything? {0) is bored.\n", Name);
            boredom += 3;
        }

        //Methods - Status Methods

        abstract public void WeightGain();

        abstract public void Perish();

        abstract public void GettingHungry();

        abstract public void GettingThirsty();

        abstract public void Sick();

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
                thirst += 2;
            }
        }

        
      //Methods - 
           
        public void Menu()
        {
            do { 
            
            Tick();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Feed Your Pet");
            Console.WriteLine("2. Give Your Pet Water");
            Console.WriteLine("3. Play with Your Pet");
            Console.WriteLine("4. Put Your Pet to Sleep");
            Console.WriteLine("5. Do Nothing");
            Console.WriteLine("6. Exit");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 6)
            {
                perpetualMenu = false;    // to make do-while loop run
            }

            if (userChoice == 1)
            {
                Feed();

            }

            else if (userChoice == 2)
            {
                Drink();
            }

            else if (userChoice == 3)
            {
                Play();
            }

            else if (userChoice == 4)
            {
                Sleep();
            }

            else if (userChoice == 5)
            {
                Bored();
            }

        }

            while (perpetualMenu == true);

            Console.WriteLine("Sorry {0}, I have to go to work / out with friends now...See you soon!", Name);
        }

        public void Activate()
        {
            WeightGain();
            GettingHungry();
            GettingThirsty();
            GettingTired();
            Relief();
            Sick();
            Perish();
        }

        public void Tick()
        {
            Console.WriteLine();
            Console.WriteLine("Hunger: " + Hunger);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Thirst: " + thirst);
            Console.WriteLine("Boredom: " + boredom);
            Console.WriteLine("Tiredness: " + tiredness);
            Activate();
            Console.WriteLine();
        }
    }

}
