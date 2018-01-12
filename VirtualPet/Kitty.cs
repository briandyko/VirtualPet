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


    public Kitty(bool HasCatnip) : base("Gabby", 22)
    {
            this.HasCatnip = HasCatnip;
    }


    public override void WeightGain()
    {
        if (tiredness > 20)
        {
            Weight += 3;
        }
    }

        public override void Play()
        {
            Console.WriteLine("Sorry {0}, I have to go to work / out with friends now...See you soon!", Name);
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
    }
}
