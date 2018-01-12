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

                Console.WriteLine("Please type \"1\" to play as Gabby the Kitty or type \"2\" to play as Lizzie the Lizard.");
                int characterChoice = int.Parse(Console.ReadLine());

                if (characterChoice == 1)
                {
                    Console.WriteLine("You chose Gabby the Kitty!!!");
                    gabby.Menu();
                }
                else if (characterChoice == 2)
                {
                    Console.WriteLine("You chose Lizzie the Lizard!!!");
                    lizzie.Menu();
                }
        

    }
    }

}