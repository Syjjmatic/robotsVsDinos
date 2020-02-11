using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVersusDinos
{
    class Robot
    {
        public string name = "Gundam";
        public int health = 100;
        public int powerLevel = 100;
        public Weapon weapon = new Weapon();
        public Robot()
        {

        }
        public void DinoAttDmg()
        {
            Dinosaur dinoDamage = new Dinosaur();
            health -= dinoDamage.attackPower;
        }

    }
}
