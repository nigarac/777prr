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


            Polygon triangle = new Polygon();
            if (a * a + b * b == c * c || b *b + c * c == a * a || c * c + a * a == b * b)
            {
                double xc = centerX - a / 3.0;
                double yc = centerY - b / 3.0;
                double xa = centerX + 2*a / 3.0;
                double ya = centerY - b / 3.0;
                double xb = centerX - a / 3.0;
                double yb = centerY + 2*b / 3.0;
                triangle.Points.Add(new System.Windows.Point(xc, yc));
                triangle.Points.Add(new System.Windows.Point(xa, ya));
                triangle.Points.Add(new System.Windows.Point(xb, yb));
            }
            else
            {            
                double ma = 0.5 * Math.Sqrt(2 * b * b + 2 * c * c - a * a);
                double ra = (2.0 / 3.0) * ma;

                double xa = centerX;
                double ya = centerY + ra;
                double xb = centerX + Math.Sqrt(c * c - (9.0 / 4.0) * ra * ra);
                double yb = centerY - 0.5 * ra;
                double xc = 2 * centerX - xb;
                double yc = yb;

                triangle.Points.Add(new System.Windows.Point(xa, ya));
                triangle.Points.Add(new System.Windows.Point(xb, yb));
                triangle.Points.Add(new System.Windows.Point(xc, yc));
            }

            triangle.Stroke = Brushes.Black;
            triangle.StrokeThickness = 1;
            triangle.Fill = Brushes.Blue;

            Canvas.SetLeft(triangle, centerX);
            Canvas.SetTop(triangle, centerY);
            canvasTriangle.Children.Add(triangle);
        }
    }
}
