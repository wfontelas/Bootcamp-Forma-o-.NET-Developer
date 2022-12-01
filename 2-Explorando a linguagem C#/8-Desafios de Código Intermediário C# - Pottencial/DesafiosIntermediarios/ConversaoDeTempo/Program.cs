using System;

    class MinhaClasse {
        static void Main(string[] args) {
            var timeInSeconds = int.Parse(Console.ReadLine());
            
            //TODO: Implementar a formula para calcular as horas.
            var hours = timeInSeconds / 3600;
            
        //TODO: Implementar a formula para calcular as horas.
        var minutes = timeInSeconds / 60;
        var seconds = timeInSeconds % 60;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
