using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class HighLife : ILifeBehaviour
    {
        public bool CellShouldLive(bool livingCell, int neighbourCount)
        {
            // with 2, 3 or 6 neighbours cell will live
            if (neighbourCount == 2 || neighbourCount == 3 || neighbourCount == 6)
                return true;
            // live cell with 2 neighbours stays alive
            if (livingCell && neighbourCount == 2)
                return true;
            // dead cell
            return false;
        }
        public void ChangeLife(ConwayGameOfLife conwayGameOfLife)
        {
            conwayGameOfLife.lifeBehaviour = new Life();
        }
    }
}
