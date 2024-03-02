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
    public class Solution 
    {
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int maxCandies = -1;
            foreach (int candy in candies)
            {
                maxCandies = Math.Max(maxCandies, candy);
            }
            List<bool> result = new List<bool>();
            foreach (int candy in candies)
            {
                if (candy + extraCandies >= maxCandies)
                {
                    result.Add(true);
                }
                else
                {
                    result.Add(false);
                }
            }
            return result.ToArray();
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            int[] candies = new [] {2, 3, 5, 1, 3};
            int extraCandies = 3;
            foreach (bool i in Solution.KidsWithCandies(candies, extraCandies))
            {
                Console.Write("{0} ", i);
            }
        }
    }
}



