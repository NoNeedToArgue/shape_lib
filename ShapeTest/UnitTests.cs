using ShapeLib;

namespace ShapeTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void TestCircleArea()
        {
            double radius = 5;
            var circle = new Circle(radius);
            double expected = 78.5;
            double result = circle.Area();
            Assert.AreEqual(expected, result);
        }
    }

    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestTriangleArea()
        {
            double side1 = 5;
            double side2 = 5;
            double side3 = 9;
            var triangle = new Triangle(side1, side2, side3);
            double expected = 9.81;
            double result = Math.Round(triangle.Area(), 2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestTriangleNotRight()
        {
            double side1 = 5;
            double side2 = 5;
            double side3 = 9;
            var triangle = new Triangle(side1, side2, side3);
            bool expected = false;
            bool result = triangle.IsRight();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestTriangleIsRight()
        {
            double side1 = 3.5;
            double side2 = 2.1;
            double side3 = 2.8;
            var triangle = new Triangle(side1, side2, side3);
            bool expected = true;
            bool result = triangle.IsRight();
            Assert.AreEqual(expected, result);
        }
    }

    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void TestRectanglrArea()
        {
            double side1 = 2;
            double side2 = 4;
            var rectangle = new Rectangle(side1, side2);
            double expected = 8;
            double result = rectangle.Area();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestRectangleNotSquare()
        {
            double side1 = 2;
            double side2 = 4;
            var rectangle = new Rectangle(side1, side2);
            bool expected = false;
            bool result = rectangle.IsSquare();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestRectangleIsSquare()
        {
            double side1 = 5;
            double side2 = 5;
            var rectangle = new Rectangle(side1, side2);
            bool expected = true;
            bool result = rectangle.IsSquare();
            Assert.AreEqual(expected, result);
        }
    }
}
