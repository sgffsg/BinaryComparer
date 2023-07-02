using DiffEngine.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffEngine
{
    public class BinaryComparer
    {
        private BinaryFile _baseFile;
        private BinaryFile _modFile;
        public BinaryComparer(string baseFilePath, string modFilePath) 
        {
            _baseFile = new BinaryFile(baseFilePath);
            _modFile  = new BinaryFile(modFilePath);
        }
        public /*async Task<IBinaryComparisonResult>*/IBinaryComparisonResult  PerformComparision()
        {
            return new BinariesAreEqual();
        }
    }
}
