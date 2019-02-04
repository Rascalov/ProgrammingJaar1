using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
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
            Programmer p1 = new Programmer("Peter", Specialty.CSharp);
            Programmer p2 = new Programmer("Kevin", Specialty.Java);
            Programmer p3 = new Programmer("John", Specialty.CSharp);
            Programmer p4 = new Programmer("Susan", Specialty.Java);
            Programmer p5 = new Programmer("Emma");
            Team team1 = new Team();
            team1.AddProgrammer(p1);
            team1.AddProgrammer(p2);
            team1.AddProgrammer(p3);
            team1.AddProgrammer(p4);
            team1.AddProgrammer(p5);
            team1.PrintAllTeamMembers();
        }
    }
}
