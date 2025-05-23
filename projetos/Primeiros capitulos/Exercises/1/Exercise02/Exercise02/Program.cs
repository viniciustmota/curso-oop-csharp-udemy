using System;
using System.Globalization;

namespace Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1, employee2;
            employee1 = new Employee();
            employee2 = new Employee();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            employee1.name = Console.ReadLine();
            Console.Write("Salário: ");
            employee1.wage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            employee2.name = Console.ReadLine();
            Console.Write("Salário: ");
            employee2.wage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double average = (employee1.wage + employee2.wage) / 2;

            Console.WriteLine($"Salário médio = {average.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}