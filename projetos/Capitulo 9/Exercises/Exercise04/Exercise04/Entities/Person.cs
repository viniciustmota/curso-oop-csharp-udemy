using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04.Entities
{
    abstract internal class Person
    {
        public  string Name { get; set; }
        public double AnualIncome { get; set; }

        public Person(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public double PagarImposto(double imposto)
        {
            return AnualIncome * (imposto/100);
        }

        public abstract double TotalImposto();

        }
}
