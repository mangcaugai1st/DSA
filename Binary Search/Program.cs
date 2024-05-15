using System;
using System.Security.Cryptography.X509Certificates;

namespace CSharp
{
    public class Solution 
    {
        public int Search(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (target == nums[middle]) return middle;
                else if (target > nums[middle]) low = middle + 1;
                else high = middle - 1;
            }
            return -1;
        }
    }
    class Program 
    {    
        public static void Main(string[] args)
        {
            int[] nums = new int[] {-1, 0, 3, 5, 9, 12};
            int target = 9;
            Solution testcase1 = new Solution();
            int result =  testcase1.Search(nums, target);
            Console.WriteLine(result);
        }
    }
}








