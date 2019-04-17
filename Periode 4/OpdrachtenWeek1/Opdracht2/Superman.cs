using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Superman : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("superman is flying around");
        }

        public void Land()
        {
            Console.WriteLine("superman is landing");
        }

        public void LiftOff()
        {
            Console.WriteLine("superman is lifting off");
        }
    }
}
