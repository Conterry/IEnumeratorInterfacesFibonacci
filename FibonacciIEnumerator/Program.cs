using System;

namespace FibonacciIEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // first variant
            foreach (var elem in new FibonacciSequence())
            {
                Console.WriteLine(elem);
            }

            // second variant
            foreach (var elem in new FibSeq(47))
            {
                Console.WriteLine(elem);
            }
        }   
    }
}
