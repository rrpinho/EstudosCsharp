using System;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100;
            SByte y = 100; //Precisa do using System - Tipo de variável do .NET

            Console.WriteLine(x);
            Console.WriteLine(y);
            /* --------------------------------------*/

            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            
            /* --------------------------------------*/

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            float n5 = 4.5F;
            double n6 = 6.7;
            string nome = "Maria Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            /* --------------------------------------*/

            int n7 = int.MinValue;
            sbyte n8 = sbyte.MaxValue;

            Console.WriteLine(n7);
            Console.WriteLine(n8);

        }
    }
}
