namespace ShapeLib
{
    public class Circle : IShape
    {
        private readonly double _radius;
        private readonly double pi = 3.14;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Area()
        {
            return Math.Pow(_radius, 2) * pi;
        }
    }
}