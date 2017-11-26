using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet gabby = new VirtualPet();
            gabby.Name = "Gabby the Cat";
            gabby.Hunger = 25;
            gabby.Thirst = 25;
            gabby.Boredom = 0;
            gabby.Tiredness = 0;
            gabby.IsSick = false;

            //Console.WriteLine(gabby.Name + " the Cat");

            gabby.Feed();
            gabby.Feed();
            gabby.Drink();
            gabby.Sleep();
            gabby.Feed();
            gabby.Play();

            gabby.Tick();

          
        }
    }
}
