using System.Globalization;
using System.Text;
using Exercise03.Model.Enums;
namespace Exercise03.Model.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Circle color = {Color}, radius = {Radius.ToString("F2", CultureInfo.InvariantCulture)}, area = {Area().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
