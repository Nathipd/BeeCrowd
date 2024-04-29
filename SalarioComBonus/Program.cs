using System;

//Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor 
//ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais.

//ENTRADA
//O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double) com duas casas decimais, representando o salário 
//fixo do vendedor e montante total das vendas efetuadas por este vendedor, respectivamente.
//SAÍDA
//Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.
class URI
{
    static void Main(string[] args)
    {
        string NomeVendedor;
        double SalarioFixo, TotalVendas, SalarioTotal;

        NomeVendedor = Console.ReadLine();
        SalarioFixo = double.Parse(Console.ReadLine()); //converte string para double e atribui seu valor na variável
        TotalVendas = double.Parse(Console.ReadLine()); //converte string para double e atribui seu valor na variáve

        SalarioTotal = SalarioFixo + (TotalVendas*0.15);
        Console.WriteLine("TOTAL = R$" + SalarioTotal.ToString("F2"));
    }
}