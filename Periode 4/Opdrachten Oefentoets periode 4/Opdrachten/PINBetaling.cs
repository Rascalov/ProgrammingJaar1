using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten
{
    class PINBetaling : BetaalWijze
    {
        public override void Verwerken()
        {
            Console.WriteLine("Pin betaling verwerken...");       
        }
    }
}
