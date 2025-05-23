using System;
using System.Globalization;
using Composition1.Entities;
using Composition1.Entities.Enums;

namespace Composition1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data : ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY) ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter Order Data : ");
            string txt = OrderStatus.Processing.ToString();
            Console.WriteLine("Status: " + txt);


            Console.Write("How many items to this order ? ");
            int n = int.Parse(Console.ReadLine());

            DateTime moment = DateTime.Now;
            OrderStatus status = OrderStatus.Processing;
            Order order = new Order(moment, status, client);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"enter #{i} item data : ");
                Console.Write("product name : ");
                string productName = Console.ReadLine();
                Console.Write("product price : ");
                double price =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("quantity : ");
                int quantity = int.Parse(Console.ReadLine());


                Product product = new Product(productName, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);
               

                order.AddItem(orderItem);


            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY : ");
            Console.WriteLine(order);
            




        }
    }
}