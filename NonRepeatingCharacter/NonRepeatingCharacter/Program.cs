using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "abcabc";

            /*  METHOD 1. */
            char[] uniqueLetters = input.Distinct().ToArray();
            foreach (char letter in uniqueLetters)
            {
                int count = input.Count(x => x == letter);
                if (count == 1)
                {
                    Console.WriteLine(letter + " is the first non-repeating character");
                    return;
                }
            }
            Console.WriteLine("No non-repeating characters");
            return;

            /* METHOD 2. */
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        bool seen = false;
        //        for (int n = 0; n < input.Length; n++)
        //        {
        //            if (input[i] == input[n])
        //            {
        //                seen = true;
        //                if (seen)
        //                {
                            
        //                }
        //                Console.WriteLine(input[i] + " is the first non-repeating character.");
        //                return;
        //            }
        //            break;
        //        }

        //        if (i == input.Length - 2)
        //        {
        //            Console.WriteLine(input[i + 1] + " is the first non-repeating character.");
        //        }
        //    }

        //    Console.WriteLine("No non-repeating characters.");
        //    return;
        }
    }
}
