using System;
using System.Collections;
using System.Collections.Generic;
namespace CSharp
{ 
    class Solution
    {
        public static int[] TwoSum(int[] nums, int target) 
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] {i, j};       
                    }
                }
            }
            return new int[0];
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[] {2, 7, 11, 15};
            int target = 9;
            Console.Write(String.Join(" ", Solution.TwoSum(nums, target))); 
        }
    }
}
