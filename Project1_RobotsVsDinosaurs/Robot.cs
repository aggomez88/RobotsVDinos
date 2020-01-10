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
        public string Name;
        public int Health;
        public string PowerLevel;
        public Weapon weapon;
        public string roboName;


        // Constructor (Spawner)
        public Robot(string roboName, int health, string PowerLevel )
        {
            Name = "Choose your robot...";
            Health = 100;
            PowerLevel = "100";
            


            //this.roboName = roboName;
            //weapon = new Weapon();

        }

        // Member Methods (Can Do)
        
        public void RoboName()
        {
            Console.WriteLine("Please choose your Robot...");
            Name = Console.ReadLine();
        }
        public void BattleDamage()
        {

        }
        public void Power()
        {

        }
        public void WeaponChoice()
        {
            Console.WriteLine("Which weapon would you like to use...");
            weapon = Console.ReadLine();
        }





    }
}
