using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_RobotsVsDinosaurs
{
    class Fleet
    {
               // ROBOTs & OBJECTs

      
        // Member Variables (HAS A...)
        public Robot gundamDeathScythe = new Robot("Gundam Death Scythe", "Scythe");
        public Robot gundamWingZero = new Robot("Gundam Wing Zero", "Buster Rifle");
        public Robot gundamHeavyArms = new Robot("Gundam Heavy Arms", "Machine Cannon");
        public List<Robot> robots = new List<Robot>();

               
        // Constructor (Spawner)
        public Fleet()
        {
            List<int> numbers = new List<int>() { 0, 1, 2, 3 };
            robots = new List<Robot>() { new Robot("Gundam Death Scythe", "100"), new Robot("Gundam Wing Zero", "100"), new Robot("Gundam Heavy Arms", "100") };

            robots.Add(gundamDeathScythe);
            robots.Add(gundamWingZero);
            robots.Add(gundamHeavyArms);

        }


        // Member Methods (Can Do)
        public Robot ChooseRobot()
        {
            Robot robot = robots[0];
            Console.WriteLine("Please choose your robot");
            

            for (int i = 0; i < robots.Count; i++)
            {
                Console.WriteLine("Press for " + i + " " + robots[i].name);  ; 
            }
            string userinput = Console.ReadLine();
            for (int i = 0; i < robots.Count; i++)
            {
                if (userinput == robots[i].name)
                {
                    return robots[i];
                }
            }
            return robot;
        }

       
        

    }
}
