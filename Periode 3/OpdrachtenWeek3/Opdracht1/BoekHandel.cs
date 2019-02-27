using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class BoekHandel
    {
        private List<BoekHandelItem> ItemLijst = new List<BoekHandelItem>();
        
        public void VoegToe(BoekHandelItem handelItem)
        {
            ItemLijst.Add(handelItem);
        }
        public void PrintVoorraad()
        {
            double totaal = 0;
            foreach (BoekHandelItem item in ItemLijst)
            {
                item.PrintItemInfo();
                totaal += item.TotaalPrijs;
            }
            Console.WriteLine($"\nTotal Price: {totaal:0.00}");
        }

    }
}
