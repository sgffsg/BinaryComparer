using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffEngine.DTO
{
    public class BinariesAreEqual : IBinaryComparisonResult
    {
        public string Result => "Оба файла идентичны";
    }
}
