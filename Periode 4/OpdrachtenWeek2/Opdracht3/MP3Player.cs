using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class MP3Player : ISubject
    {
        List<Song> songlist = new List<Song> { new Song("Wish You Were Here", "Pink Floyd", new DateTime(1,1,1,1,3,12,0)), new Song("Wish You Were NOT Here", "Tim Sanou", new DateTime(1, 1, 1, 1, 3, 12, 0)), new Song("Wish You Were ECHT Here", "Jari Sanou", new DateTime(1, 1, 1, 1, 3, 12, 0)) };
        List<IObserver> observers = new List<IObserver>();
        public Song CurrentSong { get; private set; }
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NextSong()
        {
            Random r = new Random();
            CurrentSong = songlist[r.Next(0, songlist.Count)];
            foreach (IObserver observer in observers)
            {
                observer.Update(CurrentSong);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
