using Course.Entitites;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int val = int.Parse(Console.ReadLine());
                printService.AddValue(val);
            }
            printService.Print();
            Console.WriteLine($"First: {printService.First()}");
        }
    }
}
