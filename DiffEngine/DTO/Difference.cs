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
        public string Address { get; }
        public int StartIndex { get; }
        public int Length { get; }

        public byte[] origins;
        public byte[] modifications;
        public string originExample;
        public string modificationExample;

        public Difference(string address, int startIndex, int length)
        {
            if (startIndex < 0) throw new ArgumentOutOfRangeException(nameof(startIndex));
            if (length <= 0) throw new ArgumentOutOfRangeException(nameof(length));

            this.StartIndex = startIndex;
            this.Length = length;
        }

        /*public string Display()
        {
            return $"Изменение в {this.address}  {BitConverter.ToString(BitConverter.GetBytes(origin)).Split('-')[0]}:{BitConverter.ToString(BitConverter.GetBytes(modification)).Split('-')[0]}";
        }*/
    }
}
