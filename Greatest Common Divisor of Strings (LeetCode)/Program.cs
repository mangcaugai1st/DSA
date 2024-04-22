using System;
using System.Security.Cryptography.X509Certificates;

namespace CSharp
{
    public class Solution
    {
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1)
            {
                return "";
            }
            return str1.Substring(0, GCD(str1.Length, str2.Length));   
        }
        public int GCD(int n1, int n2)   
        {
            while (n1 != 0 && n2 != 0)
            {
                if (n1 > n2)
                {
                    n1 %= n2;
                }
                else 
                {
                    n2 %= n1;
                }
            }
            return n1 | n2;
        }
    }
    class Program
    {   
        public static void Main(string[] args)
        {
            Solution testcase = new Solution(); 

            Console.WriteLine(testcase.GcdOfStrings("ABC", "ABC")); 
            Console.WriteLine(testcase.GcdOfStrings("ABABAB", "ABAB"));  
            Console.WriteLine(testcase.GcdOfStrings("LEET", "CODE")); 
        }
    }
}








