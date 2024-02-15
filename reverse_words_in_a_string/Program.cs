using System;
using System.Collections.Generic;
using System.Globalization;

namespace CSharp
{
    public class Solution 
    {
        public static string ReverseWords(string s)
        {
            return string.Join(" ", s.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).Reverse());
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            string s = " the sky is blue ";
            Console.Write(Solution.ReverseWords(s));
        }
    }
}



