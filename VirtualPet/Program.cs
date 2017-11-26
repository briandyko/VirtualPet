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
            gabby.Weight = 15;
            gabby.Hunger = 25;
            gabby.Thirst = 25;
            gabby.Boredom = 0;
            gabby.Tiredness = 0;
            gabby.IsSick = false;

            bool perpetualMenu = true;

            

            do
            {
                // User Menu

                gabby.Tick();
                Console.WriteLine();

                Console.WriteLine("Now that you are the proud owner of " + gabby.Name + " What do you want to do?");
                Console.WriteLine("1. Feed Gabby");
                Console.WriteLine("2. Give Gabby Water");
                Console.WriteLine("3. Play with Gabby");
                Console.WriteLine("4. Put Gabby to Sleep");
                Console.WriteLine("5. Do Nothing");
                Console.WriteLine("6. Exit");
                int userChoice = int.Parse(Console.ReadLine());

                if (userChoice == 6)
                {
                    perpetualMenu = false;    // to make do-while loop run
                }

                if(userChoice == 1)
                {
                    gabby.Feed();
                    gabby.WeightGain();
                }

                else if(userChoice == 2)
                {
                    gabby.Drink();
                }

                else if (userChoice == 3)
                {
                    gabby.Play();
                }

                else if (userChoice == 4)
                {
                    gabby.Sleep();
                }

                else if (userChoice == 5)
                {
                    gabby.GettingBored();
                }

            }

            while (perpetualMenu == true);  // ends do-while loop for program running until "exit"

     

        Console.WriteLine("Sorry Gabby, I have to go to work / out with friends now...See you soon!");

    }
    }

}