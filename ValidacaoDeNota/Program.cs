using System;
using System.Globalization;

namespace ValidacaoDeNota
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float nota1 = -1;
            float nota2 = -1;

            while (true)
            {
                nota1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if(nota1 >= 0 && nota1 <= 10){
                    break;
                }else{
                    System.Console.WriteLine("nota invalida");
                }
            }

            while (true){
                nota2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(nota2 >= 0 && nota2 <= 10){
                    break;
                }else{
                    System.Console.WriteLine("nota invalida");

                }
            }

                float media = (nota1 + nota2)/2.0F;
                System.Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
