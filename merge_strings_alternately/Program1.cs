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
            string result = "";
            for (int i = 0; i < word1.Length || i < word2.Length; i++)
            {
                if (i < word1.Length)
                {
                    result += word1[i];
                }
                if (i < word2.Length)
                {
                    result += word2[i];
                }
            }
            return result;
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



