using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;
using System.Runtime.Versioning;

namespace CSharp
{
    public class Solution 
    {
        public bool IsSubsequence(string s, string t)
        {
            int i = 0;
            int j = 0;
            while (i < s.Length && j < t.Length)
            {
                if(s[i] == t[j])
                {
                    i++;
                }  
                j++;
            } 
            return i == s.Length ? true : false;
        }
    }
    class Program 
    {    
        public static void Main(string[] args)
        { 
            Solution testcase1 = new Solution(); 
            string s = "axc";
            string t = "ahbgdc";
            Console.WriteLine(testcase1.IsSubsequence(s, t));
            
        }
    }
}











