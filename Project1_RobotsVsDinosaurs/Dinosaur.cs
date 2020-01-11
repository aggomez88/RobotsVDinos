using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_RobotsVsDinosaurs
{
    class Dinosaur
    {
        // Dinosaurs & Objects/ Abilities

        // Member Variables (HAS A...)
       public string name;
       public int health;
       public double energy;
       public string attackPower;
       public string dinoName;
       public string attackAbility;
        

        // Constructor (Spawner)
        public Dinosaur(string dinoName)
        {
            
            name = dinoName;
            health = 100;
            attackAbility = attackPower;
        }

        // Member Methods (Can Do)

        public void DinoName()
        {
            Console.WriteLine("Please choose your dinosaur...");
            name = Console.ReadLine();
        }

        public void DinosaurName()
        {

        }
        public void BattleDamage()
        {

        }
        public void AbilityPower()
        {
            //attackAbility. // attack ability drains energy and each attack ability has different level of power that inflicts specific damage

        }
        public void EnergyLevel()
        {

        }

        //public void Attack(target)
        //{
        //    target.health -= attackPower;
        //}
        
    }
}
