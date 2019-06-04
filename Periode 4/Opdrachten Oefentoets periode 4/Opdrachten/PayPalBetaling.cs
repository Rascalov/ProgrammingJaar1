using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten
{
    class PayPalBetaling : BetaalWijze
    {
        public override void Verwerken()
        {
            Console.WriteLine("PayPal betaling verwerken...");
        }
    }
}
