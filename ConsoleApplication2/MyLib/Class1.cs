using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Util
    {
        public string GetFizzBuzz(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                return ("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                return ("Fizz");
            }
            else if (i % 5 == 0)
            {
                return ("Buzz");
            }
            else
            {
                return (i.ToString());
            }
        }
    }
}
