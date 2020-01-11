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
        public Weapon beamScythe;
        public Weapon busterRifle;
        public Weapon machineCannon;
        public List<Weapon> weapons = new List<Weapon>();

        


        // Constructor (Spawner)

        public Weapon()
        {
            weapons.Add(beamScythe);
            weapons.Add(busterRifle);
            weapons.Add(machineCannon);

            //beamScythe = "50";
            //busterRifle = "75";
            //machineCannon = "60";

        }


        // Member Methods (Can Do)
        
        public void Weapons()
        {

           // use of each weapon inflicts # damage on dinosaur and decreases robot energy level by 5


        }
    }
}
