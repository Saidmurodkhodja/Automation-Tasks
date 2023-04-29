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
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Hello {input}");
            Console.ReadLine();
        }
    }
}
