using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class HighBudgetShop : ComputerShop
    {
        public HighBudgetShop()
        {

        }

        public override void Display()
        {
            Console.WriteLine("displaying stuff very nice...");
        }

        public override void PerformOperation()
        {
            Console.WriteLine("performing operation very quickly...");
        }

        public override void StoreData()
        {
            Console.WriteLine("storing data very quickly...");
        }
    }
}
