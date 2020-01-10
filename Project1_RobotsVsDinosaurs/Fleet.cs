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
        Robot gundamDeathScythe = new Robot(" Gundam Death Scythe");
        Robot gundamWingZero = new Robot(" Gundam Wing Zero");
        Robot gundamHeavyArms = new Robot(" Gundam Heavy Arms");
        List<Robot> robots = new List<Robot>();

               
        // Constructor (Spawner)
        public Fleet()
        {
            

            //robots.Add(new Robot());
            //robots[0] 

        }
        public void ChooseRobot()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please choose your robot");
                robots.Add(new Robot(Console.ReadLine()));

                //string input = Console.ReadLine();
                //Robot bot = new Robot(input);
                //robots.Add(bot);
            }
        }
        // Member Methods (Can Do)

    }
}
