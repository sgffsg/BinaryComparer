using DiffEngine.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            var differences = FindDifferences2().ToArray();
            /*foreach (var diff in differences)
            {
                string startHexValue = diff.StartIndex.ToString("X");
                string endHexValue = diff.Length.ToString("X");
                MessageBox.Show($"START:{startHexValue} END:{endHexValue}");
            }*/

            return differences.Any()
                ? new ComparisionResult(differences, ComparisionResultType.HaveDifferences)
                : new ComparisionResult(ComparisionResultType.Equal);
        }

        private IEnumerable<Difference> FindDifferences()
        {
            
            int? differenceStart = null;
            for (int i = 0; i < _baseFile.Length; i++)
            {
                bool bytesAreSame = _baseFile.ByteArray[i] == _modFile.ByteArray[i];

                if (!bytesAreSame && !differenceStart.HasValue)
                {
                    differenceStart = i;
                }
                else if (bytesAreSame && differenceStart.HasValue)
                {
                    MessageBox.Show($"LINE:{i:X8} START:{differenceStart.Value:X} END:{i- differenceStart.Value}");
                    //MessageBox.Show($"START:{startHexValue} END:{endHexValue}");
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
                    length: _baseFile.Length - differenceStart.Value);
            }
        }

        private IEnumerable<Difference> FindDifferences2()
        {
            var len = _baseFile.Length;
            int? differenceStart = null;

            for (int ix = 0; ix < len; ix += 16)
            {
                var size = Math.Min(16, len - ix);
                var line1 = new byte[size];
                var line2 = new byte[size];

                Array.Copy(_baseFile.ByteArray, ix, line1, 0, size);
                Array.Copy(_modFile.ByteArray, ix, line2, 0, size);

                List<byte> origins = new List<byte>();
                List<byte> modifications = new List<byte>();

                for (int jx = 0; jx < size; jx++)
                {
                    bool bytesAreSame = line1[jx] == line2[jx];
                    bool isEnd = jx == size - 1;
                    

                    if (!bytesAreSame)
                    {
                        if (!differenceStart.HasValue)
                            differenceStart = jx;

                        origins.Add(line1[jx]);
                        modifications.Add(line2[jx]);
                    }
                    
                    else if (bytesAreSame && differenceStart.HasValue)
                    {
                        //MessageBox.Show($"LINE:{ix:X8} START:{differenceStart.Value:X} END:{jx}");
                        
                        yield return new Difference(
                            address: ix.ToString("X8"),
                            startIndex: differenceStart.Value,
                            length: Math.Abs(jx - differenceStart.Value),
                            origins: origins,
                            modifications: modifications,
                            origExample: BitConverter.ToString(line1),
                            modExample: BitConverter.ToString(line2)
                            );
                        differenceStart = null;
                    }
                }

                if (differenceStart.HasValue)
                {
                    //MessageBox.Show($"LINE:{ix:X8} START:{differenceStart.Value:X} END:{size - 1:X}");
                    /*yield return new Difference(
                        startIndex: differenceStart.Value,
                        length: size - 1);*/
                    yield return new Difference(
                            address: ix.ToString("X8"),
                            startIndex: differenceStart.Value,
                            length: Math.Abs(15 - differenceStart.Value),
                            origins: origins,
                            modifications: modifications,
                            origExample: BitConverter.ToString(line1),
                            modExample: BitConverter.ToString(line2)
                            );
                }
            }
        }

        /*private IEnumerable<Difference> FindDifferencesa()
        {
            var len = _baseFile.Length;
            int? differenceStart = null;

            for (int ix = 0; ix < len; ix += 16)
            {
                var size = Math.Min(16, len - ix);
                var line1 = new byte[size];
                var line2 = new byte[size];

                Array.Copy(_baseFile.ByteArray, ix, line1, 0, size);
                Array.Copy(_modFile.ByteArray, ix, line2, 0, size);

                for (int jx = 0; jx < size; jx++)
                {
                    bool bytesAreSame = line1[jx] == line2[jx];

                    List<int> origins = new List<int>();
                    List<int> modifications = new List<int>();

                    if (!bytesAreSame && !differenceStart.HasValue)
                    {
                        differenceStart = jx;
                    }

                    else if (bytesAreSame && differenceStart.HasValue)
                    {
                        MessageBox.Show($"LINE:{ix:X8} START:{differenceStart.Value:X} END:{jx - 1}");

                        yield return new Difference(
                            startIndex: differenceStart.Value,
                            length: Math.Abs(jx - differenceStart.Value));
                        differenceStart = null;
                    }
                    else if (jx == size - 1 && bytesAreSame && differenceStart.HasValue)
                    {
                        MessageBox.Show($"LINE:{ix:X8} START:{differenceStart.Value:X} END:{jx:X}");

                        yield return new Difference(
                            startIndex: differenceStart.Value,
                            length: Math.Abs(jx - differenceStart.Value));
                        differenceStart = null;
                    }
                }

                if (differenceStart.HasValue)
                {
                    yield return new Difference(
                        startIndex: differenceStart.Value,
                        length: _baseFile.Length - differenceStart.Value);
                }
            }
        }*/

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
