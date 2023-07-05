using System;
using System.Collections.Generic;
using System.Linq;
using DiffEngine.DTO;

namespace DiffEngine
{
    public class BinaryComparer
    {
        public BinaryComparer(string baseFilePath, string modFilePath)
        {
            _baseFile = new BinaryFile(baseFilePath);
            _modFile = new BinaryFile(modFilePath);
        }

        private BinaryFile _baseFile;
        private BinaryFile _modFile;

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

        /*private IEnumerable<Difference> FindDifferences2()
        {
            var len = _baseFile.Length;

            for (int ix = 0; ix < len; ix += 16)
            {
                var cnt = Math.Min(16, len - ix);
                var line1 = new byte[cnt];
                var line2 = new byte[cnt];

                Array.Copy(_baseFile.ByteArray, ix, line1, 0, cnt);
                Array.Copy(_modFile.ByteArray, ix, line2, 0, cnt);

                for (int jx = 0; jx < cnt; jx++)
                {
                    if (line1[jx] != line2[jx])
                    {
                        yield return new Difference(
                            address: ix,
                            pos: jx,
                            orig: line1[jx],
                            mod: line2[jx],
                            origExample: BitConverter.ToString(line1),
                            modExample: BitConverter.ToString(line2)
                            );
                    }
                }
            }
        }*/
    }
}
