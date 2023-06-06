namespace ShapeLib
{
    public class Rectangle : IShape
    {
        private readonly double _x;
        private readonly double _y;
        
        public Rectangle(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double Area()
        {
            return _x * _y;
        }

        public bool IsSquare()
        {
            return _x == _y; 
        }
    }
}
