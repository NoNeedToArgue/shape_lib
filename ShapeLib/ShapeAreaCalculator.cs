namespace ShapeLib
{
    public static class ShapeAreaCalculator
    {
        private static Dictionary<Type, Func<object, double>> CalcProcessor = new()
        {
            { typeof(Circle), (object value) => ((Circle)value).Area() },
            { typeof(Triangle), (object value) => ((Triangle) value).Area() },
            { typeof(Rectangle), (object value) => ((Rectangle) value).Area() }
            //+ any others
        };

        public static double CalculateArea(object shape)
        {
            var shapeType = shape.GetType();

            if (!CalcProcessor.ContainsKey(shapeType))
                throw new InvalidOperationException("Unknown shape");

            var processor = CalcProcessor[shapeType];

            return processor.Invoke(shape);
        }
    }
}
