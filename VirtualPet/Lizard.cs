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
        }

        public override void WeightGain()
        {
            if (Hunger > 20)
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


    }
}
