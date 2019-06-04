using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Single : IVinylSingle
    {
        public string Artist { get; set; }
        public int Ranking { get; set; }
        public string Title { get; set; }

        public Single(int ranking, string title, string artist )
        {
            Ranking = ranking;
            Title = title;
            Artist = artist; 
        }
        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            Console.WriteLine($"playing single {this.ToString()}");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"'{Title}, {Artist} ({Ranking})'";
        }
    }
}
