using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    internal class Cotacao
    {
        static double Iof = 0.06;
        public static double Conversao(double c, double qtd)
        {
            return (c * qtd) + ((c * qtd) * Iof);
        }
    }
}
