using System;
using System.Formats.Asn1;
using System.Globalization;

namespace ListaExerciciosEstruturaSequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 01

            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"SOMA = {n1+n2}");

            // ------------------------------------------------

            // Exercicio 02

            //double pi = 3.14159;
            //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double area = pi * Math.Pow(raio, 2.0);
            //Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");

            // ------------------------------------------------

            // Exercicio 03

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int d = int.Parse(Console.ReadLine());
            //int res = a * b - c * d;
            //Console.WriteLine($"DIFERENCA = {res}");

            // ------------------------------------------------

            // Exercicio 04

            //int numFunc = int.Parse(Console.ReadLine());
            //int horasTrab = int.Parse(Console.ReadLine());
            //double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double salario = horasTrab * valorPorHora;
            //Console.WriteLine($"NUMBER = {numFunc}");
            //Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");

            // ------------------------------------------------

            // Exercicio 05

            //string[] linha1 = Console.ReadLine().Split(' ');
            //int codigoProd1 = int.Parse(linha1[0]);
            //int qtdProd1 = int.Parse(linha1[1]);
            //double valorPorPecaProd1 = double.Parse(linha1[2], CultureInfo.InvariantCulture);

            //string[] linha2= Console.ReadLine().Split(' ');
            //int codigoProd2 = int.Parse(linha2[0]);
            //int qtdProd2 = int.Parse(linha2[1]);
            //double valorPorPecaProd2 = double.Parse(linha2[2], CultureInfo.InvariantCulture);

            //double soma = valorPorPecaProd1 * qtdProd1 + valorPorPecaProd2 * qtdProd2;
            //Console.WriteLine($"VALOR A PAGAR: R$ {soma.ToString("F2", CultureInfo.InvariantCulture)}");

            // ------------------------------------------------

            // Exercicio 06

            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double triangulo = (a * c) / 2.0;
            double circulo = 3.14159 * Math.Pow(c, 2.00);
            double trapezio = (a + b) / 2.0 * c;
            double quadrado = Math.Pow(b, 2.00);
            double retangulo = a * b;


            Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}