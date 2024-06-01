using System;

namespace tabuada{
    class Program{
        static void Main(string[] args){
            int n = int.Parse(Console.ReadLine());
            
            for(int i=1; i <= 10; i++){
                System.Console.WriteLine($"{i} x {n} = " + (i*n));
                
            }
        }
    }
}