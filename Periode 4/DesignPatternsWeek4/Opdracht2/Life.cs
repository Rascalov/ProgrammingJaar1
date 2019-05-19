using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Life : ILifeBehaviour
    {
        //hier moet Evolve worden uitgevoerd en een implementatie van Cellshouldlive
        public bool CellShouldLive(bool livingCell, int neighbourCount)
        {
            // with 3 neighbour cell will live
            if (neighbourCount == 3)
                return true;
            // live cell with 2 neighbours stays alive
            if (livingCell && neighbourCount == 2)
                return true;
            // dead cell
            return false;
        }
        public void ChangeLife(ConwayGameOfLife conwayGameOfLife)
        {
           conwayGameOfLife.lifeBehaviour = new HighLife();
        }
    }
}
