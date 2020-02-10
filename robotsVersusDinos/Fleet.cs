using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVersusDinos
{
    class Fleet
    {
        public List<Robot> fleet;
        public Fleet()
        {
            Robot robot1 = new Robot();
            Robot robot2 = new Robot();
            Robot robot3 = new Robot();
            fleet = new List<Robot> { robot1, robot2, robot3 };

        }
    }
}
