using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class SimpleMP3Display : IObserver
    {
        public SimpleMP3Display(ISubject player)
        {
            player.AddObserver(this);
        }
        public void Update(Song song)
        {
            Console.WriteLine($"Simple display: {song.Bandnaam} - '{song.Titel}'");
        }
    }
}
