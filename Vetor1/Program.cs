using System;

namespace Vetor1{
    class Program{
        static void Main(string[] args){
            int N;
            int[] vetor;

            N = int.Parse(Console.ReadLine());  
            vetor = new int[N];

            string[] vetorInput = Console.ReadLine().Split(' ');

            for (int i=0; i<N; i++){
                vetor[i] = int.Parse(vetorInput[i]);
            }

            for (int i=0; i<N; i++){
                if (vetor[i]<0){
                    System.Console.WriteLine(vetor[i]);
                }
            }

        }
    }
}