using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;

namespace CSharp
{
    class Program
    {
        static int solveMeFirst(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public static void Main(string[] args)
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(solveMeFirst(val1, val2));
        }
    }
}



