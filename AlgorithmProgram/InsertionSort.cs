using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class InsertionSort
    {
        public void Sort(int[] sortArray)
        {
            int n = sortArray.Length, i, j, val, flag;
            Console.WriteLine("Insertion Sort");
            Console.WriteLine("Initial arrai is : ");
            for (i = 0; i < sortArray.Length; i++)
            {
                Console.WriteLine(sortArray[i]);
            }
            for (i = 1; i < sortArray.Length; i++)
            {
                val = sortArray[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < sortArray[j])
                    {
                        sortArray[j + 1] = sortArray[j];
                        j--;
                        sortArray[j + 1] = val;
                    }
                    else
                    {
                        flag = 1;
                    }
                }

            }
            Console.WriteLine("\n Sort array is :");
            for (i = 0; i < sortArray.Length; i++)
            {
                Console.Write(sortArray[i] + " ");
            }
        }
    }
}
