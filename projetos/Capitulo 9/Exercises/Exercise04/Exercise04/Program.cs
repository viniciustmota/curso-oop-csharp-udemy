﻿using System.ComponentModel;
using System.Globalization;
using Exercise04.Entities;

namespace Exercise04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmployess = int.Parse(Console.ReadLine());

                    list.Add(new LegalEntity(name, anualIncome, numberEmployess));
                }

            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            foreach (Person person in list)
            {
                Console.WriteLine($"{person.Name}: $ {person.TotalImposto().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine();
            double sum = 0.0;
            foreach (Person person in list)
            {
                sum += person.TotalImposto();
            }
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}