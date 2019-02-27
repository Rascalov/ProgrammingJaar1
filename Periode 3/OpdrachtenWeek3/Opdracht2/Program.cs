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
            Klant klant1 = new Klant("", new DateTime(1909, 08, 01));
            klant1.printinschrijfdatum();
            
        }
    }
}
