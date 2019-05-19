using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class Tank : IAttacker
    {

        public void AssignDriver()
        {
            Console.WriteLine("Frank is steering the tank");
        }

        public void DriveForward()
        {
            Console.WriteLine("Tank moves 3 positions forward");
        }

        public void UseWeapon()
        {
            Console.WriteLine("Tank causes damage");
        }
    }
}
