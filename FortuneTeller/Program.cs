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


            Console.WriteLine("Would you like to continue? Type yes. If not? type quit.");
            string answer = Console.ReadLine().ToLower(); ///.ToLower(); = not case sensitive!!

            if(answer == "yes")
            {
                Console.WriteLine("Lets continue!");
            }
            else if(answer == "quit")
            {
                Console.WriteLine("Nobody likes a quitter..Goodbye!");
                return; ///end program
            }
                  

            Console.WriteLine("Please enter your first name. ");
            string firstName = Console.ReadLine();


            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine();


            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your birth month?");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV color? If you do not know ROYGBIV, please enter Help.");
            string userColor = Console.ReadLine();
            string lowerHelp = userColor.ToLower();

            if (lowerHelp == "help")
            {
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet. Please enter a color");
                userColor = Console.ReadLine();
            }

            Console.WriteLine("Okay, how many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());
        



            //////PART 2//////


            string numberOfYears;
            if(age % 2 == 0) ///if age has no remainder then even, if does its odd
            {
                numberOfYears = "38 years";
            }
            else
            {
                numberOfYears = "43 years";
            }

            
            string location = "siblings";
            if(siblings == 0)
            {
                location = "Cancun"; ///started out with a Console.WriteLine, but no longer needed to form sentence for part 3. created a new variable.
            }
             else if(siblings == 1)
            {
                location = "Puerto Rico";
            }
            else if(siblings == 2)
            {
                location = "Hawaii";
            }
            else if(siblings == 3)
            { 
                location = "Florida";
            }
            else if(siblings > 3)
            {
                location = "Mexico";
            }
            else if(siblings < 0)
            {
                location = "a cardboard box";
            }


            string formOfTransportation = userColor;                      
            switch (userColor.ToLower())
            {
                case "red":
                    formOfTransportation = "private jet as a form of transportation.";
                    break;

                case "orange":
                    formOfTransportation = "motorcycle as a form of tranportation.";
                    break;

                case "yellow":
                    formOfTransportation = "the train as a form of transportation.";
                    break;

                case "green":
                    formOfTransportation = "fourwheeler as a form of transportation.";
                    break;

                case "blue":
                    formOfTransportation = "speed boat as a form of transportation.";
                    break;

                case "indigo":
                    formOfTransportation = "mopad as a form of transportation.";
                    break;

                case "violet":
                    formOfTransportation = "bicycle as a form of transportation.";
                    break;
            }




            string amountOfMoney = "birthMonth";
            if(birthMonth <= 4)
            {
                amountOfMoney = ("$10,000");
            }
            else if(birthMonth >= 5 && birthMonth <= 8)
            {
                amountOfMoney = "$8,000";
            }
            else if(birthMonth >= 9)
            {
                amountOfMoney = "$15,000";
            }
            else if(birthMonth < 0)
            {
                amountOfMoney = "$0.00";
            }






            //////PART 3//////


            Console.WriteLine(firstName + lastName + " will retire in " + numberOfYears + " with " + amountOfMoney + " in the bank, a vacation home in " + location + " and a " + formOfTransportation);




        }
    }
}


