using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    delegate int blah(int x, int y);

    class Program
    {
        //static int Impl(int x, int y)
        //{
        //    return x + y;
        //}
        public static void Test(blah J)
        {
            int result = J(100, 13);
        }
        static void Main(string[] args)
        {
            blah something = (a,b)=>a+b;
            blah somethingElse = (a, b) => a * b;


            List<Car> inventory = new List<Car>() {
                new Car("Car1", ConsoleColor.Black, FuelType.DieselPremium),
                new SportsCar(),
                new Car("Car3", default(ConsoleColor), kindOfFuel: FuelType.PetroPremium)
            };
            foreach (Car item in inventory)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
    class Car
    {
        public override string ToString()
        {
            return $"My name is {NickName}, I am {Age.Milliseconds} old, Color: {Color.ToString()}";
        }
        static readonly int Wheels = 4;
        public ConsoleColor Color { get; private set; }
        public TimeSpan Age {
            get {
                return System.DateTime.Now - _dateOfManufacture;
                }
                            }
        private DateTime _dateOfManufacture= System.DateTime.Now;
        public FuelType KindOfFuel { get; private set; }
        public string NickName { get; set; }
        public Car(string nickName,ConsoleColor carColor=ConsoleColor.Red,
            FuelType kindOfFuel=FuelType.PetroRegular)
        {
            this.NickName = nickName;
            this.Color = carColor;
            this.KindOfFuel = kindOfFuel;
        }
        public Car() : this("DefaultName")
        { }
        
      
        //public Car(string nickName, ConsoleColor carColor):
        //    this(nickName,carColor,FuelType.PetroRegular)
        //{
        //}
        //public Car(string nickName):
        //    this(nickName, ConsoleColor.Red)
        //{
        //}

    }
    enum FuelType
    {
        PetroRegular,
        PetroPremium,
        DieselRegular,
        DieselPremium
    }
    class SportsCar : Car
    {
        public bool Turbo => true;
        public override string ToString()
        {

            return base.ToString() + ":I am sporty";
        }
    }
}
