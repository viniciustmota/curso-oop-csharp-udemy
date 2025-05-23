using System;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,,] mat = new double[2, 3, 7];

            Console.WriteLine(mat.Length); // Quantos elementos a matriz tem no total

            Console.WriteLine(mat.Rank); // Retorna o número de dimensões da matriz.

            Console.WriteLine(mat.GetLength(0)); // Primeira dimensão da matriz, ou seja, a quantidade de linhas

            Console.WriteLine(mat.GetLength(1)); // Segunda dimensão da matriz, ou seja, a quantidade de colunas
        }
    }
}