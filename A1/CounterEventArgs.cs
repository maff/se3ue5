using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class CounterEventArgs : EventArgs
    {
        private int count;
        public int Count
        {
            get
            {
                return this.count;
            }
            set {}
        }

        private int changed;
        public int Changed
        {
            get
            {
                return this.changed;
            }
            set { }
        }

        private int actionCounter;
        public int ActionCounter
        {
            get
            {
                return this.actionCounter;
            }
            set { }
        }

        public CounterEventArgs(int actionCounter, int count)
        {
            this.actionCounter = actionCounter;
            this.count = count;
        }

        public CounterEventArgs(int actionCounter, int count, int changed)
        {
            this.actionCounter = actionCounter;
            this.changed = changed;
            this.count = count;
        }
    }
}