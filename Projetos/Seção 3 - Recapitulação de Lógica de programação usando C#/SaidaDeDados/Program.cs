using System;
using System.Globalization; //Usando para colocar o . em numero quebrado.

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("---------------------------");

            /*---------------------------------------------*/

            double valor = 24.578642;

            Console.WriteLine(valor.ToString("F2")); //F e o número de casa decimais que será mostrado. Arredondando o valor.
            Console.WriteLine(valor.ToString("F4"));
            Console.WriteLine(valor.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("---------------------------");

            /*-----------------------------------------------*/

            string nome = "Maria";
            int anos = 32;
            double saldo = 10.35784;

            Console.WriteLine("{0} tem {1} anos e R${2:F2} de saldo", nome, anos, saldo);
            Console.WriteLine($"{nome} tem {anos} e anos R${saldo:F2} de saldo");
            Console.WriteLine(nome + " tem " + anos + " anos e R$" + saldo.ToString("F2", CultureInfo.InvariantCulture) + " de saldo");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");


            /*
            Exercicio: Printar na tela:

            Produtos:
            Computador, cujo preço é $ 2100,00
            Mesa de escritório, cujo preco é $ 650,50

            Registro: 30 anos de idade, código 5290 e gênero: M

            Medida com oito casas decimais: 53,23456700
            Arredondado (três casas decimais): 53,235
            Separador decimal invariant culture: 53.235
            */

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1+", cujo preço é $ " + preco1.ToString("F2"));
            Console.WriteLine(produto2+", cujo preco é $" + preco2.ToString("F2"));
            Console.WriteLine();
            Console.WriteLine("Registro: "+idade+" anos de idade, código "+codigo+" e gênero: "+genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: "+medida.ToString("F8"));
            Console.WriteLine("Arredondado (três casas decimais): "+medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: "+medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
