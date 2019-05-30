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
            Console.WriteLine("[shop creating expensive computers]");
            HighBudgetShop highBudgetShop = new HighBudgetShop();
            highBudgetShop.AssembleMachine();

            Console.WriteLine();

            Console.WriteLine("[shop creating cheap computers]");
            LowBudgetShop lowBudgetShop = new LowBudgetShop();
            lowBudgetShop.AssembleMachine();

            Console.ReadKey();
        }
    }
}
