using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffEngine.DTO
{
    [Serializable]
    public class Difference
    {
        public int Address { get; }
        public byte[] BaseLine { get; }
        public byte[] ModifiedLine { get; }
        
        public Difference(int address, byte[] baseLine, byte[] modLine)
        {
            this.Address = address;
            this.BaseLine = baseLine;
            this.ModifiedLine = modLine;
        }
    }
}
