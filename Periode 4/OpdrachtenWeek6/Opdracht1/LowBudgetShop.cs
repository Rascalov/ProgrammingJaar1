using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class LowBudgetShop : ComputerShop
    {
        public LowBudgetShop()
        {

        }
        public override IMonitor CreateMonitor()
        {
            return new SlowMonitor();
        }

        public override IProcessor CreateProcessor()
        {
            return new SlowProcessor();
        }

        public override IHardDisk CreateHardDisk()
        {
            return new SlowHardDisk();
        }

    }
}
