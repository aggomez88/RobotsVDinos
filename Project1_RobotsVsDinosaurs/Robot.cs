using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_RobotsVsDinosaurs
{
    class Robot
    {


        // Member Variables (HAS A...)
        public string name;
        public int health;
        public string PowerLevel;
        public Weapon weapon;
        public string roboName;
        List<Weapon> weapons = new List<Weapon>();


        // Constructor (Spawner)
        public Robot(string roboName)
        {
            name = roboName;
            health = 100;
            PowerLevel = "100";
            health = 100;
            

            //this.roboName = roboName;
            //weapon = new Weapon();

        }

        // Member Methods (Can Do)
        
        public void RoboName()
        {
            Console.WriteLine("Please choose your Robot...");
            name = Console.ReadLine();
        }
        public void BattleDamage()
        {

        }
        public void Power()
        {

        }
        public void Attack(List<Dinosaur> dinosaurs)
        {
            dinosaurs. // robot attack decreases dinosaur health and decreases power level
        }




    }
}
