using System;
using System.Globalization;

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
        int codigo1, codigo2, quantidade1, quantidade2;
        double valorUni1, valorUni2, valorTotal;

        // Array de tamanho variável que lê o input e divide ele a cada espaço.
        string[] valores = Console.ReadLine().Split(' '); 

        // Passa a variável na posição 0 (primeira), de string para int
        codigo1 = int.Parse(valores[0]);
        quantidade1 = int.Parse(valores[1]);
        valorUni1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

        valores = Console.ReadLine().Split(' ');
        codigo2 = int.Parse(valores[0]);
        quantidade2 = int.Parse(valores[1]);
        valorUni2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

        valorTotal = (quantidade1 *valorUni1) + (quantidade2 *valorUni2); 

        Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}" );
    
    }
}