using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicle
{
    public class Duck : ICar
    {
       
        void ICar.Brake()//implement interface members explicitly
        {
       
            Console.WriteLine("Duck Brake");
        }

        void ICar.Drive()
        {
            Console.WriteLine("Duck Drive");
        }
    }
}