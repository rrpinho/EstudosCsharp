using System;

namespace OperadoresDeAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine(n);
            n += 40;
            Console.WriteLine(n);
            n -= 40;
            Console.WriteLine(n);
            n *= 3;
            Console.WriteLine(n);
            n /= 3;
            Console.WriteLine(n);
            n %= 5;
            Console.WriteLine(n);
            Console.WriteLine("--------------------");
            n++;
            ++n;
            Console.WriteLine(n);
            n--;
            Console.WriteLine(n);
            int i = n++;
            Console.WriteLine(n);
            int j = ++n;
            Console.WriteLine(n);
            Console.WriteLine(i);
            Console.WriteLine(j);
            

            /*--------------------------------------*/
            Console.WriteLine("--------------------");

            string s = "ABC";
            Console.WriteLine(s);
            s += "DEF";
            Console.WriteLine(s);
            
        }
    }
}
