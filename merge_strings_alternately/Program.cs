using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace CSharp
{
    public class Solution 
    {
        public static string MergeAlternatively(string word1, string word2)
        {
            StringBuilder result = new StringBuilder(); 
            int i = 0;
            int j = 0;
            while (i < word1.Length && j < word2.Length)
            {
                result.Append(word1[i]).Append(word2[j]); 
                i++;
                j++;
            }
            while (i < word1.Length)
            {
                result.Append(word1[i]);
                i++;
            }
            while (j < word2.Length)
            {
                result.Append(word2[j]);
                j++;
            }
            return result.ToString();
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            string word1 = "abc";
            string word2 = "pqr";
            Console.WriteLine(Solution.MergeAlternatively(word1,word2));
        }
    }
}



