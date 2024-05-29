using System;

namespace SenhaFixa{
    class Program{
        static void Main (string[] args){
            while(true){
                string[] vetorInput = Console.ReadLine().Split (' ');

                int senha = int.Parse(vetorInput[0]);

                if(senha == 2002){
                    System.Console.WriteLine("Acesso Permitido");
                    break;
                }else{
                    System.Console.WriteLine("Senha Invalida");
                }
            }
        }
    }
}