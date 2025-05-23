using System.Globalization;
using System.Runtime.CompilerServices;

namespace Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee List<string> employee;

            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string employee = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                list.Add(new Employee(id, employee, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idSearch = int.Parse(Console.ReadLine());

            Employee idFunc = list.Find(x => x.Id == idSearch);

            if (idFunc == null)
            {
                Console.WriteLine("This id does not exist!");
            }
            else
            {
                Console.Write("Enter the percentage: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                idFunc.AcrescimoSalario(idFunc, porcentagem);
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees");
            foreach (Employee func in list)
            {
                Console.WriteLine(func);
            }
        }
    }
}