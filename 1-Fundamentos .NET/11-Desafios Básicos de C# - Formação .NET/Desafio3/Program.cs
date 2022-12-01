using System;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi, raio, volume;
            pi = 3.14159;
        //TODO: Complete os espaços em branco com uma possível solução para o desafio     
            raio = double.Parse(Console.ReadLine());
            volume = pi * (4/3.0) * Math.Pow( raio , 3 );
            
            Console.WriteLine($"VOLUME = {Math.Round(volume, 3)}");
        }
    }
}
