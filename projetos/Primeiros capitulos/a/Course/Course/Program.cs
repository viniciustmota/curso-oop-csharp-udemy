﻿using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");
            Console.WriteLine($"\n{idade} anos de idade, código {codigo} e gênero: {genero}\n");
            Console.WriteLine($"Medida: {medida:F8}");
            Console.WriteLine($"Medida: {medida:F3}");
            Console.WriteLine("Medida: " + medida.ToString("F3", CultureInfo.InvariantCulture));







        }
    }
}
