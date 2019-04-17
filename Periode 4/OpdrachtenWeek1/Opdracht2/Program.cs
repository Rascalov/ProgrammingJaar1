using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            IFlyable s = new Superman();
            IFlyable a = new Airplane();
            Superman test = new Superman(); MakeFlight(test); // werkt ook!

            MakeFlight(s);
            MakeFlight(a);
        }
        void MakeFlight(IFlyable dingetje)
        {
            dingetje.LiftOff();
            dingetje.Fly();
            dingetje.Fly();
            dingetje.Fly();
            dingetje.Land();
            Console.WriteLine();
        }
    }
}
