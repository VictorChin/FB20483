using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Expression:");
            string expr = Console.ReadLine();
            Console.WriteLine("Enter Word:");
            string word = Console.ReadLine();

            if (Regex.IsMatch(word, expr))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
