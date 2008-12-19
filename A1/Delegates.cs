using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    delegate bool CounterConstraint(int value);
    delegate void CounterAction();
    delegate void CounterEventHandler(object o, CounterEventArgs e);
}
