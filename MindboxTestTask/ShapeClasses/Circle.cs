namespace MindboxTestTask
{
    public class Circle : Shape
    {
        public double Radius { get; protected set; }

        public Circle(double radius) : base ()
        {
            if (CheckValueIsInRange(radius) == false)
                throw new ArgumentException($"Радиус меньше {MinimalValue} или больше {MaximalValue}");

            this.Radius = radius;
        }

        public override double AreaOfShape => Math.PI * Radius * Radius;
    }
}
