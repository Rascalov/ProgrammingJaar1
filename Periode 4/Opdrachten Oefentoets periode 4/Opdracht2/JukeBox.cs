using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class JukeBox
    {
        public List<IVinylSingle> Singles { get; set; }
        public IVinylSingle CurrentSingle { get; set; }

        public JukeBox(List<IVinylSingle> singles)
        {
            Singles = singles;
        }
        public void Afspelen()
        {
            CurrentSingle.Play();
        }
        public void SelectSingle(int single)
        {
            CurrentSingle = Singles[single - 1];
        }   
        public void Stoppen()
        {
            CurrentSingle.Stop();
        }
    }
}
