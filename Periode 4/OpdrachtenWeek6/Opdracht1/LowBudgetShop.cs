using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class LowBudgetShop : ComputerShop, IHardDisk, IMonitor, IProcessor
    {
        public LowBudgetShop()
        {

        }
        public override void Display()
        {
            Console.WriteLine("displaying stuff very poor...");
        }

        public override void PerformOperation()
        {
            Console.WriteLine("performing operation not so quickly...");
        }

        public override void StoreData()
        {
            Console.WriteLine("storing data not so quickly...");
        }

    }
}
