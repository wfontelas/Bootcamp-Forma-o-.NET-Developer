using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Computador //Não precisamos colocar o ":Object" para herdar da classe, pois é uma classe raiz
    {
        public override string ToString()
        {
            return "Método tostring sobreescrito";
        }
    }
}