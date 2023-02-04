using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
namespace SyncVsAsync_Lec60
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = Stopwatch.StartNew();

           /* MethodA();
            MethodB();
            MethodC();//*/
            var  taskA = MethodA();
            var taskB = MethodB();
            var taskC = MethodC();
            Task[] tasks = { taskA, taskB, taskC };
            Task.WaitAll(tasks);//*/
            WriteLine($"Time take {timer.ElapsedMilliseconds}");
           
        }

        /*static void MethodA()
        {
            WriteLine("Starting Method A...");
            Thread.Sleep(3000);
            WriteLine("Finished Method A...");
        }
        static void MethodB()
        {
            WriteLine("Starting Method B...");
            Thread.Sleep(2000);
            WriteLine("Finished Method B...");
        }

        static void MethodC()
        {
            WriteLine("Starting Method C...");
            Thread.Sleep(1000);            
            WriteLine("Finished Method C...");
        }//*/
       static async Task MethodA()
        {
            WriteLine("Starting Method A...");
           await Task.Delay(3000);
            WriteLine("Finished Method A...");
        }
        static async Task MethodB()
        {
            WriteLine("Starting Method B...");
            await Task.Delay(2000);
            WriteLine("Finished Method B...");
        }
       
        static async Task MethodC()
        {
            WriteLine("Starting Method C...");
            await Task.Delay(1000);
            WriteLine("Finished Method C...");
        }//*/

    }
}
