using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02.Entities
{
    internal class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Person(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
