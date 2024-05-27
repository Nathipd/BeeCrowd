using System;

namespace TempoDeJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] VetorInput = Console.ReadLine().Split(' ');

            int horaInicio = int.Parse(VetorInput[0]);
            int horaFim = int.Parse(VetorInput[1]);

            int resultado = 0;
            if (horaFim < horaInicio)
            {
                resultado = 24 - horaInicio;
                resultado = resultado + horaFim;
            }
            else if(horaInicio == horaFim){
                resultado = 24;
            }
            else
            {
                resultado = horaFim - horaInicio;
            }

            Console.WriteLine($"O JOGO DUROU {resultado} HORA(S)" );
        }
    }
}