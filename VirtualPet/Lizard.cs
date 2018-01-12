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

        public override void Perish()
        {
            if (Hunger >= 30 || thirst >= 50 || tiredness >= 45 || Weight > 16)
            {
                Console.WriteLine("Sadly, " + Name + " has perished. You are not a very good pet owner.");
                Environment.Exit(0);
            }

        }
    }

    }
