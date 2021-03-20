using System;
using System.Diagnostics;
namespace week_2_sorting.Sort
{
    public class InsertionSort
    {
        public static void sort<A>(A[] arr) where A : IComparable
        {
            for (int i = 1; i < arr.Length; ++i)
            {
                A key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while(j >= 0 && arr[j].CompareTo(key) > 0)
                // while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
    }
}