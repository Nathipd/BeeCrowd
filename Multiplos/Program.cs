using System;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vetor = Console.ReadLine().Split(' ');

            int A = int.Parse(vetor[0]);
            int B = int.Parse(vetor[1]);

            if (A > B)
            {
                int resto = A % B;
                if (resto == 0)
                {
                    System.Console.WriteLine("Sao Multiplos");
                }
                else
                {
                    System.Console.WriteLine("Nao sao Multiplos");
                }

            }
            else
            {
                int resto = B % A;
                if (resto == 0)
                {
                    System.Console.WriteLine("Sao Multiplos");
                }
                else
                {
                    System.Console.WriteLine("Nao sao Multiplos");
                }
            }
        }
    }
}