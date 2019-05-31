using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    abstract class ComputerFactory : IProcessor, IMonitor, IHardDisk
    {
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
