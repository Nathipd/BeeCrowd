using System;

// Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor 
// unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

// Entrada
// O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.
// Saída
// A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado 
// com 2 casas após o ponto.



class URI
{
    static void Main(string[] args)
    {
        Console.Write("Código 1");
        int codigo1 = int.Parse(Console.ReadLine());

        Console.Write("Quantidade de peças 1");
        int numPecas1 = int.Parse(Console.ReadLine());

        Console.Write("Valor Unitário de peças 1");
        float valorUnitario1 = float.Parse(Console.ReadLine());


        Console.Write("Código 2");
        int codigo2 = int.Parse(Console.ReadLine());

        Console.Write("Quantidade de peças 2");
        int numPecas2 = int.Parse(Console.ReadLine());

        Console.Write("Valor Unitário de peças 2");
        float valorUnitario2 = float.Parse(Console.ReadLine());

        float valorPagar = (numPecas1 * valorUnitario1) + (numPecas2 * valorUnitario2);
        Console.WriteLine($"VALOR A PAGAR: R$ {valorPagar.ToString("F2")} ");

    }
}