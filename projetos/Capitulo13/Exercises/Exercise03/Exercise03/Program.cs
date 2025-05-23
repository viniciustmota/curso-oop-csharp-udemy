using System.Runtime.CompilerServices;
using Exercise03.Entities;

namespace Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, VoteCounting> dic = new Dictionary<string, VoteCounting>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);

                        if (dic.ContainsKey(name))
                        {
                            dic[name].AddUpVotes(votes);
                        }
                        else
                        {
                            dic[name] = new VoteCounting { Name = name, Votes = votes};
                        }                        
                    }
                    foreach(var item in dic)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value.Votes}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
