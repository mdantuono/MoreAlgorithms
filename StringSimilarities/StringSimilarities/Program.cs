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

            for (int i = 0; i < strLength; i++)
            {
                counts.Add((int)str1[i] - str2[i]);
            }

            foreach(int num in counts)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine('\n');

            return counts.ToArray();
        }
    }
}
