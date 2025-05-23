using System.Globalization;
using System.Text;
using Exercise03.Model.Enums;

namespace Exercise03.Model.Entities
{
    internal class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rectangule color = {Color}, width = {Width.ToString("F2", CultureInfo.InvariantCulture)}, height = {Height.ToString("F2", CultureInfo.InvariantCulture)}, area = {Area().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
