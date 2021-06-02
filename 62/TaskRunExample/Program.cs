using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskRunExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine($"Main Thread ID : { Thread.CurrentThread.ManagedThreadId}");
            //var task1=   Task.Run(SomeLibrary.LongRunningOpration);
            //var t2= Task.Run(SomeLibrary.LongRunningOprationWithData);
            //var t3 = Task.Run(() => SomeLibrary.LongRunningOprationWithInputData(5));


            //  Console.WriteLine(  await t2);
            // Console.WriteLine(await t3);
            var t4 = Task.Run(CPUIntensiveTask);
            await t4;

        }

        static void CPUIntensiveTask()
        {
            Console.WriteLine($"CPUIntensiveTask starts");
            Console.WriteLine($"CPUIntensiveTask Thread ID : { Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(5000);
            Console.WriteLine($"CPUIntensiveTask finish");


        }
    }
}
