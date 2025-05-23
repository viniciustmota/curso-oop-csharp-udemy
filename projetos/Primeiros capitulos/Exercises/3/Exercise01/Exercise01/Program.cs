using System.Globalization;
using Exercise01;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantidadeDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Valor a ser pago em reais = {Cotacao.Conversao(cotacao, quantidadeDolares).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}