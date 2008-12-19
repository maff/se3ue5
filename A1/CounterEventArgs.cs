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

        public CounterEventArgs(int count)
        {
            this.count = count;
        }

        public CounterEventArgs(int count, int changed)
        {
            this.changed = changed;
            this.count = count;
        }
    }
}