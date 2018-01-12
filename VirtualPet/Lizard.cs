using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Lizard : VirtualPet
    {

        private bool IsOverheated { get; set; }
        public int Scales { get; set; }

        public Lizard(int Scales) : base("Lizzie")
        {
            this.Scales = Scales;
            Weight = 7;
            Thirst = 15;
            Hunger = 10;
        }

        public override void WeightGain()
        {
            if (Hunger > 20 || Boredom > 30)
            {
                Weight += 2;
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
            Console.WriteLine("You dangle some fake flies over {0}'s cage and {0} chases after it", Name);
            base.Play();
            if (thirst >= 30)
            {
                IsOverheated = true;
                if (IsOverheated == true)
                {
                    Console.WriteLine("You are overheating your pet!");
                }
            }
        }

        //public override void Relief()
        //{
        //    if (thirst < 15)
        //    {
        //        needsBathroom = true;
        //        Console.WriteLine("{0} is relieved.");
        //        thirst += 2;
        //    }
        //}

        public override void Sick()
        {
            if (Hunger >= 25 && Hunger <= 35 || thirst >= 30 && thirst < 40 || tiredness >= 35 && tiredness < 45 || weight >= 15 && weight < 19)
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
            if (Hunger > 35 || thirst >= 40 || tiredness >= 45 || Weight >= 19)
            {
                Console.WriteLine("Sadly, " + Name + " has perished. You are not a very good pet owner.");
                Environment.Exit(0);
            }

        }
    }

}
