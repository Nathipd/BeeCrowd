using System;

namespace CrescenteEDecrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                String[] vetorInput = Console.ReadLine().Split(' ');

                int X = int.Parse(vetorInput[0]);
                int Y = int.Parse(vetorInput[1]);
                
                if (X == Y)
                {
                    break;
                }
                if (X > Y)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    System.Console.WriteLine("Crescente");
                }


            }
        }
    }
}