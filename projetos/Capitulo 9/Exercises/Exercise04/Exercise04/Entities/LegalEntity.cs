
namespace Exercise04.Entities
{
    internal class LegalEntity : Person
    {
        public int NumberEmployees { get; set; }

        public LegalEntity(string name, double anualIncome, int numberEmployees) : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double TotalImposto()
        {
            double imposto = 16;
            if (NumberEmployees > 10)
            {
                imposto = 14;
            }
            return PagarImposto(imposto);
        }
    }
}
