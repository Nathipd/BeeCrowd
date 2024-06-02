using System;
using System.Globalization;

namespace vetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number; // quantidade de números do vetor
            double[] vetor; // criação do vetor

            number = int.Parse(Console.ReadLine()); //Lê a quantidade de números do usuário
            vetor = new double[number]; // alocação de memória do vetor

            // como o input é uma string e para trabalhar com os números precisa ser int, é feito um for para cada posição do vetor ser parseado
            string[] input = Console.ReadLine().Split(' '); //lê os números do vetor
            for (int i = 0; i < number; i++)
            {
                vetor[i] = double.Parse(input[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < number; i++)
            {
                System.Console.Write(vetor[i] + " ");
            }
            System.Console.WriteLine();

            double soma = 0.0;
            for (int i = 0; i < number; i++)
            {
                soma += vetor[i];
            }
            double media = soma / number;

            System.Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}