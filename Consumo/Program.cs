using System;
using System.Globalization;

namespace Consumo
{

    class Program
    {
        static void Main(string[] args)
        {
            //Qual a distância percorrida
            int distancia = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            //Qual o gasto de combustível
            double combustivel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ConsumoMedio(distancia, combustivel);
        }
        static void ConsumoMedio(int distancia, double combustivel)
        {
            double consumoMedio = distancia / combustivel;

            System.Console.WriteLine($"{consumoMedio.ToString("F3", CultureInfo.InvariantCulture)} km/l");
        }
    }
}