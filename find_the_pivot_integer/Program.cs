using System;
using System.Runtime.CompilerServices;
namespace CSharp
{
    public class Solution 
    {
        public static int PivotInteger(int n)
        {
            int sum = 0;            
            for (int i = 1; i <= n; i++)
            {
               sum += i;
            }
            int sumLeft = 0;
            for (int i = 1; i <= n; i++)
            {
                sumLeft += i;
                if (sumLeft < sum)
                {
                    sumLeft += i;
                }
                else if (sumLeft == sum)
                {
                    return i;
                }
            }
            return -1;
        }
    }
    class Program
    {   
        public static void Main(string[] args)
        {
            int n = 8;
            Console.Write(Solution.PivotInteger(n));
        }
    }
}



