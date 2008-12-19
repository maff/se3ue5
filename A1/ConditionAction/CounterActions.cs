using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class CounterActions
    {
        public static void ValueSmallerThanThousand(int actionCounter, int count)
        {
            PrintMessage(actionCounter, count, "Value is smaller than 1000.");
        }

        public static void ValueGreaterThanThousand(int actionCounter, int count)
        {
            PrintMessage(actionCounter, count, "Value is greater than 1000.");
        }

        public static void ValueEqualsThousand(int actionCounter, int count)
        {
            PrintMessage(actionCounter, count, "Value equals 1000.");
        }

        private static void PrintMessage(int actionCounter, int count, string message)
        {
            Console.WriteLine("Action  \t#{0}\t{1}\t{2}", actionCounter, count, message);
        }
    }
}
