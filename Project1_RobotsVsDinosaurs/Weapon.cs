using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_RobotsVsDinosaurs
{
    class Weapon
    {
        // Member Variables (HAS A...)
        public int attackPower;
        public string weaponType;
        public string beamScythe;
        public string busterRifle;
        public string machineCannon;


        // Constructor (Spawner)

        public Weapon()
        {
            beamScythe = "50";
            busterRifle = "75";
            machineCannon = "60";
        }


        // Member Methods (Can Do)
        
        public void Weapons()
        {
           // use of beam scythe inflicts 50 damage on dinosaur and decreases robot energy level by 5

        }
    }
}
