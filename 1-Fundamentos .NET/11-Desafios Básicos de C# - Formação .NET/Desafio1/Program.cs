using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int suavariavel = int.Parse(Console.ReadLine());
            string[] n = Console.ReadLine().Split(' ');

            int multiplo2 = 0;
            int multiplo3 = 0;
            int multiplo4 = 0;
            int multiplo5 = 0;
            //TODO: Complete os espaços em branco com uma possível solução para o desafio
            for (int iContador = 0; iContador < suavariavel; iContador++)
            {
                if ((int.Parse(n[iContador]) % 2) == 0) { multiplo2 += 1; }
                if ((int.Parse(n[iContador]) % 3) == 0) { multiplo3 += 1; }
                if ((int.Parse(n[iContador]) % 4) == 0) { multiplo4 += 1; }
                if ((int.Parse(n[iContador]) % 5) == 0) { multiplo5 += 1; }
            }

            Console.WriteLine($"{multiplo2} Multiplo(s) de 2", multiplo2);
            Console.WriteLine($"{multiplo3} Multiplo(s) de 3", multiplo3);
            Console.WriteLine($"{multiplo4} Multiplo(s) de 4", multiplo4);
            Console.WriteLine($"{multiplo5} Multiplo(s) de 5", multiplo5);
            
        }
    }
}
