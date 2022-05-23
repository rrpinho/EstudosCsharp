using System;

namespace ConversaoImplicitaECasting
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 4.7f;
            double b = a;

            double i = 5.1;
            float j = (float) i;

            double m = 9.6;
            int n = (int) m;
            Console.WriteLine(n);

            int f = 5, g = 2;
            double resultado = (double) f / g;
            Console.WriteLine(resultado);

        }
    }
}
