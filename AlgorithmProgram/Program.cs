using System;

namespace AlgorithmProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Problems Program");

            //Problem-4

            int[] arr = { 1, 2, 6, 4, 3, 6, 7, 9, };
            InsertionSort insertionSort = new InsertionSort();
            insertionSort.Sort(arr);

        }
    }
}