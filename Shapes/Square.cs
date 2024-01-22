namespace Shapes
{
    public class Square
    {
        public double sideLength;
        public string color;
        public double area;

        public Square(double sideLength, string color)
        {
            this.sideLength = sideLength;
            this.color = color;
            area = GetArea(sideLength);
        }

        private double GetArea(double sideLength)
        {
            return sideLength * sideLength;
        }

        public void GetInfo()
        {
            Console.WriteLine("Color: {0}, sideLength: {1}, area: {2}", color, sideLength, area);
        }
    }
}
