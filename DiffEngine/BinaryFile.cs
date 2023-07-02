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
        private byte[] byteArray;

        public BinaryFile(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            try
            {
                var len = (int)fs.Length;
                byteArray = new byte[len];

                fs.Read(byteArray, 0, len);
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

        public int Length { get { return byteArray.Length; } }
        public byte[] ByteArray { get { return byteArray; } }

        public byte GetByIndex(int index)
        {
            return byteArray[index];
        }
    }
}
