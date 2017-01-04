using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicle
{
    public class SportsCar : Car
    {
        
        public void Turbo()
        {
            Console.WriteLine("Turbo vroomm");
           
        }
         
        public override void Drive()
        {
            base.Drive();
            Console.WriteLine("SportsCar Drive");
        }
        
        public new void Brake()
        {
            Console.WriteLine("SportsCar Stop");
        }
    }
}