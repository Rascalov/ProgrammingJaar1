using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class BatchProcessor
    {
        private List<BigDataLoader>  bigDataLoaders = new List<BigDataLoader>();
        public void AddDataloader(BigDataLoader loader)
        {
            bigDataLoaders.Add(loader);
        }
        public void ProcessCurrentBatches()
        {
            foreach (BigDataLoader item in bigDataLoaders)
            {
                item.Process();
            }
        }

    }
}
