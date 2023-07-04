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
            this.differences = _differences;
            this.comparisionResultType = comparisionResultType;
        }

        public ComparisionResultType comparisionResultType { get; set; }
        public Difference[] differences { get; }

        public string Module { get; }
        public string HardwareNumber { get; }
        public string ECU { get; }
        public string SoftwareVersion { get; }
        public string Calibration { get; }
        public string CVN { get; }
    }

    public enum ComparisionResultType
    {
        None,
        Equal,
        HaveDifferences,
        DifferentSize
    }
}
