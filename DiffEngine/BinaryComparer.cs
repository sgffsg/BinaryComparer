using System;
using System.Collections.Generic;
using System.Linq;
using DiffEngine.DTO;

namespace DiffEngine
{
    public class BinaryComparer
    {
        private BinaryFile _baseFile;
        private BinaryFile _modFile;

        public BinaryComparer(string baseFilePath, string modFilePath)
        {
            _baseFile = new BinaryFile(baseFilePath);
            _modFile = new BinaryFile(modFilePath);
        }

        public ComparisionResult PerformComparision()
        {
            if (_baseFile == null) throw new ArgumentNullException(nameof(_baseFile));
            if (_modFile == null) throw new ArgumentNullException(nameof(_modFile));

            if (_baseFile.Length != _modFile.Length)
            {
                return new ComparisionResult(ResultType.DifferentSize);
            }

            var differences = FindDifferences().ToArray();

            return differences.Any()
                ? new ComparisionResult(differences, ResultType.HaveDifferences)
                : new ComparisionResult(ResultType.Equal);
        }

        private IEnumerable<Difference> FindDifferences()
        {
            var len = _baseFile.Length;
            
			for (int index = 0; index < len; index += 16)
            {
                var cnt = Math.Min(16, len - index);
                var line1 = new byte[cnt];
                var line2 = new byte[cnt];

                Array.Copy(_baseFile.ByteArray, index, line1, 0, cnt);
                Array.Copy(_modFile.ByteArray, index, line2, 0, cnt);

                for (int bIndex = 0; bIndex < cnt; bIndex++)
                {
                    bool bytesAreSame = line1[bIndex] == line2[bIndex];

                    if (!bytesAreSame)
                    {
                        yield return new Difference(
                                            address: index,
                                            baseLine: line1,
                                            modLine: line2
                                         );
                        break;
                    }
                } 
            }
        }
    }
}
