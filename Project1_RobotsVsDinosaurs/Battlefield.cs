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
        public Fleet fleet = new Fleet();
        public Herd herd = new Herd();



        // Constructor (Spawner)


        // Member Methods (Can Do)
        public void GreetUser()
        {
            Console.WriteLine("Hello, would you like to play Robots vs. Dinosaurs? [Y or N]");
            string answer = Console.ReadLine().ToUpper();
            string userInput = Console.ReadLine();

            while (true)

                if (answer == "Y" || answer == "yes")
                {
                    Console.WriteLine("What is your name?");
                    string inputName = Console.ReadLine();
                    Console.WriteLine($"Hi {inputName} Would you like to be a (1) Robot or (2) Dinosaur? Please enter 1 or 2.");
                    answer = Console.ReadLine();
                    continue;
                }
                else if (answer == "n" || answer == "no")
                {
                    Console.WriteLine("Thats cool, maybe next time. ");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Pleaser enter either yes/y or no/n ");
                    GreetUser();
                }
        }

        public void playerSelection()
        {
            
            

            //if (userInput == "Robot")
            //{
            //    return;
            //}
            //else if (userInput == "Dionsaur")
            //{
            //    return;
            //}
            //else
            //{
            //    return;
            //}
        }
        public void Fight()
        {
            Robot robotChoice = fleet.ChooseRobot();
            Dinosaur dinoChoice = herd.ChooseDinosaur();
            robotChoice.Attack(herd.dinosaurs);


            //combat

        }

            

                                 
         
        
    }
}
