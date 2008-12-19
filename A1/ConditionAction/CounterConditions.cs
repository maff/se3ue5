using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class CounterConditions
    {
        public static bool ValueSmallerThanThousand(int val)
        {
            if (val < 1000)
                return true;

            return false;
        }

        public static bool ValueGreaterThanThousand(int val)
        {
            if (val > 1000)
                return true;

            return false;
        }

        public static bool ValueEqualsThousand(int val)
        {
            if (val == 1000)
                return true;

            return false;
        }
    }
}
