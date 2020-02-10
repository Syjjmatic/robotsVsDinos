using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVersusDinos
{
    class Herd
    {
        public List<Dinosaur> herd;
        public Herd()
        {
            Dinosaur dino1 = new Dinosaur();
            Dinosaur dino2 = new Dinosaur();
            Dinosaur dino3 = new Dinosaur();
            herd = new List<Dinosaur> { dino1, dino2, dino3 };

        }
    }
}
