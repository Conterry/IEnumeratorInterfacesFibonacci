using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FibonacciIEnumerator
{
    public class FibonacciIterator : IEnumerator
    {
        private int n;
        private int past;
        private int iterator;
        private int CurrentEn;

        public FibonacciIterator(int N)
        {
            this.n = N;
            this.past = 1;
            this.iterator = 0;
            CurrentEn = 0;
        }

        bool IEnumerator.MoveNext()
        {
            if (iterator > n) return false;
            int res = past;
            past = CurrentEn;
            CurrentEn = res + CurrentEn;
            iterator++;
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public object Current
        {
            get
            {
                return CurrentEn;
            }
        }
    }

    public class FibonacciSequence : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return new FibonacciIterator(45);
        }
    }
}
