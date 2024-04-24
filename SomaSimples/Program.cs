using System;

//Entrada
//O arquivo de entrada contém 2 valores inteiros.
//Saída
//imprima a mensagem "SOMA" com todas as letras maiúsculas, com um espaço em branco antes e depois da igualdade 
//seguido pelo valor correspondente à soma de A e B. Como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, 
//caso contrário, você receberá "Presentation Error".
class URI
{

    static void Main(string[] args)
    {
        double A, B, S;

        A = double.Parse(Console.ReadLine());//convert string to double
        B = double.Parse(Console.ReadLine());

        S = A + B;
        Console.WriteLine("SOMA = " + S.ToString());
    }

}