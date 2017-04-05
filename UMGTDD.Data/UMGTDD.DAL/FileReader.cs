using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMGTDD.DAL
{
    public static class FileReader
    {
        public static List<string> ReadFile(string path)
        {
            var result = new List<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    result.Add(reader.ReadLine());
                }
            }
            result.RemoveAt(0);
            return result;
        }
    }
}
