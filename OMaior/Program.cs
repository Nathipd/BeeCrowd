using System;
using System.Globalization;
// Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula: MaiorAB = (a+b+abs(a-b))/2

// Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

// Entrada
// O arquivo de entrada contém três valores inteiros.
// Saída
// Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".

class URI{
    static void Main(string[] args){
        float A, B, C, AB; 

        string[] input = Console.ReadLine().Split(' ');
        A = float.Parse(input[0], CultureInfo.InvariantCulture);
        B = float.Parse(input[1], CultureInfo.InvariantCulture);
        C = float.Parse(input[2], CultureInfo.InvariantCulture);

        AB = (A + B + Math.Abs(A - B))/2;
    
         if (AB > C){
            Console.WriteLine($"{AB} eh o maior");
         }else{
            Console.WriteLine($"{C} eh o maior");
         }
    }
}