using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace PROYECTO_RIOJAS
{
    internal class JsonHandler<T>
    {
        public void Save(string filePath, List<T> data)
        {
            File.WriteAllText(filePath, JsonConvert.SerializeObject(data, Formatting.Indented));
        }

        public List<T> Load(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<T>();

            return JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(filePath));
        }
    }
}
