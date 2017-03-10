using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLibrary;

namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadTrianglesFromFile();

            Console.ReadKey();
        }

        private static void ReadTrianglesFromFile()
        {
            var file = "Triangles.txt";

            var triangles = FileWorker.Read(file);

            foreach (var triangle in triangles)
            {
                Console.WriteLine(triangle);
            }
        }
    }
}
