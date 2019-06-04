using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten
{
    class CreditCardBetaling : BetaalWijze
    {
        public override void Verwerken()
        {
            Console.WriteLine("CreditCard betaling verwerken...");
        }
    }
}
