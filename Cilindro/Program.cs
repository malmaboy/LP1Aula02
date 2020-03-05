using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variaveis

            string aString,rString;
            float a,r,v, surfArea;
            float pi = 3.1415926f;


            
            Console.WriteLine("Write the height ");
            aString = Console.ReadLine();
            Console.WriteLine("Insert the ray ");
            rString = Console.ReadLine();

            // Coverter os dados

            a = float.Parse(aString);
            r = Convert.ToSingle(rString);

            //Contas

            v = pi * r * r * a;
            surfArea = 2 * pi * r * (r+a);

            //Resultados

            Console.WriteLine($"Volume = {v}");
            Console.WriteLine($"Area = {surfArea}");
        }
    }
}
