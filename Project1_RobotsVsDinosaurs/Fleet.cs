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
        public string name; // of character
        Robot r2D2 = new Robot("R2D2");
        Robot johnny5 = new Robot("Johnny 5");
        Robot gundamWing = new Robot("Gundam Wing");
        List<Robot> robots = new List<Robot>();



        // Constructor (Spawner)
        public Fleet()
        {


            //robots.Add(new Robot());
            //robots[0] 

        }

        // Member Methods (Can Do)

    }
}
