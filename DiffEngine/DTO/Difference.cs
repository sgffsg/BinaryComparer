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
        public int Position { get; }
        public byte origValue { get; }
        public byte modValue { get; }
        public string originExample { get; }
        public string modificationExample { get; }

        public Difference(int address, int pos, byte orig, byte mod, string origExample, string modExample)
        {
            this.Address = address;

            this.Position = pos;
            this.origValue = orig;
            this.modValue = mod;

            this.originExample = origExample;
            this.modificationExample = modExample;
        }
    }
}
