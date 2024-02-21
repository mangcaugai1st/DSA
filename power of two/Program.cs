using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CSharp
{
    public class Solution
    {
        public static bool IsPowerOfTwo(int n)
        {
            for (int i = 0; i < 100; i++)
            {
                double answer = Math.Pow(2, i);
                if (answer == n) return true;
            }
            return false;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            int n1 = 1;
            Console.WriteLine(Solution.IsPowerOfTwo(n1));
            int n2 = 16;
            Console.WriteLine(Solution.IsPowerOfTwo(n2));
            int n3 = 3;
            Console.WriteLine(Solution.IsPowerOfTwo(n3));
        }
    }
}



