using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GeometryLibrary;
using System.Windows.Shapes;
using System.Windows.Media;

namespace MainApp
{
    public class Graphic
    {
        private  Canvas canvas;

        public Graphic(Canvas canvas)
        {
            this.canvas = canvas;
        }

        public void Draw(Triangle triangle, double strokeThickness, Brush stroke)
        {
            var polyline = new Polyline()
            {
                Stroke = stroke,
                StrokeThickness = strokeThickness
            };

            for (int i = 0; i <= triangle.Points.Length; i++)
                polyline.Points.Add(triangle[i].ToPoint());

            canvas.Children.Add(polyline); 
        }

        public void Draw(Triangle triangle)
        {
            Draw(triangle, 2, Brushes.Black);
        }
    }
}
