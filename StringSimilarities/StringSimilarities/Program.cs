using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSimilarities
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int strLength = Convert.ToInt32(Console.ReadLine());

            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Make sure string lengths are the same.");
                return;
            }

            int[] counts = stringSimilarity(str1, str2, strLength);
        }
        static int[] stringSimilarity(string str1, string str2, int strLength)
        {
            List<int> counts = new List<int>();
            int total = 0;

            for (int i = 0; i < strLength; i++)
            {
                counts.Add((int)str2[i] - str1[i]);
            }

            foreach(int num in counts)
            {
                Console.Write(num + " ");
                total += num;
            }

            Console.WriteLine('\n');
            Console.WriteLine("Total: " + total);

            return counts.ToArray();
        }
    }
}
