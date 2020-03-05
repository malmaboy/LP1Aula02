using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = -5;

            int c = a++ + b++;

            Console.WriteLine(c);

            int d = ++a + ++b;

            Console.WriteLine(d);

        }
    }
}
