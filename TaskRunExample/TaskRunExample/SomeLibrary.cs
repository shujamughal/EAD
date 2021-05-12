using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskRunExample
{
    class SomeLibrary
    {
        static public void LongRunningOpration()
        {
            Console.WriteLine($"LongRunningOpration starts");
            Console.WriteLine($"LongRunningOpration Thread ID : { Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(5000);
            Console.WriteLine($"LongRunningOpration finish");

        }

        static public int LongRunningOprationWithData()
        {
            Console.WriteLine($"LongRunningOprationWithData starts");
            Console.WriteLine($"LongRunningOpration Thread ID : { Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(5000);
            Console.WriteLine($"LongRunningOprationWithData finish");
            return 10;
        }

        static public int LongRunningOprationWithInputData(int someInputData)
        {
            Console.WriteLine($"LongRunningOprationWith InputData starts");
            Console.WriteLine($"LongRunningOpration Thread ID : { Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(5000);
            Console.WriteLine($"LongRunningOprationWith InputData finish");
            return 10 + someInputData;
        }
    }
}
