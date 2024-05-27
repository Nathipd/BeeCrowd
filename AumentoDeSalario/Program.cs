using System;
using System.Globalization;

namespace AumentoDeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            float salarioAtual = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float aumento = 0;
            float salarioNovo = 0;
            float porcentagem = 0;

            if (salarioAtual <= 400.00)
            {
                porcentagem = 0.15F;
            }
            else if (salarioAtual >= 400.01 && salarioAtual <= 800.00)
            {
                porcentagem = 0.12F;
            }
            else if (salarioAtual >= 800.01 && salarioAtual <= 1200.00)
            {
                porcentagem = 0.10F;
            }
            else if (salarioAtual >= 1200.01 && salarioAtual <= 2000.00)
            {
                porcentagem = 0.07F;
            }
            else if(salarioAtual > 2000.00)
            {
                porcentagem = 0.04F;
            }

            aumento = salarioAtual * porcentagem;
            salarioNovo = salarioAtual + aumento;

            Console.WriteLine($"Novo salario: {salarioNovo.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Reajuste ganho: " + aumento.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + (porcentagem * 100) + " %");

        }
    }
}
