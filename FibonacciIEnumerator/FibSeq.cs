using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FibonacciIEnumerator
{
    class FibSeq : IEnumerable
    {

        private int n;

        public FibSeq(int N)
        {
            this.n = N;
        }

        public IEnumerator GetEnumerator()
        {
            int father = 0;
            int grandfather = 1;
            for(int i=0; i<n; i++)
            {
                yield return father;
                (father, grandfather) = (father + grandfather, father);
            }
        }
    }
}
