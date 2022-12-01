using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta //Calsse abstrata, somente modelo
    {
        protected decimal saldo;
        public abstract void Creditar(decimal valor);
        public void ExibirSaldo()
        {
            Console.WriteLine("O saldo é: " + saldo);
        }



    }
}