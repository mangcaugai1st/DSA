using System;
using System.Collections.Generic;
using System.Globalization;

namespace CSharp
{
    class Program
    {
        public static void Bubble_Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;                            
                    }
                }
            }
        }
        public static void Print_Array(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
        public static void Main(string[] args)
        {
            int[] array = new [] {2,7,4,5,9};
            Bubble_Sort(array);
            Print_Array(array);
        }
    }
}



