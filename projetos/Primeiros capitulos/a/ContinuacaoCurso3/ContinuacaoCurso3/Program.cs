using System;
using System.Globalization;

namespace ContinuacaoCurso3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite três números:");
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //int n3 = int.Parse(Console.ReadLine());

            //double resultado = Maior(n1, n2, n3);

            //Console.WriteLine($"Maior = {resultado}");



            //Console.Write("Digite um número: ");
            //double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //while (x >= 0.0)
            //{
            //    double raiz = Math.Sqrt(x);
            //    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));

            //    Console.Write("Digite outro número: ");
            //    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}
            //Console.WriteLine("Número negativo!");

            // ----------------------------------------------

            // Exercicio 01

            //Console.Write("Digite a senha: ");
            //int senha = int.Parse(Console.ReadLine());
            //while (senha != 2002)
            //{
            //    Console.WriteLine("Senha Invalida");
            //    Console.Write("Digite a senha: ");
            //    senha = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Acesso permitido");

            // --------------------------------------------

            // Exercicio 02

            //Console.Write("Digite as coordenadas (na mesma linha): ");
            //string[] vet = Console.ReadLine().Split(' ');
            //int x = int.Parse(vet[0]);
            //int y = int.Parse(vet[1]);

            //while (x != 0 && y != 0)
            //{
            //    if(x > 0 && y > 0)
            //    {
            //        Console.WriteLine("primeiro");
            //    }
            //    else if(x < 0 && y > 0)
            //    {
            //        Console.WriteLine("segundo");
            //    }else if(x < 0 && y < 0)
            //    {
            //        Console.WriteLine("terceiro");
            //    }
            //    else
            //    {
            //        Console.WriteLine("quarto");
            //    }
            //    vet = Console.ReadLine().Split(' ');
            //    x = int.Parse(vet[0]);
            //    y = int.Parse(vet[1]);

            //}

            // Exercicio 03

            Console.WriteLine("Digite uma das seguintes opções: ");
            Console.WriteLine("1. Álcool");
            Console.WriteLine("2. Gasolina");
            Console.WriteLine("3. Diesel");
            Console.WriteLine("\n4. Encerrar");

            int opcao = int.Parse(Console.ReadLine()), alcool = 0, gasolina = 0, diesel = 0;
            while(opcao != 4)
            {
                if (opcao == 1)
                {
                    alcool++;
                }
                else if (opcao == 2)
                {
                    gasolina++;
                }else if (opcao == 3)
                {
                    diesel++;
                }
                else
                {
                    Console.WriteLine("Opção Inválida, escolha uma opção correta");
                }
                Console.WriteLine("Escolha mais opções: ");
                opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nMUITO OBRIGADO");
            Console.WriteLine($"Álcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");




            //static int Maior(int a, int b, int c)
            //{
            //    int m;
            //    if (a > b && a > c)
            //    {
            //        m = a;
            //    }else if(b > c)
            //    {
            //        m = b;
            //    }else
            //    {
            //        m = c;
            //    }
            //    return m;
            //}
        }
    }
}