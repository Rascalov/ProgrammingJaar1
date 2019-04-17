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
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            Pencil p = new Pencil(20);
            Console.Write("Enter a word: ");
            string input = Console.ReadLine();
            while (input != "stop")
            {
                p.Write(input);
                Console.Write("Enter a word: ");
                input = Console.ReadLine();
            }
        }
    }
}
