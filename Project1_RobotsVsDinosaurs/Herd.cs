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
        Dinosaur dinoOne = new Dinosaur("Barney");
       

        // Member Variables (HAS A...)
  
        public Dinosaur charizard = new Dinosaur(" Charizard ");
        public Dinosaur venisaur = new Dinosaur(" Venisaur ");
        public Dinosaur vileplume = new Dinosaur(" Vileplume ");
        public List<Dinosaur> dinosaurs = new List<Dinosaur>();


        // Constructor (Spawner)

        public Herd()
        {
            dinosaurs.Add(charizard);
            dinosaurs.Add(venisaur);
            dinosaurs.Add(vileplume);

        }

        public Dinosaur ChooseDinosaur()
        {
            Dinosaur dinosaur = dinosaurs[0];
            Console.WriteLine("Please choose your dinosaur");

            for (int i = 0; i < dinosaurs.Count; i++)
            {
                Console.WriteLine(dinosaurs[i].name);
            }
            string userinput = Console.ReadLine();
            for (int i = 0; i < dinosaurs.Count; i++)
            {
                if (userinput == dinosaurs[i].name)
                {
                    return dinosaurs[i];
                }
            }
            return dinosaur;



            //for (int i = 0; i < dinosaurs.Count; i++)
            //{
            //    Console.WriteLine(dinosaurs[i].);


            //}
            //dinosaurs.Add(new Dinosaur(Console.ReadLine()));
        }



        // Member Methods (Can Do)
    }
}
