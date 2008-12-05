using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Counter
    {
        private int _count = 0;
        public int count
        {
            get
            {
                return this._count;
            }
            set
            {
                this._count = value;
            }
        }

        public void Add()
        {
            this.Add(1);
        }

        public void Add(int value)
        {
            this.count += value;
        }

        public void Clear()
        {
            this.count = 0;
        }

        public void Print()
        {
            Console.WriteLine("[Counter:]\t{0}", this.count);
        }
    }
}
