using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> myDict = new Dictionary<string,string>();
            myDict.Add("Apple", "Ahpo");
            myDict.Add("Fried", "Fly");
            myDict.Add("Rice",  "Rye");
            myDict.Add("Victor", "Weetah");
            Console.WriteLine($"Chinese says {myDict["Apple"]}");
            string chineseWord;
            if (myDict.TryGetValue("Victor", out chineseWord))
            {
                Console.WriteLine(chineseWord);
            }
            foreach (var item in myDict)
            {
                Console.WriteLine($"{item.Key} : {item.Value }");
            }
            Queue<string> carWash = new Queue<string>();
            carWash.Enqueue("ABC");
            carWash.Enqueue("DEF");
            carWash.Enqueue("DEFG");
            carWash.Enqueue("DEFGHI");
            carWash.Enqueue("DEFGHIJ");
           
            string aThing = carWash.Peek();
            aThing = carWash.Dequeue();

            foreach (var item in carWash)
            {
                Console.WriteLine(item);
            }

            List<string> myGuest = new List<string>
                { "Tomas","James","Douglas", "Percy", "Harold", "Henry" };

            BinaryFormatter bf = new BinaryFormatter();
            Console.WriteLine(JsonConvert.SerializeObject(myGuest)); 
            bf.Serialize(File.OpenWrite("C:\\Test\\guest.bin"), myGuest);

            foreach (var item in myGuest.Where(s=>s.EndsWith("s")))
            {
                Console.WriteLine("Ends with s:"+ item);
            }
            Console.ReadLine();
        }
        

    }
    [Serializable]
    class Customer :ISerializable {
        [NonSerialized]
        public int SSN;

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
    class Order { }
}
