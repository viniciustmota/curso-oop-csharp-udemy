﻿using System.Globalization;
using Exercise03.Model.Entities;
using Exercise03.Model.Enums;

namespace Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}