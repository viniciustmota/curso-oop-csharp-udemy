using System;
using Course.Entities;
using Course.Entities.Enums;


namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}

// Caso não funcione

//OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");

//OrderStatus os;
//Enum.TryParse("Delivered", out os);