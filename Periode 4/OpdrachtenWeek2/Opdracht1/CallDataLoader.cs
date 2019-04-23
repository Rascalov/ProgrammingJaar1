using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class CallDataLoader : BigDataLoader
    {
        public override void Extract()
        {
            Console.WriteLine("extracting call data...");
        }

        public override void Load()
        {
            Console.WriteLine("loading call data...");
        }

        public override void Transform()
        {
            Console.WriteLine("transforming call data...");
        }
    }
}
