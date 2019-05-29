using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Logger
    {
        private int numberOfLines = 0;
        private static Logger uniqueInstance;

        private Logger()
        {
        }

        public static Logger GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Logger();
            }
            return uniqueInstance;
        }

        public void Log(string system, string text)
        {
            numberOfLines++;
            Console.WriteLine($"{numberOfLines} - [{system}] {text}");
        }
    }
}
