using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Composition1.Entities.Enums;
using System.Globalization;

namespace Composition1.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public Order()
        {
        }

        public void AddItem (OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem (OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total ()
        {
            double soma = 0.0;
            foreach (OrderItem item in Items)
            {
                soma += item.SubTotal();
                
            }

            return soma;    
        }

        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
            sb.AppendLine("order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("order status: " + Status);
            sb.AppendLine("client: " + Client);
            sb.AppendLine("order items :");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine();
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }

    }
}
