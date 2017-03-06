using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class SmartPoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public SmartPoint(double x, double y)
        {
            X = x;
            Y = y;
        }
        public SmartPoint() : this(0, 0) { }


        public override string ToString()
        {
            return $"({X}:{Y})";
        }

        public static SmartPoint ConvertFrom(string x, string y)
        {
            return new SmartPoint(
                Convert.ToDouble(x),
                Convert.ToDouble(y));
        }
    }
}
