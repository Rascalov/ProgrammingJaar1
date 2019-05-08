using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            BatchProcessor processor = new BatchProcessor();
            processor.AddDataloader(new CallDataLoader());
            processor.AddDataloader(new TwitterDataLoader());
            processor.AddDataloader(new SensorDataLoader());
            processor.ProcessCurrentBatches();
        }
    }
}
