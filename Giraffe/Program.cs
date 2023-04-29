using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sequence of symbols:");
            string input = Console.ReadLine();

            int maxLength = 1;
            int currentLength = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    maxLength = Math.Max(maxLength, currentLength);
                    currentLength = 1;
                }
            }

            maxLength = Math.Max(maxLength, currentLength);

            Console.WriteLine("The maximum number of unequal consecutive characters per line is: " + maxLength);
            Console.ReadLine();
        }
    }
}