using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class Triangle
    {
        private SmartPoint[] points;

        public bool IsIsosceles
        {
            get
            {
                var edges = new double[]
                {
                    points[0].LengthTo(points[1]),
                    points[1].LengthTo(points[2]),
                    points[2].LengthTo(points[0])
                };

                return (edges[0] == edges[1]) || (edges[0] == edges[2]);
            }
        }

        public static Triangle CreateFrom(string[] data)
            => new Triangle(
                SmartPoint.ConvertFrom(data[0], data[1]),
                SmartPoint.ConvertFrom(data[2], data[3]),
                SmartPoint.ConvertFrom(data[4], data[5]));
        

        public Triangle(SmartPoint point1, SmartPoint point2, SmartPoint point3)
            => points = new SmartPoint[] { point1, point2, point3 };
        
        public Triangle() : this(new SmartPoint(), new SmartPoint(), new SmartPoint()) { }

        public bool IsIntersectsWith(Triangle triangle)
        {
            throw new NotImplementedException();
        }

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

            sb.AppendLine($"{nameof(IsIsosceles)}: {IsIsosceles}");

            return sb.ToString();
        }
    }
}
