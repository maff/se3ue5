using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    delegate void ResetEventHandler(object o, CounterEventArgs e);
    delegate void IncrementEventHandler(object o, CounterEventArgs e);
    delegate void EvenValueEventHandler(object o, CounterEventArgs e);

    class Counter
    {
        internal event ResetEventHandler Reset;
        internal event IncrementEventHandler Increment;
        internal event EvenValueEventHandler EvenValue;

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

            OnIncrement(new CounterEventArgs(this.Count, value));

            if (this.Count % 2 == 0)
                OnEvenValue(new CounterEventArgs(this.Count));
        }

        public void Clear()
        {
            this.Count = 0;
            OnReset(new CounterEventArgs(this.Count));
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
