using System;
using System.Globalization;

namespace NotaseMoedas
{
    class Program
    {

        static int CedulasTotais(ref int valor, int valorCedula)
        {

            int resultado, resto = 0;

            resultado = valor / valorCedula;
            resto = valor % valorCedula;
            valor = resto;

            return resultado;
        }
        static void Main(string[] args)
        {
            double valorDouble = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int valor = (int)valorDouble; //converte valor double para int (ignorando valor depois da virgula)

            valorDouble = valorDouble - valor;

            System.Console.WriteLine("NOTAS:");
            Console.WriteLine(CedulasTotais(ref valor, 100) + " nota(s) de R$ 100.00");
            Console.WriteLine(CedulasTotais(ref valor, 50) + " nota(s) de R$ 50.00");
            Console.WriteLine(CedulasTotais(ref valor, 20) + " nota(s) de R$ 20.00");
            Console.WriteLine(CedulasTotais(ref valor, 10) + " nota(s) de R$ 10.00");
            Console.WriteLine(CedulasTotais(ref valor, 5) + " nota(s) de R$ 5.00");
            Console.WriteLine(CedulasTotais(ref valor, 2) + " nota(s) de R$ 2.00");
 
            System.Console.WriteLine("MOEDAS:");

            Console.WriteLine(CedulasTotais(ref valor, 1) + " moeda(s) de R$ 1.00");
            valor = (int)(valorDouble * 100); //converte para int o valor double *100
            Console.WriteLine(CedulasTotais(ref valor, 50) + " moeda(s) de R$ 0.50");
            Console.WriteLine(CedulasTotais(ref valor, 25) + " moeda(s) de R$ 0.25");
            Console.WriteLine(CedulasTotais(ref valor, 10) + " moeda(s) de R$ 0.10");
            Console.WriteLine(CedulasTotais(ref valor, 5) + " moeda(s) de R$ 0.05");
            Console.WriteLine(CedulasTotais(ref valor, 1) + " moeda(s) de R$ 0.01");

        }
    }
}
