using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Exercise03.Entities.Enums;

namespace Exercise03.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(OrderStatus status, Client client)
        {

            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        public Double Total()
        {
            double sum = 0;

            foreach(OrderItem item in OrderItems)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.Append("Order moment: ");
            text.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            text.Append("Order status: ");
            text.AppendLine(Status.ToString());
            text.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            text.AppendLine("Order items:");
            foreach(OrderItem item in OrderItems)
            {
                text.AppendLine(item.ToString());
            }
            text.AppendLine($"Total price: ${Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return text.ToString();
        }
    }
}
