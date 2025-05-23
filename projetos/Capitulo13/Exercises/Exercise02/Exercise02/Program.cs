using System.Collections.Generic;

namespace Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            string[] letter = new string[3] { "A", "B", "C" };
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"How many students for course {letter[i]}? ");
                int n = int.Parse(Console.ReadLine());
                
                for(int j = 0; j < n; j++)
                {
                    int studantNumber = int.Parse(Console.ReadLine());
                    set.Add(studantNumber);
                }
                
            }

            Console.WriteLine($"Total students: {set.Count}");
        }
    }
}
