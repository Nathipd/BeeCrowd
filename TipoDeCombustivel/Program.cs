using System;

namespace TipoDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            while (true)
            {


                int input = int.Parse(Console.ReadLine());
                if (input < 1 && input > 4)
                {
                    Console.WriteLine("Escolha Inválida");
                }
                else if (input == 1)
                {
                    alcool++;
                }
                else if (input == 2)
                {
                    gasolina++;
                }
                else if (input == 3)
                {
                    diesel++;
                }else if( input == 4){
                    break;
                }
            }
            System.Console.WriteLine("MUITO OBRIGADO");
            System.Console.WriteLine($"Alcool: {alcool}");
            System.Console.WriteLine($"Gasolina: {gasolina}");
            System.Console.WriteLine($"Diesel: {diesel}");
        }
    }
}