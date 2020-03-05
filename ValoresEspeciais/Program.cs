using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine($"{double.MinValue}");
            Console.WriteLine($"{double.MaxValue}");

            Console.WriteLine($"{int.MaxValue}");
            Console.WriteLine($"{int.MinValue}");

            Console.WriteLine($"{float.MaxValue}");
            Console.WriteLine($"{float.MinValue}");

            Console.WriteLine($"{long.MaxValue}");
            Console.WriteLine($"{long.MinValue}");

            Console.WriteLine($"{double.PositiveInfinity}");
            Console.WriteLine($"{double.NegativeInfinity}");

            Console.WriteLine($"{float.NegativeInfinity}");
            Console.WriteLine($"{float.NegativeInfinity}");

        }
    }
}
