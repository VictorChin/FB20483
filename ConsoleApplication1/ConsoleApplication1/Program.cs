using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
    class Program
    {
      
        static void Main(string[] args)
        {
            //DateTime dob = new DateTime(64, 06, 13, new TaiwanLunisolarCalendar());
            //Console.WriteLine(dob.Year);
            //Console.WriteLine(dob.Month);
            //Console.WriteLine(dob.Day);
            //Console.WriteLine(dob.DayOfWeek);
            DateTime rightNow = DateTime.Now;
            
            if ((rightNow.DayOfWeek == DayOfWeek.Tuesday) ||
                (rightNow.DayOfWeek == DayOfWeek.Friday)
                )
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Title = "DemoApp";
                Console.WriteLine("Hello Tuesday");
            }
            else if (
                (rightNow.DayOfWeek == DayOfWeek.Wednesday) &&
                (rightNow.TimeOfDay.Hours > 12)
                )
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Title = "DemoApp";
                Console.WriteLine("Hello Wednesday Afternoon");
            }

            while (true)
            {

            }
            for (int i = 0; i < length; i++)
            {

            }
            foreach (var item in collection)
            {

            }
            switch (switch_on)
            {
                default:
            }
        }
    }
}
