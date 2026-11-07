using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _7ПрСизов.Classes
{
    public class Triangle:Figure
    {

        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }


        public Triangle(int CenterX, int CenterY, int A, int B, int C) : base(CenterX, CenterY)
        {
            a = A; b = B; c = C;
        }



        public void Draw(Canvas canvasTriangle)
        {

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                MessageBox.Show("такого треугольника не бывает!");
                return;
            }
            double ma = 0.5 * Math.Sqrt(2 * b * b + 2 * c * c - a * a);
            double ra = (2.0 / 3.0) * ma;

            Polygon triangle = new Polygon();

            double xa = centerX;
            double ya = centerY + ra;
            double xb = centerX + Math.Sqrt(c * c - (9.0 / 4.0) * ra * ra);
            double yb = centerY - 0.5 * ra;
            double xc = 2 * centerX - xb;
            double yc = yb;

            triangle.Points.Add(new System.Windows.Point(xa, ya));
            triangle.Points.Add(new System.Windows.Point(xb, yb));
            triangle.Points.Add(new System.Windows.Point(xc, yc));

            triangle.Stroke = Brushes.Black;
            triangle.StrokeThickness = 1;
            
            triangle.Fill = Brushes.Blue;




            Canvas.SetLeft(triangle, centerX);
            Canvas.SetTop(triangle, centerY);
            canvasTriangle.Children.Add(triangle);
        }
    }
}
