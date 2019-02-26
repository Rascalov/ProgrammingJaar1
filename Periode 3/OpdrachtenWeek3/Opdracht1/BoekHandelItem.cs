using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    abstract class BoekHandelItem
    {
        private string titel;
        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }
        public double prijs;
        public virtual void PrintItemInfo()
        {

        }
    }
}
