using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _7ПрСизов.Classes
{
    public class Triangle:Figure
    {

        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int x3 { get; set; }
        public int y3 { get; set; }
        //public int a {  get; set; }
        //public int b { get; set; }
        //public int c { get; set; }


        //public Triangle(int CenterX, int CenterY, int A, int B, int C) : base(CenterX, CenterY)
        //{
        //    a = A; b = B; c = C;
        //}
        public Triangle(int CenterX,int CenterY, int X1, int Y1, int X2, int Y2, int X3, int Y3) : base(CenterX, CenterY)
        {
            x1 = X1;
            x2 = X2;
            y1 = Y1;
            y2 = Y2;
            x3 = X3;
            y3 = Y3;
        }


        public void Draw(Canvas canvasTriangle)
        {


            //double cx = (a*a - b*b + c*c) / (2*c);
            //double cy = Math.Sqrt(a * a - cx * cx);

            Polygon triangle = new Polygon();
            triangle.Stroke = Brushes.Black;
            triangle.StrokeThickness = 3;
            
            triangle.Fill = Brushes.Blue;
            triangle.Points.Add(new System.Windows.Point(x1, y1));
            triangle.Points.Add(new System.Windows.Point(x2, y2));
            triangle.Points.Add(new System.Windows.Point(x3, y3));

            Canvas.SetLeft(triangle, centerX);
            Canvas.SetTop(triangle, centerY);
            canvasTriangle.Children.Add(triangle);
        }
    }
}
