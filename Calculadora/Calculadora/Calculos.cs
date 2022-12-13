using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Operações;

namespace Calculadora
{
    public class Operacoes
    {
        public Soma Soma { get; private set; }
        public Multiplicar Multiplicar { get; private set; }
        public Dividir Dividir { get; private set; }
        public Subtrair Subtrair { get; private set; }

        public Operacoes()
        {
            this.Soma = new Soma();
            this.Multiplicar = new Multiplicar();
            this.Dividir = new Dividir();
            this.Subtrair = new Subtrair();
        }
    }
}
