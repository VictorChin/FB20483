using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle;

namespace ConsoleApplication5
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Car aCar = new SportsCar(); // Upcast is implicit; widening
            SportsCar porsche = aCar as SportsCar; //Downcast, narrow
            
            //
            //SportsCar porsche = (SportsCar)aCar; throws exception when conversion fails
            //DoSomething(porsche);
            Duck d = new Duck();
            int a = 100;
            Test(ref a);
            Console.WriteLine(a);
            Car b;
            Test2(out b);
            Console.WriteLine(b.Price);


            DoSomething(d);
            if (porsche != null)
            { porsche.Turbo(); }
            int x = int.MaxValue;
            long l = x;
            SortedSet<ICar> myCollection2 = new SortedSet<ICar>();
            SortedSet<Car> myCollection = new SortedSet<Car>();
            myCollection.Add(new SportsCar() {  Price=100});
            myCollection.Add(new ExoticSportsCar() { Price = 150 });
            myCollection.Add(new Truck() { Price = 120 });
            foreach (var item in myCollection)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
        static void DoSomething(ICar _car)
        {
            _car.Drive();
            if (_car is SportsCar)
            {
                SportsCar porsche = _car as SportsCar;
                porsche?.Drive();
                porsche?.Brake();

                Console.WriteLine("Turbo Called");

            }
            if (_car is Car)
            {
                _car.Drive();
                _car.Brake();
                Console.WriteLine("Drive Called");
            }
        }
        //static void DoSomething(SportsCar _car)
        //{
        //    if (_car is SportsCar)
        //    {
        //        SportsCar porsche = _car as SportsCar;
        //        porsche?.Turbo();
        //        Console.WriteLine("Turbo Called");
        //    }
        //    if (_car is Car)
        //    {
        //        _car.Drive();
        //        Console.WriteLine("Drive Called");
        //    }
        //}
        static void Test(ref int x)
        {
            x = x + 100;
            Console.WriteLine(x);
        }
        static void Test2(out Car x)
        {
            x = new SportsCar();
            x.Price = x.Price + 100;
            Console.WriteLine(x.Price);
        }
    }
}
