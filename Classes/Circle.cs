using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _7ПрСизов.Classes
{
    public class Circle : Figure
    {
        public int diametr {  get; set; }
        public Circle(int CenterX, int CenterY, int Diametr) : base(CenterX, CenterY)
        {

            diametr = Diametr;
        }


        public void Draw(Canvas canvasCircle)
        {

            Ellipse ellipse = new Ellipse();


            ellipse.Width = diametr/2;
            ellipse.Height = diametr/2;
            ellipse.Fill = Brushes.Green;
            
            
            Canvas.SetLeft(ellipse, centerX);
            Canvas.SetTop(ellipse, centerY);
            canvasCircle.Children.Add(ellipse);
        }

    }
}
