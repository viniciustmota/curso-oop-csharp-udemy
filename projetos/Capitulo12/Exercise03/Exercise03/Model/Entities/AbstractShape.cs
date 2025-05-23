using Exercise03.Model.Enums;

namespace Exercise03.Model.Entities
{
    abstract class AbstractShape : IShape
    {

        public Color Color { get; set; }

        public abstract double Area();
    }
}
