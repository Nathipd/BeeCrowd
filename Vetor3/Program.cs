using System;
using System.Globalization;

namespace Vetor3{
    class Program{
        static void Main(string[] args){
            int number;

            number = int.Parse(Console.ReadLine()); ; // numero de entradas

            // inicialização dos vetores
            string[] nomes = new string[number];
            int[] idades = new int[number];
            double[] alturas = new double[number];

            // faz a leitura dos dados
            for(int i = 0; i < number; i++){
                string[] input = Console.ReadLine().Split(' '); // entradas
                // armazena os dados nos vetores
                nomes[i] = input[0];
                idades[i] = int.Parse(input[1]);
                alturas[i] = double.Parse(input[2], CultureInfo.InvariantCulture);
            }

            // calcula a altura média das pessoas
            double soma = 0.0;
            for(int i=0; i<number; i++){
                soma += alturas[i];
            }
            double media = soma/number;
            System.Console.WriteLine($"Altura média: {media.ToString("F2", CultureInfo.InvariantCulture)}");

            //Porcentagem de pessoas abaixo de 16 anos
            int cont = 0;
            for(int i=0; i<number; i++){
                if (idades[i] < 16){
                    cont++;
                }
            }
            double porcentagem = (double) cont / number * 100.0;
            System.Console.WriteLine($"Pessoas com menos de 16 anos: {porcentagem.ToString("F2", CultureInfo.InvariantCulture)}%");
        }
    }
}