using System; 

namespace CSharp
{
    public class Solution 
    {
        public int FindMaxK(int[] nums)
        {
            Array.Sort(nums);
            int i = 0;
            int j = nums.Length - 1;
            while (i < j)
            {
                if (nums[i] + nums[j] == 0)
                {                        
                    return nums[j];
                }
                else if (Math.Abs(nums[i]) > Math.Abs(nums[j])) i++;
                else j--;   
            } 
            return -1; 
        }
    }
    class Program 
    {    
        public static void Main(string[] args)
        {
            int[] nums = new int[]{-1,10,6,7,-7,1};
            Solution testcase1 = new Solution();
            Console.WriteLine(testcase1.FindMaxK(nums));    
        }
    }
}








