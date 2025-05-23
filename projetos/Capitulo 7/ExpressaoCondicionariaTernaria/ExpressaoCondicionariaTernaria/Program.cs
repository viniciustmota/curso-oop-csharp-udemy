using System.Globalization;

namespace CondicionalExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = ( preco < 20) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine(desconto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}