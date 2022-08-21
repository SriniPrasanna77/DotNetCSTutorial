// See https://aka.ms/new-console-template for more information
using System;

namespace HelloConsole
{
    class Program
    {
        static void numsByThree()
        {
            int sum = 0;
            for(int i=1; i<21; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine("Sum is " + sum);
        }

        static void Main(string[] args)
        {
            bool a = 5 > 4;

            if (a && true)
            {
                Console.WriteLine("Its True");
            } else
            {
                Console.WriteLine("Its fAlse");
            }
            Test t = new Test();
            Console.WriteLine(t.test("Srini"));
            t.repeatCode(5);
            numsByThree();
        }
    }

    class Test
    {
        public string test(string name)
        {
            return($"Hello {name}");
        }

        public void repeatCode(int n)
        {
            while(n<10)
            {
                if (n == 8)
                {
                    Console.WriteLine("n is 8");
                } else
                {
                    if (n == 4)
                    {
                        Console.WriteLine("n < 4. so breaking");
                        break;
                    }
                }
                Console.WriteLine($"Looping at {n}");
                n++;
            }
        }
    }

}
