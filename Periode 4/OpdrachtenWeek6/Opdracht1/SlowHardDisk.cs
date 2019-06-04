using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class SlowHardDisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("storing data not so quickly...");
        }
    }
}
