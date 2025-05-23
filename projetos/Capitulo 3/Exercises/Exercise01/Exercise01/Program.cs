using System.Globalization;

namespace Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hospede[] vect = new Hospede[10];

            Console.Write("How many rooms will be rented? ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                Console.WriteLine();
                vect[room] = new Hospede { Name = name, Email = email};
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                    Console.WriteLine($"{i}: {vect[i]}");
                
            }
        }
    }
}