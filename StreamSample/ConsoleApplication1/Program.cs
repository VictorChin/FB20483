using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Stream ms = new MemoryStream(100))
            {
                using (Stream fs = File.Open("test.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
                {
                    byte[] data = Encoding.UTF8.GetBytes("Hello六書world");
                    ms.Write(data, 0, data.Length);
                    ms.Write(new byte[]{13} , 0, 1);
                    ms.Write(new byte[] {10}, 0, 1);
                    ms.Write(data, 0, data.Length);

                    fs.Write(data, 0, data.Length);
                    fs.Write(new byte[] { 13 }, 0, 1);
                    fs.Write(new byte[] { 10 }, 0, 1);
                    fs.Write(data, 0, data.Length);

                    StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                    sw.WriteLine("Hello六書world");
                    sw.WriteLine("Hello六書world");
                    sw.WriteLine("Hello六書world");
                    sw.WriteLine("Hello六書world");
                    sw.Flush();
                    //ArrayList l = new ArrayList();
                  
                    //using (Rijndael myRijndael = Rijndael.Create())
                    //{
                    //    var somethingTransform =myRijndael.CreateEncryptor();
                    //    CryptoStream cs = new CryptoStream(fs, somethingTransform, CryptoStreamMode.Write);
                    //    StreamWriter sw2 = new StreamWriter(cs, Encoding.UTF8);
                    //    sw2.AutoFlush=true;
                    //    sw2.WriteLine("Hello六書world");
                    //}

                    var email = "victor@objectmage.c";
                    Console.WriteLine(email.IsEmail());

                    string[] urls = { @"http://www.yahoo.com", @"http://www.google.com", @"http://www.ebay.com", @"http://www.bing.com" };
                    BackgroundWorker worker = new BackgroundWorker();

                    worker.DoWork += (s, e) => { Console.WriteLine("test"); Thread.Sleep(10000); };
                    worker.RunWorkerCompleted += (s, e) => Console.WriteLine("Done");
                     
                    worker.RunWorkerAsync();
                    Stopwatch watch = new Stopwatch();
                    List<Task> tasks = new List<Task>();

                    Action x = () => { Console.WriteLine("test"); Thread.Sleep(10000); };
                    x.BeginInvoke((syncResult) => Console.WriteLine("DoneBeginInvoke"+syncResult.AsyncState),100);

                    MyClass c = new MyClass();
                    c.X();
                    ((IOne)c).X();
                    ((ITwo)c).X();
                    watch.Start();
                    foreach (string url in urls)
                    {
                        Task t = WriteFile(fs, url);
                        tasks.Add(t);
                    }
                    Task[] waiters= new Task[tasks.Count];
                    tasks.CopyTo(waiters);
                    Task.WaitAll(waiters);
                    watch.Stop();
                    Console.WriteLine("Time Taken: {0:###0}; Ticks :{1}",watch.ElapsedMilliseconds,watch.ElapsedTicks);

                    
                     
                }
            }

            Console.ReadLine();
        
}

        private static async Task WriteFile(Stream fs, string url)
        {
            WebClient client = new WebClient();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var result = await client.DownloadDataTaskAsync(url);
            watch.Stop();
            Console.WriteLine("Time Taken: {0:###0}; Ticks :{1}; {2}", watch.ElapsedMilliseconds, watch.ElapsedTicks,url);
            fs.Write(result, 0, result.Length);
          
           
        }

      
    }

    class Garage
    {
        Dictionary<Person, Car> _garage;
        public Car this[Person p]
        {
            get{ return _garage[p]; }

        }

    }
    public static class dummy
    {
        public static bool IsEmail(this String s,string regex = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$")
        {
            return Regex.IsMatch(s, regex);
        }
    }
    interface IOne
    {
        void X();
    }
    interface ITwo
    {
        void X();
    }
    class MyClass : IOne, ITwo
    {
        void IOne.X()
        {
            Console.WriteLine("Ione");
        }

        public void X()
        {
            Console.WriteLine("X");
        }
        void ITwo.X()
        {
            Console.WriteLine("ITwo");
        }
    }
}
