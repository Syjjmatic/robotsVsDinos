using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVersusDinos
{
    class Dinosaur
    {
        public string type = "T-Rex";
        public int health = 120;
        public int energyLevel = 100;
        public int attackPower = 20;
        public Dinosaur()
        {
            
        }
        public void DinoLoseHealth()
        {
            Robot robotDamage = new Robot();
            health -= robotDamage.weapon.weaponDamage;
        }
    }
}
