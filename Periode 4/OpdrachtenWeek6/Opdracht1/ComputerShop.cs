using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    abstract class ComputerShop
    {
        public ComputerShop()
        {

        }

        public void AssembleMachine()
        {
            CreateProcessor().PerformOperation();
            CreateHardDisk().StoreData();
            CreateMonitor().Display();
        }
        // misschein abstract ipv virtual?
        public virtual IMonitor CreateMonitor()
        {
            return null;
        }

        public virtual IProcessor CreateProcessor()
        {
            return null;
        }

        public virtual IHardDisk CreateHardDisk()
        {
            return null;
        }
    }
}
