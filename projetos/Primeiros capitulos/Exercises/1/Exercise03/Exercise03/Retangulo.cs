using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura * 2) + (Altura * 2);
        }

        public double Diagonal()
        {
            return Math.Sqrt( Math.Pow(Largura, 2.00) + Math.Pow(Altura, 2.00));
        }
    }
}
