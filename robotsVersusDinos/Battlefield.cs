using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVersusDinos
{
    class Battlefield
    {
        public Fleet battleFleet;
        public Herd battleHerd;
        public bool rTurn;

        public Battlefield()
        {
            battleFleet = new Fleet();
            battleHerd = new Herd();
            rTurn = true;
        }

        public void BattleStart()
        {
            Console.WriteLine("Welcome to Robots vs. Dinosaurs!");
            System.Threading.Thread.Sleep(1000);
        }
        public void Battle(Robot robot, Dinosaur dino)
        {
            Console.Clear();
            Console.WriteLine(robot.name + " and " + dino.type + " take the arena!\n");
            System.Threading.Thread.Sleep(1000);

            while (robot.health >= 1 && dino.health >= 1)
            {
                if (rTurn == true)
                {
                    Console.WriteLine(robot.name + " takes a swing at " + dino.type + "!");
                    dino.RobotAttDmg();
                    Console.WriteLine(dino.type + " takes " + robot.weapon.weaponDamage + " damage, leaving its HP at " + dino.health + "!\n");
                    rTurn = false;
                    System.Threading.Thread.Sleep(1000);
                }
                else if (rTurn == false)
                {
                    Console.WriteLine(dino.type + " slashes at " + robot.name + "!");
                    robot.DinoAttDmg();
                    Console.WriteLine(robot.name + " takes " + dino.attackPower + " damage, leaving its HP at " + robot.health + "!\n");
                    rTurn = true;
                    System.Threading.Thread.Sleep(1000);
                }

                if (robot.health <= 0)
                {
                    battleFleet.fleet.RemoveAt(0);
                    Console.WriteLine(robot.name + " falls to " + dino.type + "!\nRemaining robots: " + battleFleet.fleet.Count + "\n");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Hit 'Enter' to continue:");
                    Console.ReadLine();
                    Console.Clear();
                    System.Threading.Thread.Sleep(1000);
                }
                else if (dino.health <= 0)
                {
                    battleHerd.herd.RemoveAt(0);
                    Console.WriteLine("\n" + dino.type + " falls to " + robot.name + "!\nRemaining dinosaurs: " + battleHerd.herd.Count + "\n");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Hit 'Enter' to continue:");
                    Console.ReadLine();
                    Console.Clear();
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

        public void Initialize()
        {
            BattleStart();
            while (battleFleet.fleet.Count >= 1 && battleHerd.herd.Count >= 1)
            {
                Battle(battleFleet.fleet[0], battleHerd.herd[0]);
            }
            if (battleFleet.fleet.Count < 1)
            {
                Console.WriteLine("All robots have fallen: DINOSAURS WIN!");
            }
            else if (battleHerd.herd.Count < 1)
            {
                Console.WriteLine("All dinosaurs have fallen: ROBOTS WIN!");
            }

        }
    }
}
