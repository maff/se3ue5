using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class CounterObserver
    {
        internal void Reset(object o, CounterEventArgs c)
        {
            PrintMessage(c.ActionCounter, c.Count, "Counter was reset.");
        }

        internal void Increment(object o, CounterEventArgs c)
        {
            if(c.Changed >= 0)
                PrintMessage(c.ActionCounter, c.Count, "Counter was incremented by " + c.Changed + ".");
            else
                PrintMessage(c.ActionCounter, c.Count, "Counter was decremented by " + Math.Abs(c.Changed) + ".");
        }

        internal void EvenValue(object o, CounterEventArgs c)
        {
            PrintMessage(c.ActionCounter, c.Count, "Counter value is even.");
        }

        internal void PrintMessage(int actionCounter, int count, string message)
        {
            Console.WriteLine("Observer\t#{0} {1}\t{2}", actionCounter, count, message);
        }
    }
}
