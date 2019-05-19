using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.start();
        }
        void start()
        {
            // create a tank (and assign it to a driver)
            Tank tank = new Tank();
            tank.AssignDriver();

            // create a robot (and let it move by a person)
            RobotAdapter robot = new RobotAdapter();
            robot.AssignDriver();
            Console.WriteLine();

            // create attackers list, and add tank and robot
            List<IAttacker> attackers = new List<IAttacker>();
            //attackers.Add(robot);
            attackers.Add(tank);
            attackers.Add(robot);
            
            // process all attackers
            foreach (IAttacker attacker in attackers)
            {
                attacker.DriveForward();
                attacker.UseWeapon();
                Console.WriteLine();
            }
        }
    }
}
