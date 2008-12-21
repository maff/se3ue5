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

            /* condition&action pairs */
            counter.ConditionActions.Add(new CounterConditionAction(
                            new CounterCondition(CounterConditions.ValueGreaterThanThousand),
                            new CounterAction(CounterActions.ValueGreaterThanThousand)));

            counter.ConditionActions.Add(new CounterConditionAction(
                            new CounterCondition(CounterConditions.ValueSmallerThanThousand),
                            new CounterAction(CounterActions.ValueSmallerThanThousand)));

            counter.ConditionActions.Add(new CounterConditionAction(
                            new CounterCondition(CounterConditions.ValueEqualsThousand),
                            new CounterAction(CounterActions.ValueEqualsThousand)));

            /* event handlers */
            CounterObserver observer = new CounterObserver();
            counter.Reset += new CounterEventHandler(observer.Reset);
            counter.Increment += new CounterEventHandler(observer.Increment);
            counter.EvenValue += new CounterEventHandler(observer.EvenValue);
            
            /* add some data */
            counter.Add(50);
            counter.Add();
            counter.Add(-5);
            counter.Add();
            counter.Clear();
            counter.Add(25);
            counter.Add();
            counter.Add();
            counter.Add(1000);
            counter.Add(-15);
            counter.Add(-12);
            counter.Add(-225);

            Console.ReadLine();
        }
    }
}
