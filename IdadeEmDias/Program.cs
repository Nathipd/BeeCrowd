using System;

namespace IdadeEmDias
{

    class Program
    {
        static void Main(string[] args)
        {
            int dias = int.Parse(Console.ReadLine());

            if (dias >= 365)
            {
                int anos = dias / 365;
                dias %= 365;
                System.Console.WriteLine($"{anos} ano(s)");
            }
            else
            {
                System.Console.WriteLine("0 ano(s)");
            }
            if (dias >= 30)
            {
                int meses = dias / 30;
                dias %= 30;
                System.Console.WriteLine($"{meses} mes(es)");
            }else{
                System.Console.WriteLine("0 mes(es)");

            }
            System.Console.WriteLine($"{dias} dia(s)");
        }
    }
}
