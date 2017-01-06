using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitExample
{
    class Program
    {
        static void Main()
        {
            var demo = new AsyncAwaitDemo();
            //            Task.Run(()=>demo.DoStuff());
            Task.Run(() => demo.DoStuff2());
            while (true)
            {
                Console.WriteLine("Doing Stuff on the Main Thread...................");
                Thread.Sleep(5000);
            }
        }
    }

    public class AsyncAwaitDemo
    {
        public async Task DoStuff()
        {
            //await Task.Run(() =>
            //{
            //    LongRunningOperation(1);
            //    LongRunningOperation(10000);
            //    LongRunningOperation(10000000);

            //});
            Task[] tasks = {
                Task.Run(() => {  LongRunningOperation(1);}),
                Task.Run(() => {  LongRunningOperation(1000);}),
                Task.Run(() => {  LongRunningOperation(1000000);})
                };
             Task.WaitAll(tasks);
        }
        public async Task DoStuff2()
        {
            //await Task.Run(() =>
            //{
            //    LongRunningOperation(1);
            //    LongRunningOperation(10000);
            //    LongRunningOperation(10000000);

            //});
            CancellationTokenSource cts = new CancellationTokenSource();

            Task.Run(() => { CancelOperation(cts.Token); });
            await Task.Delay(3000);
            Console.WriteLine("Requesting Cancellation...");
            cts.Cancel();
           

        }

        private static async Task<string> CancelOperation(CancellationToken token)
        {
            int counter = 0;

            for (counter = 0; counter < 500; counter++)
            {
                Console.WriteLine(counter);
                await Task.Delay(100);
                token.ThrowIfCancellationRequested();
            }
            
            return "CancelCounter = " + counter;
        }

        private static async Task<string> LongRunningOperation(int i)
        {
            int counter=i;

            for (counter = 0; counter < 500; counter++)
            {
                Console.WriteLine(counter);
                await Task.Delay(100);
            }

            return "Counter = " + counter;
        }
    }
}