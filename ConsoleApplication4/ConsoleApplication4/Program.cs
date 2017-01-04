using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            President bush = new President()
            {
                Name = "George W. Bush",
                Tolerance = 5
            };
            President trump = new President()
            {
                Name = "Donald J. Trump",
                Tolerance = 3
            };
            Button redButton = new Button();
            trump.PressingButton += redButton.Press;
            trump.ReceiveMessage("small hand");
            trump.ReceiveMessage("short hair");
            trump.ReceiveMessage("short hair");
            trump.ReceiveMessage("short hair");
        }
    }


}
