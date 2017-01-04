using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            int tryCount = 0;
            int numberToGuess = r.Next(1, 101);
            while (tryCount  < 10)
            {
                Console.WriteLine($"Try {tryCount}");
                Console.WriteLine("Guess a number!");
                int guess;
                int.TryParse(Console.ReadLine(), out guess);
                if (guess > numberToGuess)
                {
                    Console.WriteLine("Too HIGH!!");
                }
                else if (guess < numberToGuess)
                {
                    Console.WriteLine("Too low");

                }
                else if (guess == numberToGuess)
                { Console.WriteLine("You win");
                    break;
                }
                tryCount++;
            }
            Console.ReadLine();
        }
    }
}
