using System;

//Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e 
//calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

//ENTRADA
//O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o número, quantidade de horas
//trabalhadas e o valor que o funcionário recebe por hora trabalhada, respectivamente.
//SAÍDA
//imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes e depois da igualdade. 
//No caso do salário, também deve haver um espaço em branco após o $.

class URI
{

    static void Main(string[] args)
    {
        int numFuncionario, horasTrabalhadas;
        double valorHora, salario;

        numFuncionario = int.Parse(Console.ReadLine()); //passa de string para int
        horasTrabalhadas = int.Parse(Console.ReadLine()); //passa de string para int

        valorHora = double.Parse(Console.ReadLine());

        salario = valorHora * horasTrabalhadas;

        Console.WriteLine("NUMBER = "+ numFuncionario);
        Console.WriteLine("SALARY = U$ "+ salario.ToString("F2"));
    }

}