using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Magazine : BookStoreItem
    {
        public DayOfWeek ReleaseDay { get; set; }
        public Magazine(string titel, float prijs, int itemAantal, DayOfWeek release) : base(titel, prijs, itemAantal)
        {
            ReleaseDay = release;
        }
        public override string ToString()
        {
            return $"[Magazine] {Title} - {ReleaseDay}, {Price:0.00} ({NumberOfItems}x)";
        }
    }
}
