using System.Numerics;

namespace MindboxTestTask
{
    public class Triangle : Shape
    {
        public double Edge1 { get; private set; }

        public double Edge2 { get; private set; }

        public double Edge3 { get; private set; }

        public Triangle(double Edge1, double Edge2, double Edge3) : base ()
        {
            if(CheckValueIsInRange(Edge1) == false || 
               CheckValueIsInRange(Edge2) == false || 
               CheckValueIsInRange(Edge3) == false)
                throw new ArgumentException($"Введено ребро треугольника меньше {MinimalValue} или больше {MaximalValue}");

            this.Edge1 = Edge1;
            this.Edge2 = Edge2;
            this.Edge3 = Edge3;
        }

        public override double AreaOfShape
        {
            get
            {
                double p = (Edge1 + Edge2 + Edge3) / 2;

                double areaSqr = p * (p - Edge1) * (p - Edge2) * (p - Edge3);

                return Math.Sqrt(areaSqr);
            }
        }

        public bool IsRightTriangle
        {
            get
            {
                var errorOfCalculation = 1.0E-10;

                var sqrEdges = (new double[] {Edge1, Edge2, Edge3}).OrderDescending()
                                                                   .Select(x => x * x);

                var sqrOfLongestEdge = sqrEdges.First();

                var sumOfOtherEdgeSqr = sqrEdges.TakeLast(2)
                                                .Sum();

                return Math.Abs(sqrOfLongestEdge - sumOfOtherEdgeSqr) < errorOfCalculation;
            }
        }
    }
}
