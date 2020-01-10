using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_RobotsVsDinosaurs
{
    class Herd
    {
        // DINOSAUR OBJECTS

        // Member Variables (HAS A...)
  
        Dinosaur charizard = new Dinosaur(" Charizard ");
        Dinosaur venisaur = new Dinosaur(" Venisaur ");
        Dinosaur vileplume = new Dinosaur(" Vileplume ");
        List<Dinosaur> dinosaurs = new List<Dinosaur>();


        // Constructor (Spawner)

        public Herd()
        {

        }

        public void ChooseDinosaur()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please choose your dinosaur");
                dinosaurs.Add(new Dinosaur(Console.ReadLine()));

            }
        }



        // Member Methods (Can Do)
    }
}
