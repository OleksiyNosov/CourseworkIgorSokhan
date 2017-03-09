using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    class SmartLine
    {
        public SmartPoint First { get; set; }
        public SmartPoint Second { get; set; }

        public SmartLine(SmartPoint first, SmartPoint second)
        {
            First = first;
            Second = second;
        }
        public SmartLine() : this(new SmartPoint(), new SmartPoint()) { }

        public static bool IsLinesIntersect(SmartLine line1, SmartLine line2)
            => CrossProduct(line1.First, line1.Second, line2.First)
                != CrossProduct(line1.First, line1.Second, line2.Second)
                || CrossProduct(line2.First, line2.Second, line1.First)
                != CrossProduct(line2.First, line2.Second, line1.Second);
        

        private static double CrossProduct(SmartPoint p1, SmartPoint p2, SmartPoint p3)
            => (p2.X - p1.X) * (p3.Y - p1.Y) - (p3.X - p1.X) * (p2.Y - p1.Y);
        
    }
}
