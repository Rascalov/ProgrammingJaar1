using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class MainSystem
    {
        private Logger logger;
        private SubSystem subSystem;
        public MainSystem()
        {
            logger = Logger.GetInstance();
            subSystem = new SubSystem();
        }
        public void DoSomeMainWork()
        {
            logger.Log("main", "starting");
            logger.Log("MainSystem", "doing some main work");
            subSystem.DoSomeWork();
            subSystem.DoSomeMoreWork();
            logger.Log("main", "finishing");
        }
    }
}
