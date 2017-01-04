using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    public class Button
    {
        public void Press(ConsoleColor c)
        {
            if (c == ConsoleColor.Red)
            { Console.WriteLine("Fire Nuke"); }
            else
            {
             Console.WriteLine("Happy New Year");
            }
        }
    }
}