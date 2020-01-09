using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_RobotsVsDinosaurs
{
    class Battlefield
    {
        // Member Variables (HAS A...)




        // Constructor (Spawner)


        // Member Methods (Can Do)
        public void GreetUser()
        {
            Console.WriteLine("Hello, would you like to play Robots vs. Dinosaurs? [Y or N]");
            string answer = Console.ReadLine().ToUpper();
            string userInput = Console.ReadLine();
            
            while (true)   

            if (answer == "Y")
            {
                    Console.WriteLine("What is your name?");
                    string inputName = Console.ReadLine();
                    Console.WriteLine("Would you like to be a Robot or Dinosaur?");
                    answer = Console.ReadLine();
                    continue;
                }
            else
            {
                    Console.WriteLine("Maybe next time");
                    break;
            }

            if (userInput == "Robot")
            {
                    return;
            }
            else if (userInput == "Dionsaur")
            {
                    return;
            }
            else
            {
                    return;
            }

                                 
            Console.ReadLine();
        }
    }
}
