using MindboxTestTask;

namespace UnitTestSolution
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CircleCorrectAreaCalculate()
        {
            Circle shape = new Circle(1);
            var result = shape.AreaOfShape;

            Assert.AreEqual(3.1415926535897932384626433832795, result, 1.0E-20);
        }

        [TestMethod]
        public void CircleCorrectAreaCalculateSmallNumber()
        {
            Circle shape = new Circle(2.56E-9);
            var result = shape.AreaOfShape;

            Assert.AreEqual(2.058874161456607e-17, result, 1.0E-20);
        }

        [TestMethod]
        public void CircleCorrectAreaCalculateWithBigNumber()
        {
            Circle shape = new Circle(68473475346623);
            var result = shape.AreaOfShape;

            Assert.AreEqual(1.4729724176199170490381090504548e+28, result, 1.0E+15);
        }

        [TestMethod]
        public void OutOfMaximalRangeCheck()
        {
            try
            {
                Circle shape = new Circle(Shape.MaximalValue + 1.0E+20);
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
                Circle shape = new Circle(Shape.MinimalValue - 1.0E-10);
            }
            catch (ArgumentException ae)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.IsTrue(false);
        }
    }
}