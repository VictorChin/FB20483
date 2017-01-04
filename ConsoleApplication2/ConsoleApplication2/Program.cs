using MyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   

    class Program
    {

        static void Main(string[] args)
        {
            Util myInstance;
            myInstance= new Util();
            Util myOtherInstance;
            myOtherInstance = myInstance;
            for (int i = 1; i <= 50; i++)
            {
                Console.Write($"{myInstance.GetFizzBuzz(i)},");
            }
            
            Console.ReadLine();
        }

       
    }
    
}
