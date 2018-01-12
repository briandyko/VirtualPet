using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VirtualPet
{
    class Kitty : VirtualPet
    {
        protected bool HasCatnip { get; set; }


        public Kitty(bool HasCatnip) : base("Gabby")
        {
            this.HasCatnip = HasCatnip;
            weight = 22;
            Thirst = 5;
            Hunger = 8;
        }

        public override void WeightGain()
        {
            if (tiredness > 20 || Boredom > 10)
            {
                Weight += 3;
            }
        }

        public override void GettingHungry()
        {
            if (Hunger > 30 && Hunger < 40)
            {
                Console.WriteLine(Name + " is getting hungry, you better feed her!");
            }

        }

        public override void GettingThirsty()
        {
            if (thirst > 30 && Hunger < 40)
            {
                Console.WriteLine(Name + " is getting very thirsty, maybe give her some water.");
            }
        }

        public override void Play()
        {
            if (HasCatnip == false)
            {
                base.Play();
            }
            else
            {
                Console.WriteLine("Watch out, {0} is crazy right now!!!", Name);
                Boredom -= 7;
                Hunger += 9;
                Thirst += 10;
            }
        }

        //public override void Relief()
        //{
        //    if (thirst < 15)
        //    {
        //        needsBathroom = true;
        //        Console.WriteLine("{0} needs you to open the door so she can get to her litter box.");
        //        thirst += 2;
        //    }
        //}

        public override void Sick()
        {
            if (Hunger >= 30 && Hunger < 40 || thirst >= 30 && thirst < 40 || tiredness >= 35 && tiredness < 45 || weight >= 37 && weight < 48)
            {
                isSick = true;
                if (isSick == true)
                {
                    Console.WriteLine("Oh no! " + Name + " is sick! You need to take better care of her.");
                }
            }
        }

        public override void Perish()
        {
            if (Hunger >= 40 || thirst >= 40 || tiredness >= 45 || Weight >= 48)
            {
                Console.WriteLine("Sadly, " + Name + " has perished. You are not a very good pet owner.");
                Environment.Exit(0);
            }

        }
    }
}
