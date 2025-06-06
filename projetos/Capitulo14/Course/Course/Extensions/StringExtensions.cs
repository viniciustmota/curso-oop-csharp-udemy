﻿namespace System
{
    static internal class StringExtensions
    {
        public static string Cut(this string thisObj, int count)
        {
            if(thisObj.Length <= count)
            {
                return thisObj;
            }
            return thisObj.Substring(0, count) + "...";
        }
    }
}
