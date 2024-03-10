namespace CS
{
    public class Solution
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        result.Add(nums1[i]);
                    }
                }
            }
            return result.Distinct<int>().ToArray();
        }    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums1 = new int[] { 1, 2, 2, 1 };
            //int[] nums2 = new int[] { 2, 2 };
            int[] nums1 = new int[] { 4, 9, 5 };
            int[] nums2 = new int[] { 9, 4, 9, 8, 4 };
            foreach (int i in Solution.Intersection(nums1, nums2))
            {
                Console.Write("{0} ", i);
            }
        }
    }
}