// See https://aka.ms/new-console-template for more information
using System;

namespace ListProject
{
    class FibonacciSequence
    {

        static int fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return fib(n-1) + fib(n - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(fib(5));
        }
    }
}

