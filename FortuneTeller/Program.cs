using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Fortune Teller!");

            Console.WriteLine("Please enter your first name.");
            string firstName = Console.ReadLine();


            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine();


            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            if (age < 0)
            {
                Console.WriteLine("Hmm, that does not seem humanly possible. Please try again!");

                return;
            }
            else if (age > 0)
            {
                Console.WriteLine("Awesome!");
            }


            Console.WriteLine("What is your birth month?");
            int birthMonth = int.Parse(Console.ReadLine());


            Console.WriteLine("What is your favorite ROYGBIV color? If you do not know ROYGBIV, please enter Help.");
            string userColor = Console.ReadLine();
            string lowerHelp = userColor.ToLower();

            if (lowerHelp == "help")
            {
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                userColor = Console.ReadLine();
            }

            Console.WriteLine("Okay, how many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());




            
            
            








        }
    }
}
