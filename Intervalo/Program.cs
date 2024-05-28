using System;
using System.Globalization;

namespace Intervalo
{
    class Program
    {

        static void Main(string[] args)
        {
            float numero = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string intervalo = "";

            if(numero >= 0 && numero <= 25){
                intervalo = "[0,25]";
            }
            else if(numero >= 25.01 && numero <= 50){
                intervalo = "(25,50]";
            }else if(numero >= 50.01 && numero <= 75){
                intervalo = "(50,75]";
            }else if(numero >= 70.01 && numero <=100){
                intervalo = "(75,100]";
            }else{
                System.Console.WriteLine("Fora de intervalo");
                return;
            }
            
            System.Console.WriteLine($"Intervalo {intervalo}");
        }
    }
}