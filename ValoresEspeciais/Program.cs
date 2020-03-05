using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            // Valores maximos e minimos
            /*
            Console.WriteLine($"{double.MinValue}");
            Console.WriteLine($"{double.MaxValue}");

            Console.WriteLine($"{int.MaxValue}");
            Console.WriteLine($"{int.MinValue}");

            Console.WriteLine($"{float.MaxValue}");
            Console.WriteLine($"{float.MinValue}");

            Console.WriteLine($"{long.MaxValue}");
            Console.WriteLine($"{long.MinValue}");

            // Valores infinitos
            Console.WriteLine($"{double.PositiveInfinity}");
            Console.WriteLine($"{double.NegativeInfinity}");

            Console.WriteLine($"{float.NegativeInfinity}");
            Console.WriteLine($"{float.NegativeInfinity}");
            */

            // Overflow com doubles e floats

            double x = 2 * double.MaxValue;
            double p = double.MaxValue + 1;

            float w = 2 * float.MaxValue;
            float g = float.MaxValue + 1;

            Console.WriteLine($"{x}");
            Console.WriteLine($"{p}");
            Console.WriteLine($"{w}");
            Console.WriteLine($"{g}");

            // Underflow com float e double

            float f1 = 10000000000000000;
            float f2 = float.MinValue;
            double g1 = double.MinValue;
            double g2 = double.MaxValue;

            Console.WriteLine(f1 + 0.00000001f);
            Console.WriteLine(g2 * 2000000000);

        }
    }
}
