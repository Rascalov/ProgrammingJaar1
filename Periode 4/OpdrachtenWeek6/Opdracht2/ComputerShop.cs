using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class ComputerShop
    {
        public void AssembleMachine(ComputerFactory factory)
        {
            factory.PerformOperation();
            factory.StoreData();
            factory.Display();
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
