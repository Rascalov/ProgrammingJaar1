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
        private double prijs;
        public double Prijs
        {
            get { return prijs; }
            set { prijs = value; }
        }
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public double TotaalPrijs
        {
            get { return Count * Prijs; }
        }

        public virtual void PrintItemInfo()
        {

        }
    }
}
