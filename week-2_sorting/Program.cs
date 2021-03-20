using System;
using System.Diagnostics;
using week_2_sorting.Utility;
using week_2_sorting.Sort;

namespace week_2_sorting
{
    class Program
    {
        static void Main(string[] args)
        {   
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("\n----------- Selection Sort ----------");

            stopwatch.Start();
            string[] data = FileUtility.toStringArray(path:"Data/test-data.txt");
            stopwatch.Stop();

            Console.WriteLine("Time to read file: " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            SelectionSort.sortAlphabetically(data);
            stopwatch.Stop();

            Console.WriteLine("Time to sort: " + stopwatch.Elapsed);
            stopwatch.Reset();
            // SelectionSort.printArray(data);


            Console.WriteLine("\n----------- Insertion Sort ----------");
            stopwatch.Start();
            string[] new_data = FileUtility.toStringArray(path:"Data/test-data.txt");
            stopwatch.Stop();

            Console.WriteLine("Time to read file: " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            InsertionSort.sort(new_data);
            stopwatch.Stop();
            Console.WriteLine("Time to sort: " + stopwatch.Elapsed);

            Console.WriteLine("\n----------- Merge Sort ----------");
            stopwatch.Start();
            string[] mergeSort = FileUtility.toStringArray(path:"Data/test-data.txt");
            stopwatch.Stop();
            Console.WriteLine("Time to sort: " + stopwatch.Elapsed + "\n");
            
        }
    }
}
