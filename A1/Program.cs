using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            CounterObserver observer = new CounterObserver();

            counter.Reset += new ResetEventHandler(observer.Reset);
            counter.Increment += new IncrementEventHandler(observer.Increment);
            counter.EvenValue += new EvenValueEventHandler(observer.EvenValue);

            counter.Add(50);
            counter.Add();
            counter.Add();
            counter.Add();

            counter.Clear();
            counter.Add(25);
            counter.Add();
            counter.Add();

            Console.ReadLine();
        }
    }
}
