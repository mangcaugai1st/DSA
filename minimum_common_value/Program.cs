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
        public static int GetCommon(int[] nums1, int[]nums2)
        {
            int i = 0;
            int j = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] == nums2[j])
                {
                    return nums1[i];
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
            return -1;
        }
    }
    class Program
    {   
        public static void Main(string[] args)
        {
            int[] nums1 = new[] {1, 2, 3};
            int[] nums2 = new[] {2, 4};
            Console.WriteLine(Solution.GetCommon(nums1, nums2));
        }
    }
}



