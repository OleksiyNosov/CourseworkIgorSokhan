using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    class Triangle
    {
        private SmartPoint[] points;

        public bool IsIsosceles
        {
            get
            {
                var edges = new double[]
                {

                };
                return false;
            }
        }

        public static Triangle CreateFrom(string[] data)
        {
            return new Triangle(
                SmartPoint.ConvertFrom(data[0], data[1]),
                SmartPoint.ConvertFrom(data[2], data[3]),
                SmartPoint.ConvertFrom(data[4], data[5]));
        }

        public Triangle(SmartPoint point1, SmartPoint point2, SmartPoint point3)
        {
            points = new SmartPoint[] { point1, point2, point3 };
        }
        public Triangle() : this(new SmartPoint(), new SmartPoint(), new SmartPoint()) { }


        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Triangle");
            sb.Append("Points: ");
            foreach (var p in points)
            {
                sb.Append(p.ToString());
                sb.Append(' ');
            }

            sb.Append("\n\r");

            return sb.ToString();
        }
    }
}
