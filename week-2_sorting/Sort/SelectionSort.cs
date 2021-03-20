using System;
namespace week_2_sorting.Sort
{
    public class SelectionSort
    {
        public static void sortLength(string[] arr)
        {
            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // Find the minimum element in unsorted array 
                int min_idx = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j].Length < arr[min_idx].Length)
                        min_idx = j;

                // Swap the found minimum element with the first 
                // element 
                string temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }

        public static void sortAlphabetically<A>(A[] arr) where A : IComparable
        {
            //pos_min is short for position of min
            int pos_min;
            A temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                pos_min = i; //set pos_min to the current index of array

                for (int j = i + 1; j < arr.Length; j++)
                {
                    // We now use 'CompareTo' instead of '<'
                    if (arr[j].CompareTo(arr[pos_min]) < 0)
                    {
                        //pos_min will keep track of the index that min is in, this is needed when a swap happens
                        pos_min = j;
                    }
                }

                //if pos_min no longer equals i than a smaller value must have been found, so a swap must occur
                if (pos_min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[pos_min];
                    arr[pos_min] = temp;
                }
            }
        }


        public static void printArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}