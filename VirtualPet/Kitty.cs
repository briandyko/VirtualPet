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

        public override void Perish()
        {
            if (Hunger >= 30 || thirst >= 30 || tiredness >= 45 || Weight > 40)
            {
                Console.WriteLine("Sadly, " + Name + " has perished. You are not a very good pet owner.");
                Environment.Exit(0);
            }

        }
    }
}
