using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffEngine.DTO
{
    public class BinariesOfDifferentSize : IBinaryComparisonResult
    {
        public string Result => "Файлы различных размеров";
    }
}
