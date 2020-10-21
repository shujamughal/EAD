/* using System;
/*
Microsoft introduced some pre-built delegates so that we don't have to declare delegates
every time. Action is one of the pre-built delegates.

Action in C# represents a delegate that has void return type and optional parameters. 
There are two variants of Action delegate.

1-Action
2-Action<in T>

1- Action
First variant is non-generic delegate that takes no parameters and has void return type. 
In this Action delegate, we can store only those methods which has no parameters and 
void return type.

2- Action<in T>

The second variant is a family of 16 generic delegates.
These delegates can take upto 16 parameters and all have void return type.
 //


namespace Lecture20
{
    class Program
    {
        public static void DoWorkWithOneParameter(int arg)
        {
            Console.WriteLine(arg);
        }

        public static void DoWorkWithTwoParameters(int arg1, int arg2)
        {
            Console.WriteLine(arg1 + "-" + arg2);
        }

        public static void DoWorkWithThreeParameters(int arg1, int arg2, int arg3)
        {
            Console.WriteLine(arg1 + "-" + arg2 + "-" + arg3);
        }
        public static void DoWork()
        {
            Console.WriteLine("Hi, I am doing work.");
        }
        static void Main(string[] args)
        {
            Action doWorkAction = new Action(DoWork);
            doWorkAction(); //Print "Hi, I am doing work."

            Action<int> firstAction = DoWorkWithOneParameter;
            Action<int, int> secondAction = DoWorkWithTwoParameters;
            Action<int, int, int> thirdAction = DoWorkWithThreeParameters;

            firstAction(1); // Print 1
            secondAction(1, 2); // Print 1-2
            thirdAction(1, 2, 3); //Print 1-2-3

        }
    }
}*/
