using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffEngine.DTO
{
    public class BinariesHaveDifferences : IBinaryComparisonResult
    {
        public List<Difference> differences;
        public BinariesHaveDifferences(List<Difference> _differences)
        {
            differences = _differences;
        }
        public string Result => "Файлы различаются";
    }

    public class Difference
    {
        private string address;
        private byte origin;
        private byte modification;

        private string originExample;
        private string modificationExample;

        public Difference(string _address, byte _origin, byte _modification, string _originExample, string _modificationExample)
        {
            this.address = _address;
            this.origin = _origin;
            this.modification = _modification;
            this.originExample = _originExample;
            this.modificationExample = _modificationExample;
        }

        public string Address { get { return address; } }
        public byte Origin { get { return origin; } }
        public byte Modification { get { return modification; } }
        public string OriginExample { get { return originExample; } }
        public string ModificationExample { get { return modificationExample; } }

        public string Display()
        {
            return $"Изменение в {this.address}  {BitConverter.ToString(BitConverter.GetBytes(origin)).Split('-')[0]}:{BitConverter.ToString(BitConverter.GetBytes(modification)).Split('-')[0]}";
        }
    }
}
