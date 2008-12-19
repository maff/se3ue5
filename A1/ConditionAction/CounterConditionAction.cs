using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class CounterConditionAction
    {
        public CounterCondition condition;
        public CounterAction action;

        public CounterConditionAction(CounterCondition c, CounterAction a)
        {
            condition = c;
            action = a;
        }
    }
}
