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
        public string weapons;
        //public Weapon weapons;
        public string roboName;

        public List<Weapon> weaponsList = new List<Weapon>();


        // Constructor (Spawner)
        public Robot(string roboName, string weapons)
        {
            name = roboName;
            health = 100;
            PowerLevel = "100";
            health = 100;
            this.weapons = weapons;
            
            //weapons = new Weapon();

            //this.roboName = roboName;


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
            //dinosaurs. // robot attack decreases dinosaur health and decreases power level
        }
        
        




    }
}
