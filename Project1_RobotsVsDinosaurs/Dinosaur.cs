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
        string Type; // (p)Name
        int Health;
        double Energy;
        string AttackPower;
        string dinoName;

        

        // Constructor (Spawner)
        public Dinosaur(string dinoName, int health, string attackPower )
        {
            this.dinoName = dinoName;
            this.Health = health;
            this.AttackPower = attackPower;
        }

        // Member Methods (Can Do)

        public void DinosaurName()
        {

        }
        public void BattleDamage()
        {

        }
        public void AbilityPower()
        {

        }
        public void EnergyLevel()
        {

        }
        
    }
}
