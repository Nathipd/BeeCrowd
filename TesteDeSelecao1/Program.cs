using System;

namespace TesteDeSelecao1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split(' ');

            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);
            int C = int.Parse(vet[2]);
            int D = int.Parse(vet[3]);

            int somaCD = C + D;
            int somaAB = A + B;

            int par = A % 2;

            if (par == 0 && C > 0 && D > 0 && somaCD > somaAB && B > C && D > A)
            {
                System.Console.WriteLine("Valores aceitos");

            }
            else
            {
                System.Console.WriteLine("Valores nao aceitos");

            }


        }
    }
}