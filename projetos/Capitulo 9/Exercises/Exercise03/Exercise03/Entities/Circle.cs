using Exercise03.Entities.Enums;
namespace Exercise03.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius)
            : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }
    }
}
