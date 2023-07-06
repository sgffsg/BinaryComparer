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
        public ResultType resultType { get; }
        public Difference[] differences { get; }
        public ComparisionResult(ResultType resultType)
        {
            this.resultType = resultType;
        }
        public ComparisionResult(Difference[] _differences, ResultType resultType)
        {
            differences = _differences;
            this.resultType = resultType;
        }
        
    }

    public enum ResultType
    {
        None,
        Equal,
        HaveDifferences,
        DifferentSize
    }
}
