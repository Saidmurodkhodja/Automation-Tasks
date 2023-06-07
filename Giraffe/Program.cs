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
            Console.Write("Please enter a sequence of symbols: "); 
            string input = Console.ReadLine(); // lets the user to enter string

            int maxLength = 1; // keep track of the maximum and current lengths of unequal consecutive characters
            int currentLength = 1; // keep track of the maximum and current lengths of unequal consecutive characters

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    maxLength = Math.Max(maxLength, currentLength); // maxLength is updated if currentLength is greater than the current maxLength, and currentLength is reset to 1
                    currentLength = 1;
                }
            }

            maxLength = Math.Max(maxLength, currentLength);

            Console.WriteLine("The maximum number of unequal consecutive characters per line is: " + maxLength);
            Console.ReadLine();
        }
    }
}
