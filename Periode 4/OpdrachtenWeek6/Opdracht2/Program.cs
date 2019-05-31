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
            // Twijfelde of deze opdracht nog de Low- en Highbudget shop classes ging gebruiken, leek mij van niet. 

            Console.WriteLine("[shop creating expensive computers]");
            HighBudgetFactory highBudgetFactory = new HighBudgetFactory();
            ComputerShop hightBudgetShop = new ComputerShop();
            hightBudgetShop.AssembleMachine(highBudgetFactory);

            Console.WriteLine();

            Console.WriteLine("[shop creating cheap computers]");
            LowBudgetFactory lowBudgetFactory = new LowBudgetFactory();
            ComputerShop lowBudgetShop = new ComputerShop();
            lowBudgetShop.AssembleMachine(lowBudgetFactory);

            Console.ReadKey();
        }
    }
}
