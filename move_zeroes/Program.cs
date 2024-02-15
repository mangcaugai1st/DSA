using System;
using System.Collections.Generic;
using System.Globalization;

namespace CSharp
{
    class Program
    {
        public static void MoveZeroes(int[] nums)
        {
            int left = 0;
            for (int curIndex = 0; curIndex < nums.Length; curIndex++)
            {
                if (nums[curIndex] != 0)
                {
                    (nums[left], nums[curIndex]) = (nums[curIndex], nums[left]);
                    left++;
                }
            }
        }
        public static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 0, 3, 12 };
            MoveZeroes(nums);
            PrintArray(nums);
        }
    }
}



