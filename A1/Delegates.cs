using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    delegate bool CounterCondition(int value);
    delegate void CounterAction(int actionCounter, int count);
    delegate void CounterEventHandler(object o, CounterEventArgs e);
}
