using System;

//Entrada
//O arquivo de entrada contém 2 valores inteiros.
//Saída
//Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade. 
//Não esqueça de imprimir o fim de linha após o produto, caso contrário seu programa apresentará a mensagem: “Presentation Error”.
class URI
{
    static void Main(string[] args)
    {
        double A, B, PROD;

        A = double.Parse(Console.ReadLine());
        B = double.Parse(Console.ReadLine());
        PROD = A * B;

        Console.WriteLine("PROD = " + PROD);
    }

}