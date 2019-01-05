using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalArcade
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 3, 6, -2, -5, 7, 3 };
            Console.WriteLine(adjacentElementsProduct(inputArray));

        }

        int add(int param1, int param2)
        {
            return (param1 + param2);
        }

        int centuryFromYear(int year)
        {
            if (year <= 100) return 1;
            if (year % 100 == 0) return year / 100;
            return year / 100 + 1;
        }

        bool checkPalindrome(string inputString)
        {
            if (string.Join("", inputString.ToCharArray().Reverse()) == inputString) return true;
            return false;
        }

        static int adjacentElementsProduct(int[] inputArray)
        {
            int highest = -1000;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if(inputArray[i] * inputArray[i + 1] > highest)
                {
                    highest = inputArray[i] * inputArray[i + 1];
                }
            }
            return highest;
        }
    }
}
