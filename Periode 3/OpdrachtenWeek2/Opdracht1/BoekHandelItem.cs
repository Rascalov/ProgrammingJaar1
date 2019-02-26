using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    abstract class BoekHandelItem
    {
        public string titel;
        public double prijs;
        public virtual void PrintItemInfo()
        {

        }
    }
}
