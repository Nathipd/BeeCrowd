using System;
using System.Globalization;

namespace Idades{
    class Program{
        static void Main(string[] args){
            int soma = 0;
            int amostras = 0;

            while(true){
                int idades = int.Parse(Console.ReadLine());
    
                if(idades < 0){
                    break;
                }
                
                amostras ++;

                soma += idades;

            }
            float mediaIdades = (float)soma/(float)amostras;
            System.Console.WriteLine(mediaIdades.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}