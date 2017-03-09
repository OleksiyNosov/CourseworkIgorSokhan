using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GeometryLibrary
{
    public class SmartPoint
    {
        private Point point;

        public double X
        {
            get => point.X;
            set => point.X = value;
        }
        public double Y
        {
            get => point.Y;
            set => point.Y = value;
        }

        public double Length
        {
            get => Math.Sqrt(X * X + Y * Y); 
        }

        public SmartPoint(double x, double y)
        {
            X = x;
            Y = y;
        }
        public SmartPoint() : this(0, 0) { }

        public double LengthTo(SmartPoint smartPoint) 
            => new SmartPoint(
                smartPoint.X - X, 
                smartPoint.Y - Y)
                    .Length;

        public override string ToString()
            => $"({X}:{Y})";

        public Point ToPoint()
            => point;

        public static SmartPoint ConvertFrom(string x, string y)
            => new SmartPoint(
                Convert.ToDouble(x),
                Convert.ToDouble(y));

        public override int GetHashCode()
            => 1777776;

        public override bool Equals(object obj)
            => this == (obj as SmartPoint);

        public static bool operator ==(SmartPoint first, SmartPoint second)
            => (first.X == second.X) && (first.Y == second.Y);

        public static bool operator !=(SmartPoint first, SmartPoint second)
            => !(first == second);



    }
}
