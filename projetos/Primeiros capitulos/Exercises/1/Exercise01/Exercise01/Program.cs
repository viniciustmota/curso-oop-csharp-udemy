using System;

namespace Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa person1, person2;
            person1 = new Pessoa();
            person2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            person1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            person1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            person2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            person2.idade = int.Parse(Console.ReadLine());

            if(person1.idade > person2.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {person1.nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {person2.nome}");

            }
        }
    }
}