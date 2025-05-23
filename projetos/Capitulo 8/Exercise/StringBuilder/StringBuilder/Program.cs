using System;
using Stringbuilder.Entities;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("have a nice trip");
            Comment c2 = new Comment("wow thats awesome");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to new zealand ",
                "im going to visit this wonderful country",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Console.WriteLine(p1);



                

                
               


            
        }
    }
}