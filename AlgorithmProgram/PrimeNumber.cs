using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class PrimeNumber
    {
        public static void PrimeNum(int N1, int N2)
        {
            for (int j = N1; j <= N2; j++)
            {
                int numOfFact = 0;
                for (int i = 1; i <= j; i++)
                {
                    int rimainder = j % i;

                    if (rimainder == 0)
                    {
                        numOfFact++;
                    }

                }

                if (numOfFact == 2)
                {
                    //return (true);
                    Console.WriteLine("{0} is prime "+j );
                }
                else
                {
                    //return (false);
                    Console.WriteLine("{0} not prime " +j);
                }
            }
        }
    }
}
