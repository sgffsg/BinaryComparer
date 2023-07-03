using DiffEngine.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DiffEngine
{
    public class BinaryComparer
    {
        private BinaryFile _baseFile;
        private BinaryFile _modFile;
        public BinaryComparer(string baseFilePath, string modFilePath) 
        {
            _baseFile = new BinaryFile(baseFilePath);
            _modFile  = new BinaryFile(modFilePath);
        }

        public ComparisionResult PerformComparision()
        {
            if (_baseFile == null) throw new ArgumentNullException(nameof(_baseFile));
            if (_modFile == null) throw new ArgumentNullException(nameof(_modFile));

            if (_baseFile.Length != _modFile.Length)
            {
                return new ComparisionResult(ComparisionResultType.DifferentSize);
            }

            var differences = FindDifferences().ToArray();
            return differences.Any()
                ? new ComparisionResult(differences, ComparisionResultType.HaveDifferences)
                : new ComparisionResult(ComparisionResultType.Equal);
        }

        private IEnumerable<Difference> FindDifferences()
        {
            return new Difference[12];
            /*int? differenceStart = null;
            for (int i = 0; i < _baseFile.Length; i++)
            {
                bool bytesAreSame = _baseFile.ByteArray[i] == _modFile.ByteArray[i];
                
                if (!bytesAreSame && !differenceStart.HasValue)
                {
                    differenceStart = i;
                }
                else if (bytesAreSame && differenceStart.HasValue)
                {
                    yield return new Difference(
                        startIndex: differenceStart.Value,
                        length: i - differenceStart.Value);
                    differenceStart = null;
                }
            }

            if (differenceStart.HasValue)
            {
                yield return new Difference(
                    startIndex: differenceStart.Value,
                    length: leftBinary.Length - differenceStart.Value);
            }*/
        }

        public void SaveComparisionResults(ComparisionResult comparisionResult, string path)
        {
            string saveFile = Path.Combine(path, "/Modules/", $"{comparisionResult.Module}.cmp");
            BinarySerializer.Serialize(saveFile, comparisionResult);
        }

        /*public void SaveComparisionResults(IBinaryComparisonResult binaryComparisonResult, string path)
        {
            if (binaryComparisonResult == (IBinaryComparisonResult) new BinariesHaveDifferences)
            string saveFile = Path.Combine(Application.ExecutablePath, "/Modules/", $"{comparisionResult.Module}.cmp");
            BinarySerializer.Serialize(saveFile, comparisionResult);
        }*/
    }
}
