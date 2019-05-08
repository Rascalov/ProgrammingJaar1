using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    public abstract class BigDataLoader
    {
        public void Process()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[ETL-proces started]");
            Console.ResetColor();
            Extract();
            Transform();
            Load();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[ETL-proces finished]");
            Console.ResetColor();
            Console.WriteLine();
        }
        public abstract void Extract();
        public abstract void Transform();
        public abstract void Load();

    }
}
