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

        //public int attackPower;
        public string weaponName;
        public int battleDamage;
        //public Weapon beamScythe;
        //public Weapon busterRifle;
        //public Weapon machineCannon;
        //public List<Weapon> weapons = new List<Weapon>();




        // Constructor (Spawner)

        public Weapon(string weaponName)
        {
            //weapons.Add(beamScythe);
            //weapons.Add(busterRifle);
            //weapons.Add(machineCannon);

            this.weaponName = weaponName;
            this.battleDamage = 50;


            //beamScythe = "50";
            //busterRifle = "75";
            //machineCannon = "60";
        }


        // Member Methods (Can Do)

        public void beamscythe()
        {
            battleDamage -= 50;
            // use of each weapon inflicts # damage on dinosaur and decreases robot energy level by 5

        }
        public void BusterRifle()
        {
            battleDamage -= 50;
        }
        public void MachineCannon()
        {
            battleDamage -= 50;
        }
        
    }
}
