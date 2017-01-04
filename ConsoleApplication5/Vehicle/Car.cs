using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicle
{
    public abstract class Car : ICar,IComparable<Car>
    {
        public int Price { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine("Moving forward");
        }
        protected internal int x;
        public void Brake()
        {
            Console.WriteLine("Stopping the Car");
        }

        public int CompareTo(Car other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }
}