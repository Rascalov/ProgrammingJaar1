using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Team
    {
        private List<Programmer> programmeurs;
        public Team()
        {
            programmeurs = new List<Programmer>();
        }
        public void AddProgrammer(Programmer p)
        {
            programmeurs.Add(p);
        }
        public void PrintAllTeamMembers()
        {
            foreach (Programmer p in programmeurs)
            {
                p.Print();
            }
        }
    }
}
