using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten
{
    abstract class BetaalWijze
    {
        public void Uitvoeren()
        {
            Invoeren();
            Verwerken();
            Bevestigen();
        }
        public void Invoeren()
        {
            Console.WriteLine("invoeren van gegevens...");
        }
        public abstract void Verwerken();
        public void Bevestigen()
        {
            Console.WriteLine("bevestigingsmail versturen...");
        }
        
    }
}
