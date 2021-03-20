using System;

namespace week_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(counter(100));
            Console.WriteLine(counter(1000));
            Console.WriteLine(counter(1000000));
        }

        public static long counter(int n){
            int k = 1;
            long result = 0;
            while(k <= (n/2)){
                result += 2 * k++;
            }
            return result;
        }
    }
}
