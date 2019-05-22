using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Logger
    {
        private int numberOfLines;
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
    }
}
