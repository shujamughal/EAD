using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
namespace SyncVsAsync_Lec60
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var timer = Stopwatch.StartNew();
            WriteLine($"Main Thread ID : { Thread.CurrentThread.ManagedThreadId}");

            var taskA = MethodA();
            var taskB = MethodB();
            var taskC = MethodC();
            // Task[] tasks = { taskA, taskB, taskC };
            //Task.WaitAll(tasks);
            Console.WriteLine(await taskA);
            Console.WriteLine(await taskB);
            Console.WriteLine(await taskC);
            WriteLine($"Time take {timer.ElapsedMilliseconds}");

        }

        static async Task<int> MethodA()
        {
            WriteLine("Starting Method A...");
            WriteLine($"A Thread ID : { Thread.CurrentThread.ManagedThreadId}");

            await Task.Delay(3000);
            WriteLine("Finished Method A...");
            return 30;
        }
        static async Task<int> MethodB()
        {
            WriteLine("Starting Method B...");
            WriteLine($"B Thread ID : { Thread.CurrentThread.ManagedThreadId}");

            await Task.Delay(2000);
            WriteLine("Finished Method B...");
            return 20;
        }

        static async Task<int> MethodC()
        {
            WriteLine("Starting Method C...");
            WriteLine($"C Thread ID : { Thread.CurrentThread.ManagedThreadId}");

            await Task.Delay(1000);
            WriteLine("Finished Method C...");
            return 10;
        }

    }
}
