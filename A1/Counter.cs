using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Counter
    {
        internal event CounterEventHandler Reset;
        internal event CounterEventHandler Increment;
        internal event CounterEventHandler EvenValue;

        private int actionCounter;
        public int ActionCounter
        {
            get
            {
                return this.actionCounter;
            }
            set {}
        }

        private int count = 0;
        public int Count
        {
            get
            {
                return this.count;
            }
            set
            {
                this.count = value;
            }
        }

        public void Add()
        {
            this.Add(1);
        }

        public void Add(int value)
        {
            this.Count += value;
            this.actionCounter++;

            OnIncrement(new CounterEventArgs(this.ActionCounter, this.Count, value));

            if (this.Count % 2 == 0)
                OnEvenValue(new CounterEventArgs(this.ActionCounter, this.Count));
        }

        public void Clear()
        {
            this.Count = 0;
            this.actionCounter++;

            OnReset(new CounterEventArgs(this.ActionCounter, this.Count));
        }

        private void OnReset(CounterEventArgs c)
        {
            if (Reset != null)
                Reset(this, c);
        }

        private void OnIncrement(CounterEventArgs c)
        {
            if (Increment != null)
                Increment(this, c);
        }

        private void OnEvenValue(CounterEventArgs c)
        {
            if (EvenValue != null)
                EvenValue(this, c);
        }
    }
}
