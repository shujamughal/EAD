using System;
using System.Collections;

namespace Lecture26
{
    class MyEventArgs : EventArgs {
        public int Count { get; set; }

    }

    delegate void MyEventHandler(object sender, MyEventArgs e);
    //delegate void MyEventHandler();
    //publisher
    class MyArrayList : ArrayList {
        public event MyEventHandler Added;
        MyEventArgs e = new MyEventArgs();
        public MyArrayList() {

            e.Count = 0;
        }
        void OnAdded() {
            if (Added != null)
            {
                e.Count = e.Count + 1;
                Added(this, e);
            }
        }
        public override int Add(object value)
        {
            OnAdded();
            return base.Add(value);
        }
    }
    //subscriber
    class Program
    {
        static void MyHandler(object sender, MyEventArgs e) { 
            Console.WriteLine($"object added by {sender.ToString()} and count :{e.Count}");
        }
        static void Main(string[] args)
        {
            MyArrayList list = new MyArrayList();
            list.Added += MyHandler;
            list.Add(1);
            list.Add("1");
            list.Add("1234");

        }
    }
}
