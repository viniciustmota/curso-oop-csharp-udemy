using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void AcrescimoSalario(Employee idFunc, double porcentagem)
        {
            porcentagem /= 100.0;
            idFunc.Salary += (idFunc.Salary * porcentagem);
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
