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

            Lizard lizzie = new Lizard(2000);

            Kitty gabby = new Kitty(true);

        
            bool perpetualMenu = true;

            do
            {
                // User Menu

                lizzie.Tick();
                Console.WriteLine(gabby.Name + " " + gabby.Weight);

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

                if(userChoice == 1)
                {
                    lizzie.Feed();
                    
                }

                else if(userChoice == 2)
                {
                    lizzie.Drink();
                }

                else if (userChoice == 3)
                {
                    lizzie.Play();
                }

                else if (userChoice == 4)
                {
                    lizzie.Sleep();
                }

                else if (userChoice == 5)
                {
                    lizzie.Bored();
                }

            }

            while (perpetualMenu == true);  // ends do-while loop for program running until "exit"

     

        Console.WriteLine("Sorry Gabby, I have to go to work / out with friends now...See you soon!");

    }
    }

}