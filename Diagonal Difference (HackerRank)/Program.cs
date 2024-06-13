using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;

namespace CSharp
{
   class Result
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Count; i++) 
            {
                result += arr[i][i] - arr[i][arr.Count -1 -i];
            }
            return Math.Abs(result);
        }
    }
   class Program 
    {    
        public static void Main(string[] args)
        { 
            List<List<int>> arr = new List<List<int>> {
                new List<int>() {1,2,3},
                new List<int>() {4,5,6},
                new List<int>() {9,8,9}
            };
            Console.WriteLine(Result.diagonalDifference(arr));
        }
    }
}








