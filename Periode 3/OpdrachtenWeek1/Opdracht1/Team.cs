using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Team
    {
        public List<Programmer> programmeurLijst;
        public Team()
        {
            programmeurLijst = new List<Programmer>();
            Programmer p1 = new Programmer("Peter", Specialty.CSharp);
            Programmer p2 = new Programmer("Meter", Specialty.HTML);
            Programmer p3 = new Programmer("Geter", Specialty.PHP);
            Programmer p4 = new Programmer("Zeter", Specialty.Java);
        }
        public void AddProgrammer(Programmer p)
        {
            programmeurLijst.Add(p);
        }
        void PrintAllTeamMembers()
        {
            
        }
    }
}
