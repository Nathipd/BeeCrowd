using System;

//Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D 
//segundo a fórmula: DIFERENCA = (A * B - C * D).
//
//ENTRADA
//O arquivo de entrada contém 4 valores inteiros.
//SAÍDA
//Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, com um espaço em branco antes e 
//depois da igualdade.

class URI
{

    static void Main(string[] args)
    {
        double A, B, C, D, DIFERENCA;

        A = double.Parse(Console.ReadLine());
        B = double.Parse(Console.ReadLine());
        C = double.Parse(Console.ReadLine());
        D = double.Parse(Console.ReadLine());

        DIFERENCA = ((A * B) - (C * D));

        Console.WriteLine("DIFERENCA = " + DIFERENCA);
    }

}