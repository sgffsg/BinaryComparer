using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiffEngine;

namespace Demo
{
    internal class Program
    {
        public static string baseFile = "../../../Test/Base.bin";
        public static string modificatedFile = "../../../Test/Remade.bin";
        public static string outFile = "../../../Test/out.txt";

        static void Main(string[] args)
        {
            BinaryFile file1 = new BinaryFile(baseFile);
            CompareFiles(baseFile, modificatedFile);
            //ReadFile(baseFile);
            Console.ReadKey();
        }
        const int bufferSize = 2048;

        public static bool CompareFiles(string fileName1, string fileName2)
        {
            FileInfo info1 = new FileInfo(fileName1);
            FileInfo info2 = new FileInfo(fileName2);
            bool same = info1.Length == info2.Length;
            if (same)
            {
                using (FileStream fs1 = info1.OpenRead())
                using (FileStream fs2 = info2.OpenRead())
                using (BufferedStream bs1 = new BufferedStream(fs1))
                using (BufferedStream bs2 = new BufferedStream(fs2))
                {
                    for (long i = 0; i < info1.Length; i++)
                    {
                        int f = bs1.ReadByte();
                        int s = bs2.ReadByte();
                        if (f != s)
                        {
                            Console.Write($"{f} {s}");
                            same = false;
                            break;
                        }
                    }
                }
            }

            return same;
        }

        public static void ReadFile(string inputFile)
        {
           

            var fs = new FileStream(inputFile, FileMode.Open);
            var len = (int)fs.Length;
            var bits = new byte[len];
            fs.Read(bits, 0, len);
            // Dump 16 bytes per line
            for (int ix = 0; ix < len; ix += 16)
            {
                var cnt = Math.Min(16, len - ix);
                var line = new byte[cnt];
                Array.Copy(bits, ix, line, 0, cnt);
                // Write address + hex + ascii
                Console.Write("{0:X8}  ", ix);
                Console.Write(BitConverter.ToString(line));
                Console.WriteLine("  ");

                // Convert non-ascii characters to .
                /*for (int jx = 0; jx < cnt; ++jx)
                    if (line[jx] < 0x20 || line[jx] > 0x7f) 
                        line[jx] = (byte)'.';
                Console.WriteLine(Encoding.ASCII.GetString(line));*/
            }

            //Console.ReadLine();
        }
    }
}
