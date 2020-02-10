using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVersusDinos
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield game = new Battlefield();
            game.Initialize();

            Console.ReadLine();
        }
    }
}
