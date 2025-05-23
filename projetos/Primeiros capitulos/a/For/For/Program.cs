using System;
using System.Numerics;
using System.Globalization;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exemplo

            //int qtdNum, valor, soma = 0;
            //Console.Write("Quantos números inteiros você vai digitar? ");
            //qtdNum = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= qtdNum; i++)
            //{
            //    Console.Write($"Valor #{i}: ");
            //    valor = int.Parse(Console.ReadLine());
            //    soma += valor;
            //}
            //Console.WriteLine($"Soma = {soma}");

            // Exercicio 01

            //int x = int.Parse(Console.ReadLine());
            //if(x <= 1000)
            //{
            //    for (int i = 1; i <= x; i += 2)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // Exercicio 02

            //int N = int.Parse(Console.ReadLine());
            //int dentro = 0, fora = 0;

            //for (int i = 0; i < N; i++)
            //{
            //    int valor = int.Parse(Console.ReadLine());
            //    if (valor >= 10 && valor <= 20)
            //    {
            //        dentro++;
            //    }
            //    else
            //        fora++;
            //}

            //Console.WriteLine($"{dentro} in");
            //Console.WriteLine($"{fora} out");

            // Exercicio 03

            //int N = int.Parse(Console.ReadLine());
            //double a = 0, b = 0, c = 0;
            //for (int i = 0; i < N; i++)
            //{
            //    string[] valores = Console.ReadLine().Split(' ');
            //    a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //    b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            //    c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //    a *= 2; b *= 3; c *= 5;
            //    double media = (a + b + c) / (2 + 3 + 5);
            //    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            //}

            // Exercicio 04

            //int N = int.Parse(Console.ReadLine());
            //for (int i = 0; i < N; i++)
            //{
            //    string[] line = Console.ReadLine().Split(' ');
            //    double a = double.Parse(line[0], CultureInfo.InvariantCulture);
            //    double b = double.Parse(line[1], CultureInfo.InvariantCulture);

            //    if (b != 0)
            //    {
            //        double div = a / b;
            //        Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
            //    }
            //    else
            //    {
            //        Console.WriteLine("Divisão Impossivel");
            //    }

            //}

            // Exercicio 05

            //int N = int.Parse(Console.ReadLine());
            //int fim = 0;
            //if (N == 0 || N == 1)
            //{
            //    fim = 1;
            //}
            //else
            //{
            //    for (int i = N; i >= 1; i--)
            //    {
            //        fim += N * (N - i);
            //    }
            //}
            //    Console.WriteLine(fim);

            // Exercicio 06

            //int N = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= N; i++)
            //{
            //    if(N % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // Exercicio 07

            int N = int.Parse(Console.ReadLine());
            for (double i = 1; i <= N; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }

        }
    }
}