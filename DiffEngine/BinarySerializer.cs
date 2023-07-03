using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DiffEngine
{
    public static class BinarySerializer
    {
        public static void Serialize<T>(string path, T data)
        {
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, data);
            }
        }
        public static T Deserialize<T>(string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                T data = (T)formatter.Deserialize(stream);
                return data;
            }
        }
    }
}
