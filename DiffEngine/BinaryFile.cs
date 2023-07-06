using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DiffEngine
{
    internal class BinaryFile
    {
        public byte[] ByteArray { get; }
        public int Length { get { return ByteArray.Length; } }

        public BinaryFile(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            try
            {
                ByteArray = new byte[(int)fs.Length];
                fs.Read(ByteArray, 0, (int)fs.Length);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        public byte GetByIndex(int index)
        {
            return ByteArray[index];
        }
    }
}
