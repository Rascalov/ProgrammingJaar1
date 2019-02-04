using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Programmer
    {
        private string naam;
        private Specialty specialiteit;

        public void Print()
        {
            Console.WriteLine($"Name: {naam}, Speciality: {specialiteit}");
        }
        public Programmer(string naam, Specialty specialiteit)
        {
            this.naam = naam;
            this.specialiteit = specialiteit;
        }
        public Programmer(string naam) :
            this(naam,Specialty.Unknown)
        {
        }
    }
}
