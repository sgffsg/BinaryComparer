using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffEngine.DTO
{
    public class BinariesHaveDifferences : IBinaryComparisonResult
    {
        public BinariesHaveDifferences(Difference[] _differences)
        {
            differences = _differences;
        }
        public Difference[] differences;
        public string Result => "Файлы различаются";
    }
}
