using MindboxTestTask;

namespace UnitTestSolution
{
    [TestClass]
    public class ShapeTest
    {
        [TestMethod]
        public void ShapeAreaCorrectCalculateFromTriangle()
        {
            Shape shape = new Triangle(3, 4, 5);
            var result = shape.AreaOfShape;

            Assert.AreEqual(6, result, 1.0E-20);
        }

        [TestMethod]
        public void ShapeAreaCorrectCalculateFromCircle()
        {
            Shape shape = new Circle(1);
            var result = shape.AreaOfShape;

            Assert.AreEqual(3.1415926535897932384626433832795, result, 1.0E-20);
        }
    }
}