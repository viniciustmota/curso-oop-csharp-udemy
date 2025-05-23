using GetHashCodeAndEquals.Entities;

namespace GetHashCodeAndEquals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@mail.com" };
            Client b = new Client { Name = "Alex", Email = "maria@mail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

        }
    }
}
