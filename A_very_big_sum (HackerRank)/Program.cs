using System;
using System.ComponentModel.Design.Serialization;

namespace CSharp
{
   class Result 
   {
        public static long aVeryBigSum(List<long> ar)
        {
            long sum = 0;
           
            for (int i = 0; i < ar.ToArray().Length; i++)
            {
                sum += ar[i];
            }
            return sum;
        }
   }
   class Program 
    {    
        public static void Main(string[] args)
        { 
            List<long> ar = new List<long>() {1000000001, 1000000002, 1000000003, 1000000004, 1000000005};
            
            Console.Write(Result.aVeryBigSum(ar)); 
        }
    }
}








