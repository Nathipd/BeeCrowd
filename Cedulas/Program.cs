using System;
using System.Globalization;

namespace Cedulas
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            int resultado, resto = 0;

            System.Console.WriteLine(valor);

            if (valor >= 100)
            {
                resultado = valor / 100;
                resto = valor % 100;
                valor = resto;

                Console.WriteLine($"{resultado} nota(s) de R$ 100,00");
            }
            else
            {
                Console.WriteLine("0 nota(s) de R$ 100,00");
            }
            if (valor >= 50)
            {
                resultado = valor / 50;
                resto = valor % 50;
                valor = resto;

                Console.WriteLine($"{resultado} nota(s) de R$ 50,00");
            }
            else
            {
                Console.WriteLine("0 nota(s) de R$ 50,00");
            }
            if (valor >= 20)
            {
                resultado = valor / 20;
                resto = valor % 20;
                valor = resto;

                Console.WriteLine($"{resultado} nota(s) de R$ 20,00");
            }
            else
            {
                Console.WriteLine("0 nota(s) de R$ 20,00");
            }
            if (valor >= 10)
            {
                resultado = valor / 10;
                resto = valor % 10;
                valor = resto;

                System.Console.WriteLine($"{resultado} nota(s) de R$ 10,00");
            }
            else
            {
                Console.WriteLine("0 nota(s) de R$ 10,00");
            }
            if (valor >= 5)
            {
                resultado = valor / 5;
                resto = valor % 5;
                valor = resto;

                System.Console.WriteLine($"{resultado} nota(s) de R$ 5,00");
            }
            else
            {
                Console.WriteLine("0 nota(s) de R$ 5,00");
            }
            if (valor >= 2)
            {
                resultado = valor / 2;
                resto = valor % 2;
                valor = resto;

                System.Console.WriteLine($"{resultado} nota(s) de R$ 2,00");

            }
            else
            {
                Console.WriteLine("0 nota(s) de R$ 2,00");
            }
            System.Console.WriteLine($"{valor} nota(s) de R$ 1,00");

        }


    }
}