using Xunit.Sdk;
using ShapesApp;
namespace GeometryTest
{
    [TestClass]
    public class ShapesUnitTest
    {
        [TestMethod]
        public void TestCircleSquareCalculation()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual(78, circle.calcSquare());
        }

        [TestMethod]
        public void TestTriangleSquareCalculation() 
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.calcSquare());
        }
        [TestMethod]
        public void TestIsRectangularTriangle() 
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.isRectangular());
        }
        [TestMethod]
        public void TestIsNotRectangularTriangle() 
        {
            Triangle triangle = new Triangle(3, 4, 7);
            Assert.IsFalse(triangle.isRectangular());
        }
        [TestMethod]
        public void TestCalculationCircleAsShapeType() 
        {
            IShape circle = new Circle(3);
            Assert.AreEqual(28, circle.calcSquare());
        }
        [TestMethod]
        public void TestCalculationTriangleAsShapeType() 
        {
            IShape triangle = new Triangle(13, 12, 5);
            Assert.AreEqual(30, triangle.calcSquare());
        }
    }
}