﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        //public static int Sum(params int[] numbers)
        //{
        //    //int sum = 0;
        //    //for (int i = 0; i < numbers.Length; i++)
        //    //{
        //    //    sum += numbers[i];
        //    //}
        //    //return sum;


        //}

        //public static void Triple(ref int x)
        //{
        //    x = x * 3;
        //}

        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }


}
