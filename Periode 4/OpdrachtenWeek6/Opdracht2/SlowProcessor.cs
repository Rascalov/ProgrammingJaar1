using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class SlowProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("performing operation not so quickly...");
        }
    }
}
