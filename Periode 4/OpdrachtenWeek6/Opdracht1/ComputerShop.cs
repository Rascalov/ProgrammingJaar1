using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    abstract class ComputerShop : IProcessor, IMonitor, IHardDisk
    {
        public ComputerShop()
        {

        }

        public void AssembleMachine()
        {
            PerformOperation();
            StoreData();
            Display();
        }
        public virtual void Display()
        {
        }

        public virtual void PerformOperation()
        {
        }

        public virtual void StoreData()
        {
        }
    }
}
