using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class FileWorker
    {
        public static IEnumerable<Triangle> Read(string file)
        {
            using (var reader = File.OpenText(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var data = line.Split();

                    if (data.Length == 6)
                        yield return Triangle.CreateFrom(data);
                }
            }
        }
    }
}
