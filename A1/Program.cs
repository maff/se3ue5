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
            Counter Counter = new Counter();

            /* condition&action pairs */
            Counter.ConditionActions.Add(new CounterConditionAction(
                            new CounterCondition(CounterConditions.ValueGreaterThanThousand),
                            new CounterAction(CounterActions.ValueGreaterThanThousand)));

            Counter.ConditionActions.Add(new CounterConditionAction(
                            new CounterCondition(CounterConditions.ValueSmallerThanThousand),
                            new CounterAction(CounterActions.ValueSmallerThanThousand)));

            Counter.ConditionActions.Add(new CounterConditionAction(
                            new CounterCondition(CounterConditions.ValueEqualsThousand),
                            new CounterAction(CounterActions.ValueEqualsThousand)));

            /* event handlers */
            CounterObserver observer = new CounterObserver();
            Counter.Reset += new CounterEventHandler(observer.Reset);
            Counter.Increment += new CounterEventHandler(observer.Increment);
            Counter.EvenValue += new CounterEventHandler(observer.EvenValue);
            
            /* add some data */
            Counter.Add(50);
            Counter.Add();
            Counter.Add(-5);
            Counter.Add();
            Counter.Clear();
            Counter.Add(25);
            Counter.Add();
            Counter.Add();
            Counter.Add(1000);
            Counter.Add(-15);
            Counter.Add(-12);
            Counter.Add(-225);

            Console.ReadLine();
        }
    }
}
