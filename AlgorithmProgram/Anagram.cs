using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class Anagram
    {
        public void CheckAnagram()
        {
            Console.WriteLine("Enter the first word ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the seconnd word");
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1.Equals(val2))
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("not Anagram");
            }
        }
    }
}
