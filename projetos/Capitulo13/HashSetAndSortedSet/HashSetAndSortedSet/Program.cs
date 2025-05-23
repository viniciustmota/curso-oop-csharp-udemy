﻿using System.Collections.Generic;
namespace HashSetAndSortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Aula 2

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            // Union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);

            PrintCollection(c);

            // Intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            // Difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection) { 
            foreach(T obj in collection)
            {
                Console.Write($"{obj} ");
            }
            Console.WriteLine();











            // Aula 1


            //HashSet<string> set = new HashSet<string>();

            //set.Add("TV");
            //set.Add("Notebook");
            //set.Add("Tablet");

            //Console.WriteLine(set.Contains("Abacaxi"));

            //foreach(string p in set)
            //{
            //    Console.WriteLine(p);
            //}
        }
    }
}
