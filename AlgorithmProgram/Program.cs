using System;

namespace AlgorithmProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Problems Program");
            String str = "TEST";
            int n = str.Length;
            PermutationOfString.Permute(str, 0, n - 1);

        }
    }
}