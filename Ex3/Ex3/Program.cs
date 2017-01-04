using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number:");
            string input = Console.ReadLine();
            try
            {
                byte converted = Convert.ToByte(input);
                Console.WriteLine(Convert.ToString(converted, 16));
                Console.WriteLine(converted*converted);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter whole number less than or equal to 255");
            }
            catch (FormatException)
            {
                Console.WriteLine("WHOLE NUMBA!!");
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown Exception");
            }
          
           

        }
    }
}
