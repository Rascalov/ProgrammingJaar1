using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class FancyMP3Display : IObserver
    {
        public FancyMP3Display(ISubject player)
        {
            player.AddObserver(this);
        }
        public void Update(Song song)
        {
            Console.WriteLine($"Fancy display: '{song.Titel}' by {song.Titel} ({song.Duur.Minute}:{song.Duur.Second})");
        }
    }
}
