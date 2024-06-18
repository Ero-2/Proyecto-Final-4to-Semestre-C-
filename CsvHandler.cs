using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace PROYECTO_RIOJAS
{
    internal class CsvHandler<T>
    {
        public void Save(string filePath, List<T> data)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(data);
            }
        }

        public List<T> Load(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<T>();

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return new List<T>(csv.GetRecords<T>());
            }
        }   
    }
}
