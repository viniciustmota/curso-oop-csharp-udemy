using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04.Entities
{
    internal class Individual : Person
    {
        public double HealthExpenditures { get; set; } = 0.0;

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public double DescontoSaude()
        {
            return HealthExpenditures * 0.5;
        }

        public override double TotalImposto()
        {
            double imposto = 25;
            if (AnualIncome <= 20000)
            {
                imposto = 15;
            }
                return PagarImposto(imposto) - DescontoSaude();
        }
    }
}
