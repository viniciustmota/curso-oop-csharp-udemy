using Exercise02.Entities;
using System.Globalization;
using System.Linq;

namespace Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Person> list = new List<Person>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string namePerson = fields[0];
                        string emailPerson = fields[1];
                        double salaryPerson = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Person(namePerson, emailPerson, salaryPerson));
                    }
                }



                Console.WriteLine($"Email of people whose salary is more than {limit.ToString("F2", CultureInfo.InvariantCulture)}:");
                var emails = list.Where(p => p.Salary > limit).OrderBy(p => p.Email).Select(p => p.Email);
                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }
                var salaryTotal = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
                Console.Write($"Sum of salary of people whose name starts with 'M': {salaryTotal.ToString("F2", CultureInfo.InvariantCulture)}");

            }catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
