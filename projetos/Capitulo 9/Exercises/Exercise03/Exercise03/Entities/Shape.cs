using Exercise03.Entities.Enums;

namespace Exercise03.Entities
{
    abstract internal class Shape
    {
        public Color Color { get; set; }

        public Shape() { }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
