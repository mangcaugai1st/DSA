using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharp
{
    public class Solution 
    {
        public static int[] SortedSquares(int[] nums)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            { 
                result.Add(nums[i] * nums[i]); 
            }
            result.Sort();
            return result.ToArray();
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = new[] {-4, -1, 0, 3, 10};
            foreach (int num in Solution.SortedSquares(nums))
            {
                Console.Write("{0} ",num);
            }
        }
    }
}



