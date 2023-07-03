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

        public ComparisionResultType comparisionResultType;
        public Difference[] differences { get; set; }

        public string Module;
        public string HardwareNumber;
        public string ECU;
        public string SoftwareVersion;
        public string Calibration;
        public string CVN;
    }

    public enum ComparisionResultType
    {
        None,
        Equal,
        HaveDifferences,
        DifferentSize
    }
}
