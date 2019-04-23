using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    public abstract class BigDataLoader
    {
        public abstract void Extract();
        public abstract void Transform();
        public abstract void Load();

    }
}
