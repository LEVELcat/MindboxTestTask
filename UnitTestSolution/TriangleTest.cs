using MindboxTestTask;

namespace UnitTestSolution
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleCorrectAreaCalculate()
        {
            Triangle shape = new Triangle(3, 4, 5);
            var result = shape.AreaOfShape;

            Assert.AreEqual(6, result, 1.0E-20);
        }

        [TestMethod]
        public void TriangleCorrectAreaCalculateSmallNumber()
        {
            Triangle shape = new Triangle(3.0E-5, 4.0E-5, 5.0E-5);
            var result = shape.AreaOfShape;

            Assert.AreEqual(6.0E-10, result, 1.0E-20);
        }

        [TestMethod]
        public void TriangleCorrectAreaCalculateWithBigNumber()
        {
            Triangle shape = new Triangle(1000, 5122, 4632);
            var result = shape.AreaOfShape;

            Assert.AreEqual(2.114494296936030991100825836349e+6, result, 1.0E+0);
        }

        [TestMethod]
        public void OutOfMaximalRangeCheck()
        {
            try
            {
                Triangle shape = new Triangle(Shape.MaximalValue + 1.0E+20, 2, 2);
            }
            catch (ArgumentException ae)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void OutOfMinimalRangeCheck()
        {
            try
            {
                Triangle shape = new Triangle(Triangle.MinimalValue - 1.0E-10, 2, 2);
            }
            catch (ArgumentException ae)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void IsRightTriangleCheck()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Assert.IsTrue(triangle.IsRightTriangle);
        }

        [TestMethod]
        public void IsNotRightTriangleCheck()
        {
            Triangle triangle = new Triangle(10, 10, 12);

            Assert.IsFalse(triangle.IsRightTriangle);
        }
    }
}