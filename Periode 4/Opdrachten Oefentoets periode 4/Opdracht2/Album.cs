using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Album : IVinylAlbum
    {
        public string Band { get; set; }
        public string Title { get; set; }
        public DateTime Year { get; set; }
        public Album(string title, string band, DateTime year)
        {
            Title = title;
            Band = band;
            Year = year;
        }
        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            Console.WriteLine($"playing album {this.ToString()}");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"'{Title}, {Band} ({Year.Year})'";
        }
    }
}
