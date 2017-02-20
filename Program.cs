using System;
using GuruDev;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();



            /*Insertion Sort Test */
            int[] data1 = new int[] { 1, 2, 3, 4, 5, 6 };
            PrintArray(data1);
            Console.WriteLine();
            PrintArray(InsertionSort.Sort(data1));

            string str = "myName";
            Console.WriteLine();
            Console.WriteLine(InsertionSort.Sort(str));
            /*End of your code */

            sw.Stop();

            Console.WriteLine("\nTime taken: {0}ms", sw.Elapsed.TotalMilliseconds);
        }

        #region Print Array
        static void PrintArray(int[] arr)
        {
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.Write("{0} ", item);
            }
        }

        static void PrintArray(char[] arr)
        {
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.Write("{0} ", item);
            }
        }

        static void PrintArray(string[] arr)
        {
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.Write("{0} ", item);
            }
        }
        #endregion
    }
}
