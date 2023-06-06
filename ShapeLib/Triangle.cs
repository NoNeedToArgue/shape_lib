namespace ShapeLib
{
    public class Triangle : IShape
    {
        private readonly double _x;
        private readonly double _y;
        private readonly double _z;
        private readonly double _p;

        public Triangle(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
            _p = (_x + _y + _z) / 2;
        }

        public double Area()
        {
            return Math.Sqrt(_p * (_p - _x) * (_p - _y) * (_p - _z));
        }

        public bool IsRight()
        {
            double sqHipotenuse = Math.Pow(Math.Max(_x, Math.Max(_y, _z)), 2);
            
            return sqHipotenuse == Math.Pow(_x, 2) + Math.Pow(_y, 2) + Math.Pow(_z, 2) - sqHipotenuse;
        }
    }
}
