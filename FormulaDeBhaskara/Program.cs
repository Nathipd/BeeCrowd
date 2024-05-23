using System;
using System.Globalization;

namespace FormulaDeBhaskara
{

    class Program
    {
        static void Main(string[] args)
        {

            double A, B, C, delta, x1, x2;

            String[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(B, 2.0) - 4 * A * C;

            if (delta < 0 || A == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                x1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
                x2 = (-B - Math.Sqrt(delta)) / (2.0 * A);
                Console.WriteLine($"R1 = {x1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R2 = {x2.ToString("F5", CultureInfo.InvariantCulture)}");

            }

        }
    }
}