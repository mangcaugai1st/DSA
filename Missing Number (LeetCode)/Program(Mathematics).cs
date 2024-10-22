using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CSharp
{
    public class Solution
    {
        public static int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            int expected_sum_of_array = n * (n + 1) / 2;
            int actual_sum_of_array = 0;
            foreach (int num in nums)
            {
                actual_sum_of_array += num;
            }
            return expected_sum_of_array - actual_sum_of_array;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            int[] nums1 = new[] { 3, 0, 1 };
            Console.WriteLine(Solution.MissingNumber(nums1));
            int[] num2 = new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            Console.WriteLine(Solution.MissingNumber(num2));
        }
    }
}



