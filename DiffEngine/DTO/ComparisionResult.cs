using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffEngine.DTO
{
    [Serializable]
    public class ComparisionResult
    {
        public ComparisionResult(ComparisionResultType comparisionResultType)
        {
            this.comparisionResultType = comparisionResultType;
        }
        public ComparisionResult(Difference[] _differences, ComparisionResultType comparisionResultType)
        {
            differences = _differences;
            this.comparisionResultType = comparisionResultType;
        }
        public ComparisionResultType comparisionResultType { get; set; }
        public Difference[] differences { get; }
    }

    public enum ComparisionResultType
    {
        None,
        Equal,
        HaveDifferences,
        DifferentSize
    }
}
