namespace CS
{
    public class Solution
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            HashSet<int> set = new HashSet<int>();
            int i = 0;
            int j = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] == nums2[j])
                {
                    set.Add(nums1[i]);
                    i++;
                }
                else if (nums1[i] < nums2[j])
                {
                    i++;
                }
                else if (nums1[i] > nums2[j])
                {
                    j++;
                }
            }
            int k = 0;
            int[] res = new int[set.Count];
            foreach (int num in set)
            {
                res[k] = num;
                k++;
            }
            return res;
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