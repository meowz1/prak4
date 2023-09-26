using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budget
{
    class Coverter
    {
        public static void Ser<T>(T obj, string filename)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(desktop + "\\" + filename, json);
        }
        public static T Deser<T>(string filename)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = File.ReadAllText(desktop + "\\" + filename);
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }
    }
}
