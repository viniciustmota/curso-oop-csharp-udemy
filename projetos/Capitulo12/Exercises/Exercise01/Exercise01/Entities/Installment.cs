using System.Text;
using System.Globalization;

namespace Exercise01.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{DueDate.ToString("dd/MM/yyyy")} - {Amount.ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
