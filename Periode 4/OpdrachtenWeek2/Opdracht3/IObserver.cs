using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    public interface IObserver
    {
        void Update(Song song);
    }
}
