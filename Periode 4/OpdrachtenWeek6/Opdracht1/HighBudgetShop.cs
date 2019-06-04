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

        public override IMonitor CreateMonitor()
        {
            return new FastMonitor();
        }

        public override IProcessor CreateProcessor()
        {
            return new FastProcessor();
        }

        public override IHardDisk CreateHardDisk()
        {
            return new FastHardDisk();
        }
    }
}
