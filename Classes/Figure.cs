namespace _7ПрСизов.Classes
{
    public class Figure
    {
        public int centerX {  get; set; }
        public int centerY { get; set; }


        public Figure(int CenterX, int CenterY)
        {
            centerX = CenterX;
            centerY = CenterY;
        }
        public Figure()
        {
            centerX = 0; centerY = 0;
        }
    }
}
